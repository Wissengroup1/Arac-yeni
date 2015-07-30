namespace wfAracKiralama
{
    partial class frmAracKiralama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracKiralama));
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnKirala = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnMusteriGetir = new System.Windows.Forms.Button();
            this.dgvKiralama = new System.Windows.Forms.DataGridView();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.cbMusteriTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.dtpGidis = new System.Windows.Forms.DateTimePicker();
            this.dtpDonus = new System.Windows.Forms.DateTimePicker();
            this.txtGidis = new System.Windows.Forms.TextBox();
            this.txtDonus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGunlukUcret = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.btnAracGetir = new System.Windows.Forms.Button();
            this.txtAracID = new System.Windows.Forms.TextBox();
            this.btnAracEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralama)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(187, 285);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 33);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(270, 285);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(75, 33);
            this.btnKirala.TabIndex = 10;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(432, 285);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 33);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(351, 285);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 33);
            this.btnDegistir.TabIndex = 12;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.Location = new System.Drawing.Point(242, 23);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(88, 24);
            this.btnMusteriGetir.TabIndex = 13;
            this.btnMusteriGetir.Text = "Müşteri Getir";
            this.btnMusteriGetir.UseVisualStyleBackColor = true;
            this.btnMusteriGetir.Click += new System.EventHandler(this.btnMusteriGetir_Click);
            // 
            // dgvKiralama
            // 
            this.dgvKiralama.AllowUserToAddRows = false;
            this.dgvKiralama.AllowUserToDeleteRows = false;
            this.dgvKiralama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralama.Location = new System.Drawing.Point(557, 26);
            this.dgvKiralama.Name = "dgvKiralama";
            this.dgvKiralama.ReadOnly = true;
            this.dgvKiralama.Size = new System.Drawing.Size(377, 254);
            this.dgvKiralama.TabIndex = 14;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(120, 63);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.ReadOnly = true;
            this.txtMusteriAd.Size = new System.Drawing.Size(116, 20);
            this.txtMusteriAd.TabIndex = 15;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(28, 66);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(57, 13);
            this.lblAd.TabIndex = 16;
            this.lblAd.Text = "Müşteri Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(28, 92);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 18;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 89);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(116, 20);
            this.txtSoyad.TabIndex = 17;
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(28, 118);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(68, 13);
            this.lblTCNo.TabIndex = 20;
            this.lblTCNo.Text = "TC Kimlik No";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(120, 115);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.ReadOnly = true;
            this.txtTCNo.Size = new System.Drawing.Size(116, 20);
            this.txtTCNo.TabIndex = 19;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(28, 144);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 22;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(120, 141);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(116, 20);
            this.txtTelefon.TabIndex = 21;
            // 
            // cbMusteriTipi
            // 
            this.cbMusteriTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMusteriTipi.FormattingEnabled = true;
            this.cbMusteriTipi.Items.AddRange(new object[] {
            "Bireysel Müşteri",
            "Kurumsal Müşteri"});
            this.cbMusteriTipi.Location = new System.Drawing.Point(120, 23);
            this.cbMusteriTipi.Name = "cbMusteriTipi";
            this.cbMusteriTipi.Size = new System.Drawing.Size(116, 21);
            this.cbMusteriTipi.TabIndex = 23;
            this.cbMusteriTipi.SelectedIndexChanged += new System.EventHandler(this.cbMusteriTipi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Müşteri Tipi";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(336, 25);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.ReadOnly = true;
            this.txtMusteriID.Size = new System.Drawing.Size(23, 20);
            this.txtMusteriID.TabIndex = 25;
            // 
            // dtpGidis
            // 
            this.dtpGidis.Location = new System.Drawing.Point(242, 169);
            this.dtpGidis.Name = "dtpGidis";
            this.dtpGidis.Size = new System.Drawing.Size(20, 20);
            this.dtpGidis.TabIndex = 26;
            this.dtpGidis.ValueChanged += new System.EventHandler(this.dtpGidis_ValueChanged);
            // 
            // dtpDonus
            // 
            this.dtpDonus.Location = new System.Drawing.Point(242, 195);
            this.dtpDonus.Name = "dtpDonus";
            this.dtpDonus.Size = new System.Drawing.Size(20, 20);
            this.dtpDonus.TabIndex = 27;
            this.dtpDonus.ValueChanged += new System.EventHandler(this.dtpDonus_ValueChanged);
            // 
            // txtGidis
            // 
            this.txtGidis.Location = new System.Drawing.Point(120, 169);
            this.txtGidis.Name = "txtGidis";
            this.txtGidis.ReadOnly = true;
            this.txtGidis.Size = new System.Drawing.Size(116, 20);
            this.txtGidis.TabIndex = 28;
            // 
            // txtDonus
            // 
            this.txtDonus.Location = new System.Drawing.Point(120, 195);
            this.txtDonus.Name = "txtDonus";
            this.txtDonus.ReadOnly = true;
            this.txtDonus.Size = new System.Drawing.Size(116, 20);
            this.txtDonus.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kiralandığı Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Dönüş Tarihi";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(284, 239);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(116, 20);
            this.txtTutar.TabIndex = 32;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(319, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "TUTAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Günlük Ücret";
            // 
            // txtGunlukUcret
            // 
            this.txtGunlukUcret.Location = new System.Drawing.Point(404, 118);
            this.txtGunlukUcret.Name = "txtGunlukUcret";
            this.txtGunlukUcret.ReadOnly = true;
            this.txtGunlukUcret.Size = new System.Drawing.Size(116, 20);
            this.txtGunlukUcret.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(404, 92);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(116, 20);
            this.txtModel.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Marka";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(404, 66);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.ReadOnly = true;
            this.txtMarka.Size = new System.Drawing.Size(116, 20);
            this.txtMarka.TabIndex = 34;
            // 
            // btnAracGetir
            // 
            this.btnAracGetir.Location = new System.Drawing.Point(404, 22);
            this.btnAracGetir.Name = "btnAracGetir";
            this.btnAracGetir.Size = new System.Drawing.Size(88, 24);
            this.btnAracGetir.TabIndex = 42;
            this.btnAracGetir.Text = "Araç Getir";
            this.btnAracGetir.UseVisualStyleBackColor = true;
            this.btnAracGetir.Click += new System.EventHandler(this.btnAracGetir_Click);
            // 
            // txtAracID
            // 
            this.txtAracID.Location = new System.Drawing.Point(498, 25);
            this.txtAracID.Name = "txtAracID";
            this.txtAracID.ReadOnly = true;
            this.txtAracID.Size = new System.Drawing.Size(23, 20);
            this.txtAracID.TabIndex = 43;
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(404, 144);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(88, 23);
            this.btnAracEkle.TabIndex = 44;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            // 
            // frmAracKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 338);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.txtAracID);
            this.Controls.Add(this.btnAracGetir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGunlukUcret);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDonus);
            this.Controls.Add(this.txtGidis);
            this.Controls.Add(this.dtpDonus);
            this.Controls.Add(this.dtpGidis);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMusteriTipi);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.dgvKiralama);
            this.Controls.Add(this.btnMusteriGetir);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.btnHesapla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAracKiralama";
            this.Text = "Araç Kiralama";
            this.Load += new System.EventHandler(this.frmAracKiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnMusteriGetir;
        private System.Windows.Forms.DataGridView dgvKiralama;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox cbMusteriTipi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.DateTimePicker dtpGidis;
        private System.Windows.Forms.DateTimePicker dtpDonus;
        private System.Windows.Forms.TextBox txtGidis;
        private System.Windows.Forms.TextBox txtDonus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGunlukUcret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Button btnAracGetir;
        private System.Windows.Forms.TextBox txtAracID;
        private System.Windows.Forms.Button btnAracEkle;
    }
}