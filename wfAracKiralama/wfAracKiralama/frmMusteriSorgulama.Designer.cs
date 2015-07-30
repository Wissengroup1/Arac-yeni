namespace wfAracKiralama
{
    partial class frmMusteriSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriSorgulama));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMusteri = new System.Windows.Forms.DataGridView();
            this.rbBireysel = new System.Windows.Forms.RadioButton();
            this.rbKurumsal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ada Göre Arama";
            // 
            // dgvMusteri
            // 
            this.dgvMusteri.AllowUserToAddRows = false;
            this.dgvMusteri.AllowUserToDeleteRows = false;
            this.dgvMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteri.Location = new System.Drawing.Point(77, 122);
            this.dgvMusteri.Name = "dgvMusteri";
            this.dgvMusteri.ReadOnly = true;
            this.dgvMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteri.Size = new System.Drawing.Size(586, 220);
            this.dgvMusteri.TabIndex = 2;
            this.dgvMusteri.DoubleClick += new System.EventHandler(this.dgvMusteri_DoubleClick);
            // 
            // rbBireysel
            // 
            this.rbBireysel.AutoSize = true;
            this.rbBireysel.Location = new System.Drawing.Point(442, 69);
            this.rbBireysel.Name = "rbBireysel";
            this.rbBireysel.Size = new System.Drawing.Size(98, 17);
            this.rbBireysel.TabIndex = 3;
            this.rbBireysel.TabStop = true;
            this.rbBireysel.Text = "Bireysel Müşteri";
            this.rbBireysel.UseVisualStyleBackColor = true;
            this.rbBireysel.CheckedChanged += new System.EventHandler(this.rbBireysel_CheckedChanged);
            // 
            // rbKurumsal
            // 
            this.rbKurumsal.AutoSize = true;
            this.rbKurumsal.Location = new System.Drawing.Point(558, 69);
            this.rbKurumsal.Name = "rbKurumsal";
            this.rbKurumsal.Size = new System.Drawing.Size(105, 17);
            this.rbKurumsal.TabIndex = 4;
            this.rbKurumsal.TabStop = true;
            this.rbKurumsal.Text = "Kurumsal Müşteri";
            this.rbKurumsal.UseVisualStyleBackColor = true;
            this.rbKurumsal.CheckedChanged += new System.EventHandler(this.rbKurumsal_CheckedChanged);
            // 
            // frmMusteriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 379);
            this.Controls.Add(this.rbKurumsal);
            this.Controls.Add(this.rbBireysel);
            this.Controls.Add(this.dgvMusteri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMusteriSorgulama";
            this.Text = "Müşteri Sorgulama";
            this.Load += new System.EventHandler(this.frmMusteriSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMusteri;
        private System.Windows.Forms.RadioButton rbBireysel;
        private System.Windows.Forms.RadioButton rbKurumsal;
    }
}