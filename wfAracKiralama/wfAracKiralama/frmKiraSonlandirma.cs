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
    public partial class frmKiraSonlandirma : Form
    {
        public frmKiraSonlandirma()
        {
            InitializeComponent();
        }

        private void frmKiraSonlandirma_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            rbBireysel.Checked = true;
            btnSonlandir.Enabled = false;
        }

        private void rbBireysel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBireysel.Checked == true)
            {
                cKira k = new cKira();
                dgvKiralama.DataSource = k.KiralananGetirBireysel();
                dgvKiralama.Columns["FirmaNo"].Visible = false;
                dgvKiralama.Columns["MusteriNo"].Visible = true;
            }
        }

        private void rbKurumsal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKurumsal.Checked == true)
            {
                cKira k = new cKira();
                List<cKira> list = new List<cKira>();
                list= k.KiralananGetirKurumsal();
                dgvKiralama.DataSource = list;
                dgvKiralama.Columns["MusteriNo"].Visible = false;
                dgvKiralama.Columns["FirmaNo"].Visible = true;
            }
        }

        private void dgvKiralama_DoubleClick(object sender, EventArgs e)
        {
            cArac a = new cArac();
            cKira b = new cKira();
            btnSonlandir.Enabled = true;

            if (rbBireysel.Checked == true)
            {


                a.AracGetirKiraSonlandir(dgvKiralama, a);
                txtAracID1.Text = a.AracID.ToString();
 
            }

            if (rbKurumsal.Checked == true)
            {
                int i = 1;
                List<cKira> list = new List<cKira>();
                b.AracDetayIDGetir(dgvKiralama, b);
                txtKiraDetayID.Text = b.KiraDetayID.ToString();
                list = b.KiralananGetirKurumsalByKiraDetayID(b);
                foreach (var item in list)
                {
                    if(i==1)
                    (txtAracID1).Text = item.AracNo.ToString();
                    if(i==2)
                    (txtAracID2).Text = item.AracNo.ToString();
                    if(i==3)
                    (txtAracID3).Text = item.AracNo.ToString();

                    i++;
                }
            }
        }

        private void btnSonlandir_Click(object sender, EventArgs e)
        {
            cArac a = new cArac();
            cKira b = new cKira();

            if (rbBireysel.Checked == true)
            {
                a.AracGuncelleKiralanabilir(a.AracID);
            }
            else if (rbKurumsal.Checked == true)
            {
                a.AracGuncelleKiralanabilir(Convert.ToInt32(txtAracID1.Text));
                if (txtAracID2.Text != "")
                {
                    a.AracGuncelleKiralanabilir(Convert.ToInt32(txtAracID2.Text));
                }
                if (txtAracID3.Text != "")
                {
                    a.AracGuncelleKiralanabilir(Convert.ToInt32(txtAracID3.Text));
                }
            }
        }
    }
}
