namespace wfAracKiralama
{
    partial class frmAracSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracSorgulama));
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.cbYakitTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSanzimanTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarkayaGore = new System.Windows.Forms.TextBox();
            this.cbKiraDurumu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.AllowUserToAddRows = false;
            this.dgvAraclar.AllowUserToDeleteRows = false;
            this.dgvAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraclar.Location = new System.Drawing.Point(47, 170);
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.ReadOnly = true;
            this.dgvAraclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAraclar.Size = new System.Drawing.Size(549, 272);
            this.dgvAraclar.TabIndex = 17;
            this.dgvAraclar.DoubleClick += new System.EventHandler(this.dgvAraclar_DoubleClick);
            // 
            // cbYakitTuru
            // 
            this.cbYakitTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYakitTuru.FormattingEnabled = true;
            this.cbYakitTuru.Items.AddRange(new object[] {
            "Hepsi",
            "Dizel",
            "Benzin",
            "Benzin/LPG"});
            this.cbYakitTuru.Location = new System.Drawing.Point(323, 34);
            this.cbYakitTuru.Name = "cbYakitTuru";
            this.cbYakitTuru.Size = new System.Drawing.Size(121, 21);
            this.cbYakitTuru.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Yakıt Türüne Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Şanzıman Tipine Göre";
            // 
            // cbSanzimanTipi
            // 
            this.cbSanzimanTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanzimanTipi.FormattingEnabled = true;
            this.cbSanzimanTipi.Items.AddRange(new object[] {
            "Hepsi",
            "Manuel",
            "Otomatik"});
            this.cbSanzimanTipi.Location = new System.Drawing.Point(196, 33);
            this.cbSanzimanTipi.Name = "cbSanzimanTipi";
            this.cbSanzimanTipi.Size = new System.Drawing.Size(121, 21);
            this.cbSanzimanTipi.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Markaya Göre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(288, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Araçlar";
            // 
            // txtMarkayaGore
            // 
            this.txtMarkayaGore.Location = new System.Drawing.Point(90, 34);
            this.txtMarkayaGore.Name = "txtMarkayaGore";
            this.txtMarkayaGore.Size = new System.Drawing.Size(100, 20);
            this.txtMarkayaGore.TabIndex = 10;
            this.txtMarkayaGore.TextChanged += new System.EventHandler(this.txtMarkayaGore_TextChanged);
            // 
            // cbKiraDurumu
            // 
            this.cbKiraDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKiraDurumu.FormattingEnabled = true;
            this.cbKiraDurumu.Items.AddRange(new object[] {
            "Hepsi",
            "Uygun",
            "Uygun Değil"});
            this.cbKiraDurumu.Location = new System.Drawing.Point(450, 34);
            this.cbKiraDurumu.Name = "cbKiraDurumu";
            this.cbKiraDurumu.Size = new System.Drawing.Size(121, 21);
            this.cbKiraDurumu.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kira Durumu";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(280, 92);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 34);
            this.btnGetir.TabIndex = 20;
            this.btnGetir.Text = "Araçları Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // frmAracSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 454);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.cbKiraDurumu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvAraclar);
            this.Controls.Add(this.cbYakitTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSanzimanTipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarkayaGore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAracSorgulama";
            this.Text = "Araç Sorgulama";
            this.Load += new System.EventHandler(this.frmAracSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYakitTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSanzimanTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarkayaGore;
        private System.Windows.Forms.ComboBox cbKiraDurumu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.DataGridView dgvAraclar;
    }
}