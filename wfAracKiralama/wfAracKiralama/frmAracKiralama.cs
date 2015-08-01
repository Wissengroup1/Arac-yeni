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
    public partial class frmAracKiralama : Form
    {
        public frmAracKiralama()
        {
            InitializeComponent();
        }
        private void frmAracKiralama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            cbMusteriTipi.SelectedIndex = 0;
            btnKirala.Enabled = false;
            txtGidis.Text = DateTime.Now.ToShortDateString();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            btnKirala.Enabled = true;

            TimeSpan t =dtpDonus.Value - dtpGidis.Value;
            double a = Convert.ToDouble((t.TotalHours / 24));
            int b = (int)a;     
            int kiragun=0;
            if (b + 1 > 0)
            {
                kiragun = b + 1;
                txtTutar.Text = Convert.ToString(kiragun*Convert.ToInt32(txtGunlukUcret.Text));
            }

            else 
            {
                MessageBox.Show("Dönüş Tarihi, Gidiş Tarihinden geç olmalıdır.");
            }
        }

        private void cbMusteriTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();

            if (cbMusteriTipi.SelectedIndex == 0)
            {
                lblAd.Text = "Müşteri Ad";
                lblSoyad.Text = "Müşteri Soyad";
                lblTCNo.Text = "TC Kimlik No";
                lblTelefon.Text = "Telefon";
                lblTelefon.Visible = true;
                txtTelefon.Visible = true;
                btnAracEkle.Visible = false;
            }
            else if (cbMusteriTipi.SelectedIndex == 1)
            {
                lblAd.Text = "Firma Adı";
                lblSoyad.Text = "Yetkili";
                lblTCNo.Text = "Telefon";
                lblTelefon.Visible = false;
                txtTelefon.Visible = false;
                btnAracEkle.Visible = true;
                
            }
        }

        private void btnMusteriGetir_Click(object sender, EventArgs e)
        {          
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            cGenel.FormMusteri = "Musteri Getir";

            if (cbMusteriTipi.Text == "Bireysel Müşteri")
            {
                cGenel.MusteriTipi = "Bireysel Müşteri";

                frm.ShowDialog();

                cBireyselMusteri bm = new cBireyselMusteri();
                cBireyselMusteri bmg = new cBireyselMusteri();

                txtMusteriID.Text = cGenel.BireyselMusteriID.ToString();

                bmg.MusterileriGetirByMusteriID(cGenel.BireyselMusteriID, bm);

                txtMusteriID.Text = bm.MusteriID.ToString();
                txtMusteriAd.Text = bm.MusteriAd;
                txtSoyad.Text = bm.MusteriSoyad;
                txtTCNo.Text = bm.KimlikNo;
                txtTelefon.Text = bm.Telefon;
                
                
            }
            else if (cbMusteriTipi.Text == "Kurumsal Müşteri")
            {
                cGenel.MusteriTipi = "Kurumsal Müşteri";
                frm.ShowDialog();

                cKurumsalMusteri kr = new cKurumsalMusteri();
                cKurumsalMusteri krm = new cKurumsalMusteri();

                txtMusteriID.Text = cGenel.KurumsalMusteriID.ToString();

                krm.MusterileriGetirByFirmaID(cGenel.KurumsalMusteriID, kr);

                txtMusteriAd.Text = kr.Unvan;
                txtSoyad.Text = kr.Yetkili;
                txtTCNo.Text = kr.Telefon;
                
            }

            
        }

        private void dtpGidis_ValueChanged(object sender, EventArgs e)
        {
            txtGidis.Text = dtpGidis.Value.ToShortDateString();
        }

        private void dtpDonus_ValueChanged(object sender, EventArgs e)
        {
            txtDonus.Text = dtpDonus.Value.ToShortDateString();
        }

        private void Temizle()
        {
            txtMusteriAd.Clear();
            txtSoyad.Clear();
            txtTCNo.Clear();
            txtTelefon.Clear();
            txtDonus.Clear();
        }

        private void btnAracGetir_Click(object sender, EventArgs e)
        {
            frmAracSorgulama frm = new frmAracSorgulama();
            frm.ShowDialog();

            cArac arc = new cArac();
            cArac a = new cArac();

            txtAracID.Text = cGenel.AracID.ToString();

            arc.AraclariGetirByAracID(cGenel.AracID, a);

            txtMarka.Text = a.Marka;
            txtModel.Text = a.Model;
            txtGunlukUcret.Text = a.GunlukUcret.ToString();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            cKira k = new cKira();

            k.MusteriNo = Convert.ToInt32(txtMusteriID.Text);
            k.AracNo = Convert.ToInt32(txtAracID.Text);
            k.KirayaGidisTarihi =Convert.ToDateTime(txtGidis.Text);
            k.KiradanDonusTarihi = Convert.ToDateTime(txtDonus.Text);
            k.Tutar = Convert.ToInt32(txtTutar.Text);

            k.BireyselKirala(k);
            dgvKiralama.DataSource = k.KiralananGetir();
            dgvKiralama.Columns["FirmaNo"].Width = 0;
            
        }
    }
}
