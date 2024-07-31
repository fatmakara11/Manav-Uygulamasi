namespace _WindowsFormIslemleri_
{
    partial class FrmMüşteriEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAdSoyad = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.AutoSize = true;
            this.txtAdSoyad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(76, 76);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(133, 28);
            this.txtAdSoyad.TabIndex = 0;
            this.txtAdSoyad.Text = "Ad Soyad ";
            // 
            // txtTelefon
            // 
            this.txtTelefon.AutoSize = true;
            this.txtTelefon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(115, 172);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(94, 28);
            this.txtTelefon.TabIndex = 1;
            this.txtTelefon.Text = "Telefon";
            // 
            // txtAdres
            // 
            this.txtAdres.AutoSize = true;
            this.txtAdres.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(129, 268);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(80, 28);
            this.txtAdres.TabIndex = 2;
            this.txtAdres.Text = "Adres";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(124, 364);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(85, 28);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "E-mail";
            // 
            // adsoyad
            // 
            this.adsoyad.Location = new System.Drawing.Point(264, 66);
            this.adsoyad.Multiline = true;
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(336, 49);
            this.adsoyad.TabIndex = 4;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(264, 162);
            this.telefon.Multiline = true;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(336, 49);
            this.telefon.TabIndex = 5;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(264, 258);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(336, 49);
            this.adres.TabIndex = 6;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(264, 354);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(336, 49);
            this.email.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(264, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMüşteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(688, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.MaximizeBox = false;
            this.Name = "FrmMüşteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekleme Sayfası";
            this.Load += new System.EventHandler(this.FrmMüşteriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAdSoyad;
        private System.Windows.Forms.Label txtTelefon;
        private System.Windows.Forms.Label txtAdres;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button button1;
    }
}