namespace wfAracKiralama
{
    partial class frmBireyselMüşteriEkle
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnMusteriGetir = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.rbKayitDegistirme = new System.Windows.Forms.RadioButton();
            this.rbKayitEkle = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDTarihi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDYeri = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUyruk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKimlikNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 27);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(18, 20);
            this.txtID.TabIndex = 85;
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.Location = new System.Drawing.Point(311, 212);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(100, 43);
            this.btnMusteriGetir.TabIndex = 84;
            this.btnMusteriGetir.Text = "Müşterileri Getir";
            this.btnMusteriGetir.UseVisualStyleBackColor = true;
            this.btnMusteriGetir.Click += new System.EventHandler(this.btnMusteriGetir_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(311, 160);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(100, 43);
            this.btnDegistir.TabIndex = 79;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // rbKayitDegistirme
            // 
            this.rbKayitDegistirme.AutoSize = true;
            this.rbKayitDegistirme.Location = new System.Drawing.Point(522, 130);
            this.rbKayitDegistirme.Name = "rbKayitDegistirme";
            this.rbKayitDegistirme.Size = new System.Drawing.Size(100, 17);
            this.rbKayitDegistirme.TabIndex = 78;
            this.rbKayitDegistirme.TabStop = true;
            this.rbKayitDegistirme.Text = "Kayıt Degiştirme";
            this.rbKayitDegistirme.UseVisualStyleBackColor = true;
            this.rbKayitDegistirme.CheckedChanged += new System.EventHandler(this.rbKayitDegistirme_CheckedChanged);
            // 
            // rbKayitEkle
            // 
            this.rbKayitEkle.AutoSize = true;
            this.rbKayitEkle.Location = new System.Drawing.Point(430, 130);
            this.rbKayitEkle.Name = "rbKayitEkle";
            this.rbKayitEkle.Size = new System.Drawing.Size(86, 17);
            this.rbKayitEkle.TabIndex = 76;
            this.rbKayitEkle.TabStop = true;
            this.rbKayitEkle.Text = "Kayıt Ekleme";
            this.rbKayitEkle.UseVisualStyleBackColor = true;
            this.rbKayitEkle.CheckedChanged += new System.EventHandler(this.rbKayitEkle_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçin :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(311, 160);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 43);
            this.btnKaydet.TabIndex = 73;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(114, 235);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Adres";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(114, 209);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Telefon";
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Location = new System.Drawing.Point(114, 183);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.txtCinsiyet.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Cinsiyet";
            // 
            // txtDTarihi
            // 
            this.txtDTarihi.Location = new System.Drawing.Point(114, 157);
            this.txtDTarihi.Name = "txtDTarihi";
            this.txtDTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtDTarihi.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Doğum Tarihi";
            // 
            // txtDYeri
            // 
            this.txtDYeri.Location = new System.Drawing.Point(114, 131);
            this.txtDYeri.Name = "txtDYeri";
            this.txtDYeri.Size = new System.Drawing.Size(100, 20);
            this.txtDYeri.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Doğum Yeri";
            // 
            // txtUyruk
            // 
            this.txtUyruk.Location = new System.Drawing.Point(114, 105);
            this.txtUyruk.Name = "txtUyruk";
            this.txtUyruk.Size = new System.Drawing.Size(100, 20);
            this.txtUyruk.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Uyruk";
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.Location = new System.Drawing.Point(114, 79);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(100, 20);
            this.txtKimlikNo.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "TCKimlik No";
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(114, 53);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriSoyad.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Soyad";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(114, 27);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAd.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Müşteri Ad";
            // 
            // frmBireyselMüşteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 503);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnMusteriGetir);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.rbKayitDegistirme);
            this.Controls.Add(this.rbKayitEkle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDYeri);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUyruk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKimlikNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.label1);
            this.Name = "frmBireyselMüşteriEkle";
            this.Text = "Bireysel Müşteri Ekle/Düzenle";
            this.Load += new System.EventHandler(this.frmBireyselMüşteriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnMusteriGetir;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.RadioButton rbKayitDegistirme;
        private System.Windows.Forms.RadioButton rbKayitEkle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDYeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUyruk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKimlikNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label label1;
    }
}