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

        cKira k = new cKira();
        private void frmAracKiralama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            cbMusteriTipi.SelectedIndex = 0;
            btnKirala.Enabled = false;
            txtGidis.Text = DateTime.Now.ToShortDateString();
            btnAracEkle.Enabled = false;
            btnSil.Enabled = false;
            btnYazdir.Enabled = false;
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cbMusteriTipi.SelectedIndex == 0)
            {
                btnKirala.Enabled = true;

                double tutar = 0;
                TimeSpan t = dtpDonus.Value - dtpGidis.Value;
                double a = Convert.ToDouble((t.TotalHours / 24));
                int b = (int)a;
                int kiragun = 0;
                if (b + 1 > 0 && b + 1 < 7)
                {
                    kiragun = b + 1;
                    tutar = (kiragun * Convert.ToInt32(txtGunlukUcret.Text));
                    txtTutar.Text = Convert.ToString(tutar);

                }
                else if (b + 1 > 6 && b + 1 < 14)
                {
                    kiragun = b + 1;
                    tutar = (kiragun * Convert.ToInt32(txtGunlukUcret.Text));
                    tutar = tutar * 90 / 100;
                    txtTutar.Text = Convert.ToString(tutar);
                }
                else if (b + 1 > 14 && b < 30)
                {
                    kiragun = b + 1;
                    tutar = (kiragun * Convert.ToInt32(txtGunlukUcret.Text));
                    tutar = tutar * 80 / 100;
                    txtTutar.Text = Convert.ToString(tutar);
                }

                else if (b + 1 > 29)
                {
                    kiragun = b + 1;
                    tutar = (kiragun * Convert.ToInt32(txtGunlukUcret.Text));
                    tutar = tutar * 65 / 100;
                    txtTutar.Text = Convert.ToString(tutar);
                    MessageBox.Show("Bence bi araba almayı düşünsün kendine");
                }
                else
                {
                    MessageBox.Show("Dönüş Tarihi, Gidiş Tarihinden geç olmalıdır.");
                }
                // Buralarda bi sıkıntı var 
            }
            if (cbMusteriTipi.SelectedIndex == 1)
            {
                btnAracEkle.Enabled = true;
                btnKirala.Enabled = false;

                double tutarf = 0;
                TimeSpan tf = dtpDonus.Value - dtpGidis.Value;
                double c = Convert.ToDouble((tf.TotalHours / 24));
                int d = (int)c;
                int kiragunf = 0;
                if (d + 1 > 0 && d + 1 < 7 && chOzelIndirim.Checked == false)
                {
                    kiragunf = d + 1;
                    tutarf = (kiragunf * Convert.ToInt32(txtGunlukUcret.Text));
                    txtTutar.Text = Convert.ToString(tutarf);

                }
                else if ((d + 1 > 6 && d + 1 < 14) || cbOzelIndirim.SelectedIndex == 1)
                {
                    kiragunf = d + 1;
                    tutarf = (kiragunf * Convert.ToInt32(txtGunlukUcret.Text));
                    tutarf = tutarf * 90 / 100;
                    txtTutar.Text = Convert.ToString(tutarf);
                }
                else if (d + 1 > 14 && d < 30)
                {
                    kiragunf = d + 1;
                    tutarf = (kiragunf * Convert.ToInt32(txtGunlukUcret.Text));
                    tutarf = tutarf * 80 / 100;
                    txtTutar.Text = Convert.ToString(tutarf);
                }

                else if (d + 1 > 29)
                {
                    kiragunf = d + 1;
                    tutarf = (kiragunf * Convert.ToInt32(txtGunlukUcret.Text));
                    tutarf = tutarf * 65 / 100;
                    txtTutar.Text = Convert.ToString(tutarf);

                }
                else
                {
                    MessageBox.Show("Dönüş Tarihi, Gidiş Tarihinden geç olmalıdır.");
                }
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
            txtMusteriID.Clear();
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

            if (cGenel.AracID > 0)
            {
                txtAracID.Text = cGenel.AracID.ToString();

                arc.AraclariGetirByAracID(cGenel.AracID, a);

                txtMarka.Text = a.Marka;
                txtModel.Text = a.Model;
                txtGunlukUcret.Text = a.GunlukUcret.ToString();
                cGenel.AracID = 0;
            }
        }

        int i = 0;      
        private void btnAracEkle_Click(object sender, EventArgs e)
        {
                 
            btnKirala.Enabled = true;
            cArac a = new cArac();
            List<cArac> list = new List<cArac>();

            list = a.AraclariGetirByAracID(Convert.ToInt32(txtAracID.Text),a);

            foreach (var item in list)
            {
                lvAraclar.Items.Add(txtAracID.Text);
                lvAraclar.Items[i].SubItems.Add(a.Marka);
                lvAraclar.Items[i].SubItems.Add(a.Model);
                lvAraclar.Items[i].SubItems.Add(a.Yil.ToString());
                lvAraclar.Items[i].SubItems.Add(a.GunlukUcret.ToString());
                lvAraclar.Items[i].SubItems.Add(a.Km.ToString());
                lvAraclar.Items[i].SubItems.Add(txtGidis.Text);
                lvAraclar.Items[i].SubItems.Add(txtDonus.Text);
                lvAraclar.Items[i].SubItems.Add(txtTutar.Text);
                cGenel.aracid[i] = Convert.ToInt32(txtAracID.Text);
                i++;
            }
            btnAracEkle.Enabled = false;
            txtAracID.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtGunlukUcret.Clear();
            txtTutar.Clear();
            btnYazdir.Enabled = true;
            cGenel.AracEkle = i;
        }
        
        private void btnKirala_Click(object sender, EventArgs e)
        {
            cArac a = new cArac();
            if (cbMusteriTipi.SelectedIndex == 0)
            {
                cKira k = new cKira();
                try
                {
                    k.MusteriNo = Convert.ToInt32(txtMusteriID.Text);
                    k.AracNo = Convert.ToInt32(txtAracID.Text);
                    k.KirayaGidisTarihi = Convert.ToDateTime(txtGidis.Text);
                    k.KiradanDonusTarihi = Convert.ToDateTime(txtDonus.Text);
                    k.KiraDetayID = cGenel.KiraDetayKurumsal - 1;
                    k.Tutar = Convert.ToInt32(txtTutar.Text);

                    k.BireyselKirala(k);
                    a.AracGuncelleKiralanamaz(k.AracNo);
                    dgvKiralama.DataSource = k.KiralananGetirBireysel();
                    dgvKiralama.Columns["FirmaNo"].Visible = false;
                }
                catch (Exception)
                {

                    frmAracKiralama.ActiveForm.Activate();
                    MessageBox.Show("Eksik Bilgi Var, Tekrar Kontrol Edin ");
                }

            }
            else if (cbMusteriTipi.SelectedIndex == 1)
            {
                cGenel.KiraDetayKurumsal = k.KiraDetayIDGetir();
                for (int i = 0; i < lvAraclar.Items.Count; i++)
                {
                    k.FirmaNo = Convert.ToInt32(txtMusteriID.Text);
                    k.AracNo = Convert.ToInt32(lvAraclar.Items[i].Text);
                    k.KirayaGidisTarihi = Convert.ToDateTime(lvAraclar.Items[i].SubItems[6].Text);
                    k.KiradanDonusTarihi = Convert.ToDateTime(lvAraclar.Items[i].SubItems[7].Text);
                    k.Tutar = Convert.ToInt32(lvAraclar.Items[i].SubItems[8].Text);
                    k.KiraDetayID = cGenel.KiraDetayKurumsal;
                    k.KurumsalKirala(k);
                    a.AracGuncelleKiralanamaz(k.AracNo);
                }


                dgvKiralama.DataSource = k.KiralananGetirKurumsal();
                dgvKiralama.Columns["MusteriNo"].Visible = false;
            }
            btnYazdir.Enabled = true;
            
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            y = 0;
            ppdFatura.ShowDialog();

            btnYazdir.Enabled = false;
            btnKirala.Enabled = false;
            lvAraclar.Items.Clear();
            Temizle();
        }

        private void lvAraclar_Click(object sender, EventArgs e)
        {
            btnSil.Enabled = true;
            
        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {           
            if (lvAraclar.Items.Count > 0)
            {
                //cGenel.aracid[lvAraclar.SelectedItems[0].Index] = 0;
                lvAraclar.SelectedItems[0].Remove();
                //i--;
                int j =0;
                foreach (var item in lvAraclar.Items)
                {
                    cGenel.aracid[j] = Convert.ToInt32(lvAraclar.Items[0].Text);
                    j++;
                }

                txtAracID.Clear();
                txtGunlukUcret.Clear();
                txtMarka.Clear();
                txtModel.Clear();

            }
            else
            {
                lvAraclar.SelectedItems[0].Remove();
                cGenel.aracid[0] = 0;
                i = 0;
                txtAracID.Clear();
                txtGunlukUcret.Clear();
                txtMarka.Clear();
                txtModel.Clear();
            }
        }

        Font fntBuyukBaslik = new Font("Arial", 30, FontStyle.Bold);
        Font fntBaslik = new Font("Arial", 16, FontStyle.Bold);
        Font fntIcerik = new Font("Arial", 12, FontStyle.Regular);
        SolidBrush sb = new SolidBrush(Color.Black);
        int y = 0;

        private void pdocFatura_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("NFC RENT A CAR", fntBuyukBaslik, sb, 150, 120, fmt);
            //e.Graphics.DrawString("Hesap No : " + txtHesapNo.Text, fntBaslik, sb, 150, 150, fmt);
            e.Graphics.DrawString("Tarih : " + DateTime.Now.ToShortDateString(), fntBaslik, sb, 580, 150, fmt);
            //e.Graphics.DrawString("Hesap Dökümü", fntBaslik, sb, 300, 200, fmt);
            if(cbMusteriTipi.SelectedIndex==1)
            {
            e.Graphics.DrawString("Firma Ünvanı     Araç Marka-Model    Kiraya Gidiş T.  Dönüş T.    Tutar", fntBaslik, sb, 40, 250, fmt);
            e.Graphics.DrawString("______________________________________________________________", fntBaslik, sb, 40, 270, fmt);
            int k = 0;
            for (int i = y; i < lvAraclar.Items.Count; i++)
            {
                e.Graphics.DrawString(txtMusteriAd.Text, fntIcerik, sb, 50, 320 + k * 30, fmt);
                e.Graphics.DrawString(lvAraclar.Items[i].SubItems[1].Text, fntIcerik, sb, 220, 320 + k * 30, fmt);
                e.Graphics.DrawString(lvAraclar.Items[i].SubItems[2].Text, fntIcerik, sb, 290, 320 + k * 30, fmt);
                e.Graphics.DrawString(lvAraclar.Items[i].SubItems[6].Text, fntIcerik, sb, 450, 320 + k * 30, fmt);
                e.Graphics.DrawString(lvAraclar.Items[i].SubItems[7].Text, fntIcerik, sb, 600, 320 + k * 30, fmt);
                e.Graphics.DrawString(lvAraclar.Items[i].SubItems[8].Text + "TL", fntIcerik, sb, 720, 320 + k * 30, fmt);
                k++;
                y++;
                if (i % 20 == 0 && i > 0)
                {
                    e.HasMorePages = true; //Yazdırma işlemi yeni sayfadan devam eder.
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }

            }
                
            }
            else
            {
                e.Graphics.DrawString("Firma Ünvanı     Araç Marka-Model    Kiraya Gidiş T.  Dönüş T.    Tutar", fntBaslik, sb, 40, 250, fmt);
            e.Graphics.DrawString("______________________________________________________________", fntBaslik, sb, 40, 270, fmt);
            int l = 0;
            for (int j = y; j < lvAraclar.Items.Count; j++)
            {
                e.Graphics.DrawString(txtMusteriAd.Text, fntIcerik, sb, 50, 320 + l * 30, fmt);
                e.Graphics.DrawString(txtSoyad.Text, fntIcerik, sb, 100, 320 + l * 30, fmt);
                e.Graphics.DrawString(lvAraclar.Items[j].SubItems[1].Text, fntIcerik, sb, 220, 320 + l * 30, fmt);
                e.Graphics.DrawString(lvAraclar.Items[j].SubItems[2].Text, fntIcerik, sb, 290, 320 + l * 30, fmt);
                e.Graphics.DrawString(lvAraclar.Items[j].SubItems[6].Text, fntIcerik, sb, 450, 320 + l * 30, fmt);
                e.Graphics.DrawString(lvAraclar.Items[j].SubItems[7].Text, fntIcerik, sb, 600, 320 + l * 30, fmt);
                e.Graphics.DrawString(lvAraclar.Items[j].SubItems[8].Text + "TL", fntIcerik, sb, 720, 320 + l * 30, fmt);
                l++;
                y++;
                if (i % 20 == 0 && i > 0)
                {                   
                    e.HasMorePages = true; //Yazdırma işlemi yeni sayfadan devam eder.
                    return;
                }
                else
                {
                    e.HasMorePages = false;          
                }
            }
            
        }
            int ToplamTutar = 0;
            for (int m = 0; m < lvAraclar.Items.Count; m++)
            {
                ToplamTutar = ToplamTutar + Convert.ToInt32(lvAraclar.Items[m].SubItems[8].Text);
            }
            
            e.Graphics.DrawString("Toplam Tutar " + ToplamTutar.ToString() + "TL", fntIcerik, sb, 450, 700, fmt);
        }

        private void chOzelIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chOzelIndirim.Checked == true)
            {
                cbOzelIndirim.Visible = true;
            }
            else cbOzelIndirim.Visible = false;
        }


    }
}
