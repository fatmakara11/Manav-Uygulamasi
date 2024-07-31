using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _WindowsFormIslemleri_
{
    public partial class frmMüşteriListele : Form
    {
        public frmMüşteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void FrmMüşteriListele_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }
        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri", baglanti);
            adtr.Fill(daset, "müşteri");
            dataGridView1.DataSource = daset.Tables["müşteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            label1.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set telefon=@telefon,adres=@adres,email=@email where adsoyad=@adsoyad", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", textBox1.Text);
            komut.Parameters.AddWithValue("@telefon", textBox2.Text);
            komut.Parameters.AddWithValue("@adres", textBox3.Text);
            komut.Parameters.AddWithValue("@email", textBox4.Text);
            //işlemi onaylammaız gerekiyor ve bağlantıyı kapat
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Müşteri kaydı güncellendii");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where adsoyad='" +dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Müşteri kaydı silindii");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
