using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfAracKiralama
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAcikmi(Form AcilacakForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (AcilacakForm.Name == MdiChildren[i].Name)
                {
                    Acikmi = true;
                    this.MdiChildren[i].Focus();
                }
            }
            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose();
            }
        }

        private void araçKiralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracKiralama frm = new frmAracKiralama();
            FormAcikmi(frm);
        }

        private void müşteriSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            FormAcikmi(frm);
        }

        private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracEkle frm = new frmAracEkle();
            FormAcikmi(frm);
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void araçSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracSorgulama frm = new frmAracSorgulama();
            FormAcikmi(frm);
        }
    }
}
