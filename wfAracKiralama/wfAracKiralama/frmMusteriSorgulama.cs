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
    public partial class frmMusteriSorgulama : Form
    {
        public frmMusteriSorgulama()
        {
            InitializeComponent();
        }
        

        private void frmMusteriSorgulama_Load(object sender, EventArgs e)
        {
            rbBireysel.Visible = false;
            rbKurumsal.Visible = false;

            if (cGenel.MusteriTipi == "")
            {
                rbBireysel.Visible = true;
                rbKurumsal.Visible = true;
                rbBireysel.Checked = true;
            }

            else if (cGenel.MusteriTipi == "Kurumsal Müşteri")
            {
                rbKurumsal.Visible = true;
                rbKurumsal.Checked = true;
                cGenel.MusteriTipi = "";
            }

            else 
            {
                rbBireysel.Visible = true;
                rbBireysel.Checked = true;
                cGenel.MusteriTipi = "";
            }
            
        }

        private void dgvMusteri_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void rbBireysel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBireysel.Checked == true)
            {
                DataTable dt = new DataTable();
                cGenel.MusteriTipi = "Bireysel Müşteri";
                cMusteri mus = new cMusteri();
                dt = mus.BireyselMusterileriGetir();
                dgvMusteri.DataSource = dt;
            }

        }

        private void rbKurumsal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKurumsal.Checked == true)
            {
                DataTable dt = new DataTable();
                cGenel.MusteriTipi = "Kurumsal Müşteri";
                cMusteri mus = new cMusteri();
                dt = mus.KurumsalMusterileriGetir();
                dgvMusteri.DataSource = dt;
            }
        }
    }
}
