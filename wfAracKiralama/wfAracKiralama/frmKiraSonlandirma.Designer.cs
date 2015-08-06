namespace wfAracKiralama
{
    partial class frmKiraSonlandirma
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
            this.dgvKiralama = new System.Windows.Forms.DataGridView();
            this.rbBireysel = new System.Windows.Forms.RadioButton();
            this.rbKurumsal = new System.Windows.Forms.RadioButton();
            this.txtAracID1 = new System.Windows.Forms.TextBox();
            this.txtAracID2 = new System.Windows.Forms.TextBox();
            this.txtAracID3 = new System.Windows.Forms.TextBox();
            this.btnSonlandir = new System.Windows.Forms.Button();
            this.txtKiraDetayID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralama)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKiralama
            // 
            this.dgvKiralama.AllowUserToAddRows = false;
            this.dgvKiralama.AllowUserToDeleteRows = false;
            this.dgvKiralama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralama.Location = new System.Drawing.Point(80, 67);
            this.dgvKiralama.Name = "dgvKiralama";
            this.dgvKiralama.ReadOnly = true;
            this.dgvKiralama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKiralama.Size = new System.Drawing.Size(557, 252);
            this.dgvKiralama.TabIndex = 15;
            this.dgvKiralama.DoubleClick += new System.EventHandler(this.dgvKiralama_DoubleClick);
            // 
            // rbBireysel
            // 
            this.rbBireysel.AutoSize = true;
            this.rbBireysel.Location = new System.Drawing.Point(236, 24);
            this.rbBireysel.Name = "rbBireysel";
            this.rbBireysel.Size = new System.Drawing.Size(108, 17);
            this.rbBireysel.TabIndex = 16;
            this.rbBireysel.Text = "Bireysel Kiralanan";
            this.rbBireysel.UseVisualStyleBackColor = true;
            this.rbBireysel.CheckedChanged += new System.EventHandler(this.rbBireysel_CheckedChanged);
            // 
            // rbKurumsal
            // 
            this.rbKurumsal.AutoSize = true;
            this.rbKurumsal.Location = new System.Drawing.Point(346, 24);
            this.rbKurumsal.Name = "rbKurumsal";
            this.rbKurumsal.Size = new System.Drawing.Size(115, 17);
            this.rbKurumsal.TabIndex = 17;
            this.rbKurumsal.Text = "Kurumsal Kiralanan";
            this.rbKurumsal.UseVisualStyleBackColor = true;
            this.rbKurumsal.CheckedChanged += new System.EventHandler(this.rbKurumsal_CheckedChanged);
            // 
            // txtAracID1
            // 
            this.txtAracID1.Location = new System.Drawing.Point(80, 21);
            this.txtAracID1.Name = "txtAracID1";
            this.txtAracID1.ReadOnly = true;
            this.txtAracID1.Size = new System.Drawing.Size(23, 20);
            this.txtAracID1.TabIndex = 44;
            this.txtAracID1.Visible = false;
            // 
            // txtAracID2
            // 
            this.txtAracID2.Location = new System.Drawing.Point(109, 21);
            this.txtAracID2.Name = "txtAracID2";
            this.txtAracID2.ReadOnly = true;
            this.txtAracID2.Size = new System.Drawing.Size(23, 20);
            this.txtAracID2.TabIndex = 45;
            this.txtAracID2.Visible = false;
            // 
            // txtAracID3
            // 
            this.txtAracID3.Location = new System.Drawing.Point(138, 21);
            this.txtAracID3.Name = "txtAracID3";
            this.txtAracID3.ReadOnly = true;
            this.txtAracID3.Size = new System.Drawing.Size(23, 20);
            this.txtAracID3.TabIndex = 46;
            this.txtAracID3.Visible = false;
            // 
            // btnSonlandir
            // 
            this.btnSonlandir.Location = new System.Drawing.Point(303, 397);
            this.btnSonlandir.Name = "btnSonlandir";
            this.btnSonlandir.Size = new System.Drawing.Size(75, 34);
            this.btnSonlandir.TabIndex = 47;
            this.btnSonlandir.Text = "Kira Sonlandır";
            this.btnSonlandir.UseVisualStyleBackColor = true;
            this.btnSonlandir.Click += new System.EventHandler(this.btnSonlandir_Click);
            // 
            // txtKiraDetayID
            // 
            this.txtKiraDetayID.Location = new System.Drawing.Point(167, 21);
            this.txtKiraDetayID.Name = "txtKiraDetayID";
            this.txtKiraDetayID.ReadOnly = true;
            this.txtKiraDetayID.Size = new System.Drawing.Size(23, 20);
            this.txtKiraDetayID.TabIndex = 48;
            this.txtKiraDetayID.Visible = false;
            // 
            // frmKiraSonlandirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 458);
            this.Controls.Add(this.txtKiraDetayID);
            this.Controls.Add(this.btnSonlandir);
            this.Controls.Add(this.txtAracID3);
            this.Controls.Add(this.txtAracID2);
            this.Controls.Add(this.txtAracID1);
            this.Controls.Add(this.rbKurumsal);
            this.Controls.Add(this.rbBireysel);
            this.Controls.Add(this.dgvKiralama);
            this.Name = "frmKiraSonlandirma";
            this.Text = "Kira Sonlandırma";
            this.Load += new System.EventHandler(this.frmKiraSonlandirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKiralama;
        private System.Windows.Forms.RadioButton rbBireysel;
        private System.Windows.Forms.RadioButton rbKurumsal;
        private System.Windows.Forms.TextBox txtAracID1;
        private System.Windows.Forms.TextBox txtAracID2;
        private System.Windows.Forms.TextBox txtAracID3;
        private System.Windows.Forms.Button btnSonlandir;
        private System.Windows.Forms.TextBox txtKiraDetayID;
    }
}