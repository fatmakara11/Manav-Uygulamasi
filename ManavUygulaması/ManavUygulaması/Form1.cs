
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _WindowsFormIslemleri_.Models;

namespace _WindowsFormIslemleri_
{
    public partial class FormLogin : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        public FormLogin()
        {
            InitializeComponent();
        }
        public static int Id;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO PersonelGirisTablosu (MailAdress, Password) VALUES (@MailAdress, @Password)", baglanti);
            komut.Parameters.AddWithValue("@MailAdress", textBox5.Text);
            komut.Parameters.AddWithValue("@Password", textBox6.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            // Eşleşme kontrolü için bir sorgu ekleyin
            baglanti.Open();
            SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM PersonelGirisTablosu WHERE MailAdress = @MailAdress AND Password = @Password", baglanti);
            kontrolKomut.Parameters.AddWithValue("@MailAdress", textBox5.Text);
            kontrolKomut.Parameters.AddWithValue("@Password", textBox6.Text);

            int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());
            baglanti.Close();

            if (kayitSayisi > 0)
            {
                // Eğer eşleşme varsa, timer'ı başlat
                this.timer1.Start();
            }
            else
            {
                MessageBox.Show("Girilen Bilgiler Gerçeği İle Uyuşmamaktadır", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            SifreTazele st = new SifreTazele();
            st.ShowDialog();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(35);
            if (progressBar1.Value>= progressBar1.Maximum)
            {
                timer1.Stop();
                GirisBasarili gb = new GirisBasarili();
                gb.Show();
                this.Hide();
            }
        }
    }
}