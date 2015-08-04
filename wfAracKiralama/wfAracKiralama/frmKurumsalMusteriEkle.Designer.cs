namespace wfAracKiralama
{
    partial class frmKurumsalMusteriEkle
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
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.rbKayitDegistirme = new System.Windows.Forms.RadioButton();
            this.rbKayitEkle = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYetkili = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 12);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(18, 20);
            this.txtID.TabIndex = 63;
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.Location = new System.Drawing.Point(201, 212);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(100, 43);
            this.btnMusteriGetir.TabIndex = 62;
            this.btnMusteriGetir.Text = "Müşterileri Getir";
            this.btnMusteriGetir.UseVisualStyleBackColor = true;
            this.btnMusteriGetir.Click += new System.EventHandler(this.btnMusteriGetir_Click);
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(311, 38);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(113, 20);
            this.txtVergiNo.TabIndex = 61;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(201, 151);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(100, 43);
            this.btnDegistir.TabIndex = 60;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // rbKayitDegistirme
            // 
            this.rbKayitDegistirme.AutoSize = true;
            this.rbKayitDegistirme.Location = new System.Drawing.Point(329, 118);
            this.rbKayitDegistirme.Name = "rbKayitDegistirme";
            this.rbKayitDegistirme.Size = new System.Drawing.Size(100, 17);
            this.rbKayitDegistirme.TabIndex = 59;
            this.rbKayitDegistirme.TabStop = true;
            this.rbKayitDegistirme.Text = "Kayıt Degiştirme";
            this.rbKayitDegistirme.UseVisualStyleBackColor = true;
            this.rbKayitDegistirme.CheckedChanged += new System.EventHandler(this.rbKayitDegistirme_CheckedChanged);
            // 
            // rbKayitEkle
            // 
            this.rbKayitEkle.AutoSize = true;
            this.rbKayitEkle.Location = new System.Drawing.Point(239, 118);
            this.rbKayitEkle.Name = "rbKayitEkle";
            this.rbKayitEkle.Size = new System.Drawing.Size(86, 17);
            this.rbKayitEkle.TabIndex = 58;
            this.rbKayitEkle.TabStop = true;
            this.rbKayitEkle.Text = "Kayıt Ekleme";
            this.rbKayitEkle.UseVisualStyleBackColor = true;
            this.rbKayitEkle.CheckedChanged += new System.EventHandler(this.rbKayitEkle_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçin :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(201, 151);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 43);
            this.btnKaydet.TabIndex = 56;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(311, 64);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(113, 20);
            this.txtVergiDairesi.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(231, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Vergi Dairesi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(231, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Vergi No";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(311, 12);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(113, 20);
            this.txtTelefon.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(231, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "Telefon";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(114, 64);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 52);
            this.txtAdres.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Adres";
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(114, 38);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(100, 20);
            this.txtYetkili.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Yetkili";
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(114, 12);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(100, 20);
            this.txtUnvan.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Unvan";
            // 
            // frmKurumsalMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 438);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnMusteriGetir);
            this.Controls.Add(this.txtVergiNo);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.rbKayitDegistirme);
            this.Controls.Add(this.rbKayitEkle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYetkili);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.label1);
            this.Name = "frmKurumsalMusteriEkle";
            this.Text = "Kurumsal Müşteri Ekle/Düzenle";
            this.Load += new System.EventHandler(this.frmKurumsalMusteriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnMusteriGetir;
        private System.Windows.Forms.TextBox txtVergiNo;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.RadioButton rbKayitDegistirme;
        private System.Windows.Forms.RadioButton rbKayitEkle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label label1;

    }
}