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
            this.btnYazdir = new System.Windows.Forms.Button();
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
            this.lvAraclar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.ppdFatura = new System.Windows.Forms.PrintPreviewDialog();
            this.pdocFatura = new System.Drawing.Printing.PrintDocument();
            this.chOzelIndirim = new System.Windows.Forms.CheckBox();
            this.cbOzelIndirim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralama)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(147, 343);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 33);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(65, 421);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(75, 33);
            this.btnKirala.TabIndex = 10;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(146, 421);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 33);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(255, 421);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 33);
            this.btnYazdir.TabIndex = 12;
            this.btnYazdir.Text = "Fatura Çıkar";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
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
            this.dgvKiralama.Location = new System.Drawing.Point(377, 26);
            this.dgvKiralama.Name = "dgvKiralama";
            this.dgvKiralama.ReadOnly = true;
            this.dgvKiralama.Size = new System.Drawing.Size(557, 213);
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
            this.txtTutar.Location = new System.Drawing.Point(121, 395);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(116, 20);
            this.txtTutar.TabIndex = 32;
            this.txtTutar.Text = "0";
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(159, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "TUTAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Günlük Ücret";
            // 
            // txtGunlukUcret
            // 
            this.txtGunlukUcret.Location = new System.Drawing.Point(120, 317);
            this.txtGunlukUcret.Name = "txtGunlukUcret";
            this.txtGunlukUcret.ReadOnly = true;
            this.txtGunlukUcret.Size = new System.Drawing.Size(116, 20);
            this.txtGunlukUcret.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(120, 291);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(116, 20);
            this.txtModel.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Marka";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(120, 265);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.ReadOnly = true;
            this.txtMarka.Size = new System.Drawing.Size(116, 20);
            this.txtMarka.TabIndex = 34;
            // 
            // btnAracGetir
            // 
            this.btnAracGetir.Location = new System.Drawing.Point(120, 235);
            this.btnAracGetir.Name = "btnAracGetir";
            this.btnAracGetir.Size = new System.Drawing.Size(88, 24);
            this.btnAracGetir.TabIndex = 42;
            this.btnAracGetir.Text = "Araç Getir";
            this.btnAracGetir.UseVisualStyleBackColor = true;
            this.btnAracGetir.Click += new System.EventHandler(this.btnAracGetir_Click);
            // 
            // txtAracID
            // 
            this.txtAracID.Location = new System.Drawing.Point(214, 239);
            this.txtAracID.Name = "txtAracID";
            this.txtAracID.ReadOnly = true;
            this.txtAracID.Size = new System.Drawing.Size(23, 20);
            this.txtAracID.TabIndex = 43;
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(242, 284);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(88, 33);
            this.btnAracEkle.TabIndex = 44;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // lvAraclar
            // 
            this.lvAraclar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvAraclar.FullRowSelect = true;
            this.lvAraclar.Location = new System.Drawing.Point(377, 284);
            this.lvAraclar.MultiSelect = false;
            this.lvAraclar.Name = "lvAraclar";
            this.lvAraclar.Size = new System.Drawing.Size(557, 168);
            this.lvAraclar.TabIndex = 45;
            this.lvAraclar.UseCompatibleStateImageBehavior = false;
            this.lvAraclar.View = System.Windows.Forms.View.Details;
            this.lvAraclar.Click += new System.EventHandler(this.lvAraclar_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Marka";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yıl";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Günlük Ücret";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "KM";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Gidiş Tarihi";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Dönüş Tarihi";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tutar";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(239, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "TL";
            // 
            // ppdFatura
            // 
            this.ppdFatura.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdFatura.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdFatura.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdFatura.Document = this.pdocFatura;
            this.ppdFatura.Enabled = true;
            this.ppdFatura.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdFatura.Icon")));
            this.ppdFatura.Name = "ppdFatura";
            this.ppdFatura.Visible = false;
            // 
            // pdocFatura
            // 
            this.pdocFatura.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocFatura_PrintPage);
            // 
            // chOzelIndirim
            // 
            this.chOzelIndirim.AutoSize = true;
            this.chOzelIndirim.Location = new System.Drawing.Point(854, 261);
            this.chOzelIndirim.Name = "chOzelIndirim";
            this.chOzelIndirim.Size = new System.Drawing.Size(15, 14);
            this.chOzelIndirim.TabIndex = 47;
            this.chOzelIndirim.UseVisualStyleBackColor = true;
            this.chOzelIndirim.CheckedChanged += new System.EventHandler(this.chOzelIndirim_CheckedChanged);
            // 
            // cbOzelIndirim
            // 
            this.cbOzelIndirim.FormattingEnabled = true;
            this.cbOzelIndirim.Items.AddRange(new object[] {
            "%5",
            "%10",
            "%15",
            "%20",
            "%25",
            "%30",
            "%50"});
            this.cbOzelIndirim.Location = new System.Drawing.Point(13, 343);
            this.cbOzelIndirim.Name = "cbOzelIndirim";
            this.cbOzelIndirim.Size = new System.Drawing.Size(83, 21);
            this.cbOzelIndirim.TabIndex = 48;
            this.cbOzelIndirim.Visible = false;
            // 
            // frmAracKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 481);
            this.Controls.Add(this.cbOzelIndirim);
            this.Controls.Add(this.chOzelIndirim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvAraclar);
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
            this.Controls.Add(this.btnYazdir);
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
        private System.Windows.Forms.Button btnYazdir;
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
        private System.Windows.Forms.ListView lvAraclar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PrintPreviewDialog ppdFatura;
        private System.Drawing.Printing.PrintDocument pdocFatura;
        private System.Windows.Forms.CheckBox chOzelIndirim;
        private System.Windows.Forms.ComboBox cbOzelIndirim;
    }
}