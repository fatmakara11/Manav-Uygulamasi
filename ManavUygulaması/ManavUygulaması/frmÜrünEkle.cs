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
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
             
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO urun (barkodno, urunadi, miktari, satisfiyati, tarih) VALUES (@barkodno, @urunadi, @miktari, @satisfiyati, @tarih)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
            komut.Parameters.AddWithValue("@miktari", txtMiktarı.Text);
            komut.Parameters.AddWithValue("@satisfiyati",txtSatışFiyatı.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi");

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text == "")
            {
                lblMiktari.Text = "";

                foreach(Control item in groupBox2.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like'"+BarkodNotxt.Text+"' ",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ÜrünAdıtxt.Text = read["urunadi"].ToString();
                Miktarıtxt.Text = read["miktari"].ToString();
                SatışFiyatıtxt.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void btnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'"+ int.Parse(Miktarıtxt.Text)+ "'where barkodno='"+BarkodNotxt.Text+"'", baglanti);
             komut.ExecuteNonQuery();
            baglanti.Close();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var olan ürüne ekleme yapıldı");

         


        }
    }
}
