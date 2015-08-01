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
            this.Top = 0;
            this.Left = 0;
            rbBireysel.Visible = true;
            rbKurumsal.Visible = true;

            if (cGenel.FormMusteri == "")
            {
                rbBireysel.Checked = true;
            }

            else if (cGenel.MusteriTipi == "Kurumsal Müşteri" && cGenel.FormMusteri == "Musteri Getir")
            {
                rbKurumsal.Checked = true;
                rbKurumsal.Visible = false;
                rbBireysel.Visible = false;
            }

            else 
            {               
                rbBireysel.Checked = true;
                rbKurumsal.Visible = false;
                rbBireysel.Visible = false;
            }
            cGenel.FormMusteri = "";
        }

        private void dgvMusteri_DoubleClick(object sender, EventArgs e)
        {
            if (cGenel.FormMusteri == "Musteri Getir")
            {
                cKurumsalMusteri kr = new cKurumsalMusteri();
                cKurumsalMusteri krm = new cKurumsalMusteri();

                krm.MusteriGetirKurumsal(dgvMusteri, kr);

                cGenel.KurumsalMusteriID = kr.FirmaID;
            }
            else
            {
                if (cGenel.MusteriTipi == "Bireysel Müşteri")
                {
                    cBireyselMusteri bm = new cBireyselMusteri();
                    cBireyselMusteri bmg = new cBireyselMusteri();

                    bmg.MusteriGetirBireysel(dgvMusteri, bm);

                    cGenel.BireyselMusteriID = bm.MusteriID;
                }

                else if (cGenel.MusteriTipi == "Kurumsal Müşteri")
                {
                    cKurumsalMusteri kr = new cKurumsalMusteri();
                    cKurumsalMusteri krm = new cKurumsalMusteri();

                    krm.MusteriGetirKurumsal(dgvMusteri, kr);

                    cGenel.KurumsalMusteriID = kr.FirmaID;
                }
            }

            this.Close();
        }

        private void rbBireysel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBireysel.Checked == true)
            {
                DataTable dt = new DataTable();
                cGenel.MusteriTipi = "Bireysel Müşteri";
                cBireyselMusteri mus = new cBireyselMusteri();
                dt = mus.BireyselMusterileriGetir();
                dgvMusteri.DataSource = dt;
                label1.Text = "Ada Göre Arama";
            }
        }

        private void rbKurumsal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKurumsal.Checked == true)
            {
                DataTable dt = new DataTable();
                cGenel.MusteriTipi = "Kurumsal Müşteri";
                cKurumsalMusteri mus = new cKurumsalMusteri();
                dt = mus.KurumsalMusterileriGetir();
                dgvMusteri.DataSource = dt;
                label1.Text = "Unvana Göre Arama";
            }
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            if (rbBireysel.Checked)
            {
                cBireyselMusteri bm = new cBireyselMusteri();

                if (txtAdaGore.Text == null)
                {
                    bm.BireyselMusterileriGetir();
                }
                else
                {
                    dgvMusteri.DataSource = bm.BireyselMusterileriGetirByDetayli(txtAdaGore.Text);
                }
            }

            else if (rbKurumsal.Checked)
            {
                cKurumsalMusteri kr = new cKurumsalMusteri();

                if (txtAdaGore.Text == null)
                {
                    kr.KurumsalMusterileriGetir();
                }
                else
                {
                    dgvMusteri.DataSource = kr.KurumsalMusterileriGetirByDetayli(txtAdaGore.Text);
                }
            }
        }
    }
}
