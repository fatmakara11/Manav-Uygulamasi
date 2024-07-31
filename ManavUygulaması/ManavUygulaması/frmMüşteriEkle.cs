using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _WindowsFormIslemleri_
{
    public partial class FrmMüşteriEkle : Form
    {
        public FrmMüşteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void FrmMüşteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //müşteri kaydını tabloya ekleyeceğiz
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into müşteri(adsoyad,telefon,adres,email) values(@adsoyad,@telefon,@adres,@email)", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", adsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", telefon.Text);
            komut.Parameters.AddWithValue("@adres", adres.Text);
            komut.Parameters.AddWithValue("@email", email.Text);
            //işlemi onaylammaız gerekiyor ve bağlantıyı kapat
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı eklendii");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
             
        }
    }
}
