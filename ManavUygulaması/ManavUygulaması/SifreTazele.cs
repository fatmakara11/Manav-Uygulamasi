﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _WindowsFormIslemleri_.Models;
using WindowsFormIslemleri.Models;

namespace _WindowsFormIslemleri_
{
    public partial class SifreTazele : Form
    {
        public SifreTazele()
        {
            InitializeComponent();
        }
        MailGönderici mg = new MailGönderici();
        private void SifreTazele_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mg.Microsoft(textBox1.Text, textBox2.Text, textBox1.Text);
            MessageBox.Show("Girilen bilgiler doğru ise şifreniz yenilenecek ve e-mail olarak gönderilecektir.", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
