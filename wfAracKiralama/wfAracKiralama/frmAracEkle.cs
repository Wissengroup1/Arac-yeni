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
    public partial class frmAracEkle : Form
    {
        public frmAracEkle()
        {
            InitializeComponent();
        }

        private void frmAracEkle_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            btnKaydet.Visible = false;
            btnSil.Visible = false;
            btnDegistir.Visible = false;
            rbKayitEkle.Checked = true;
            btnAracGetir.Visible = false;
          
        }

        private void rbKayitEkle_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
            if (rbKayitEkle.Checked == true)
            {
                btnKaydet.Visible = true;
                btnSil.Visible = false;
                btnDegistir.Visible = false;
                btnAracGetir.Visible = false;
                ReadOnlyFalse();
            }
            else if (rbKayitSil.Checked == true)
            {
                btnSil.Visible = true;
                btnKaydet.Visible = false;
                btnDegistir.Visible = false;
                btnAracGetir.Visible = true;
                ReadOnlyTrue();

            }

            else
            {
                btnDegistir.Visible = true;
                btnKaydet.Visible = false;
                btnSil.Visible = false;
                btnAracGetir.Visible = true;
                ReadOnlyFalse();
            }
        }
        private void rbKayitDegistirme_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
            if (rbKayitEkle.Checked == true)
            {
                btnKaydet.Visible = true;
                btnSil.Visible = false;
                btnDegistir.Visible = false;
                btnAracGetir.Visible = false;
                ReadOnlyFalse();
            }
            else if (rbKayitSil.Checked == true)
            {
                btnSil.Visible = true;
                btnKaydet.Visible = false;
                btnDegistir.Visible = false;
                btnAracGetir.Visible = true;
                ReadOnlyTrue();
            }

            else
            {
                btnDegistir.Visible = true;
                btnKaydet.Visible = false;
                btnSil.Visible = false;
                btnAracGetir.Visible = true;
                ReadOnlyFalse();
            }
        }
        private void rbKayitSil_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
            if (rbKayitEkle.Checked == true)
            {
                btnKaydet.Visible = true;
                btnSil.Visible = false;
                btnDegistir.Visible = false;
                btnAracGetir.Visible = false;
                ReadOnlyFalse();
            }
            else if (rbKayitSil.Checked == true)
            {
                btnSil.Visible = true;
                btnKaydet.Visible = false;
                btnDegistir.Visible = false;
                btnAracGetir.Visible = true;
                ReadOnlyTrue();

            }

            else
            {
                btnDegistir.Visible = true;
                btnKaydet.Visible = false;
                btnSil.Visible = false;
                btnAracGetir.Visible = true;
                ReadOnlyFalse();
            }
        }

        private void Temizle()
        {
            txtID.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtPlaka.Clear();
            txtYil.Clear();
            txtLokasyon.Clear();
            txtKm.Clear();
            txtKasaTipi.Clear();
            txtRenk.Clear();
            txtKoltukSayisi.Clear();
            txtYakitCinsi.Clear();
            txtSHacmi.Clear();
            txtCekis.Clear();
            txtSasiNo.Clear();
            txtSanzimanTuru.Clear();
            txtGunlukUcret.Clear();
            cbSanzimanTuru.SelectedIndex = -1;
            cbYakitCinsi.SelectedIndex = -1;
        }
        private void ReadOnlyTrue()
        {
            txtMarka.ReadOnly = true;
            txtModel.ReadOnly = true;
            txtYil.ReadOnly = true;
            txtPlaka.ReadOnly = true;
            txtLokasyon.ReadOnly = true;
            txtKm.ReadOnly = true;
            txtKasaTipi.ReadOnly = true;
            txtRenk.ReadOnly = true;
            txtKoltukSayisi.ReadOnly = true;
            txtSHacmi.ReadOnly = true;
            txtCekis.ReadOnly = true;
            txtSasiNo.ReadOnly = true;
            txtGunlukUcret.ReadOnly = true;

        }
        private void ReadOnlyFalse()
        {
            txtMarka.ReadOnly = false;
            txtModel.ReadOnly = false;
            txtYil.ReadOnly = false;
            txtPlaka.ReadOnly = false;
            txtLokasyon.ReadOnly = false;
            txtKm.ReadOnly = false;
            txtKasaTipi.ReadOnly = false;
            txtRenk.ReadOnly = false;
            txtKoltukSayisi.ReadOnly = false;
            txtSHacmi.ReadOnly = false;
            txtCekis.ReadOnly = false;
            txtSasiNo.ReadOnly = false;
            txtGunlukUcret.ReadOnly = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMarka.Text.Trim() != "" && txtModel.Text.Trim() != "" && txtPlaka.Text.Trim() != ""&& txtYil.Text.Trim() != ""&& txtKm.Text.Trim() != ""&& txtKasaTipi.Text.Trim() != ""&& txtRenk.Text.Trim() != ""&& txtKoltukSayisi.Text.Trim() != ""&& txtYakitCinsi.Text.Trim() != ""&& txtSHacmi.Text.Trim() != ""&& txtCekis.Text.Trim() != ""&& txtSasiNo.Text.Trim() != ""&& txtSanzimanTuru.Text.Trim() != ""&& txtGunlukUcret.Text.Trim() != "")
            {

                cArac a = new cArac();
                if (a.AracKontrol(txtSasiNo.Text))
                {
                    MessageBox.Show("Önceden sisteme girilmiş!", "Zaten Kayıtlı Araç");
                    Temizle();
                    txtMarka.Focus();
                }
                else
                {
                    a.Marka = txtMarka.Text;
                    a.Model = txtModel.Text;
                    a.Plaka = txtPlaka.Text;
                    a.Yil = Convert.ToInt32(txtYil.Text);
                    a.Lokasyon = txtLokasyon.Text;
                    a.Km = Convert.ToInt32(txtKm.Text);
                    a.KasaTipi = txtKasaTipi.Text;
                    a.Renk = txtRenk.Text;
                    a.KoltukSayisi = txtKoltukSayisi.Text;
                    a.YakitCinsi = txtYakitCinsi.Text;
                    a.SilindirHacmi = Convert.ToInt32(txtSHacmi.Text);
                    a.Cekis = txtCekis.Text;
                    a.SasiNo = txtSasiNo.Text;
                    a.SanzimanTuru = txtSanzimanTuru.Text;
                    a.GunlukUcret = Convert.ToInt32(txtGunlukUcret.Text);


                    bool Sonuc = a.AracEkle(a);
                    if (Sonuc)
                    {
                        MessageBox.Show("Araç Bilgileri eklendi.");
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Araç eklenemedi!!");
                    }
                }
            }
            else { MessageBox.Show("Gerekli alanları doldurmadınız!!"); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" || txtID.Text == "0")
            {
                if (MessageBox.Show("Silmek İstiyor musunuz?", "Eminmisiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    cArac a = new cArac();
                    if (a.AracSil(txtID.Text))
                    {
                        MessageBox.Show("Araç Silindi.");
                        Temizle();
                        ReadOnlyFalse();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bir Araç Seçmelisiniz!");
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtMarka.Text != "" && txtModel.Text != "" && txtPlaka.Text != "" && txtYil.Text != "" && txtKm.Text != "" && txtKasaTipi.Text != "" && txtRenk.Text != "" && txtKoltukSayisi.Text != "" && txtKoltukSayisi.Text != "" && txtYakitCinsi.Text != "" && txtSHacmi.Text != "" && txtCekis.Text != "" && txtSasiNo.Text != "" && txtSanzimanTuru.Text != "" && txtGunlukUcret.Text != "")
            {
                cArac a = new cArac();
                a.AracID = Convert.ToInt32(txtID.Text);
                a.Marka = txtMarka.Text;
                a.Model = txtModel.Text;
                a.Plaka = txtPlaka.Text;
                a.Lokasyon = txtLokasyon.Text;
                a.Yil = Convert.ToInt32(txtYil.Text);
                a.Km = Convert.ToInt32(txtKm.Text);
                a.KasaTipi = txtKasaTipi.Text;
                a.Renk = txtRenk.Text;
                a.KoltukSayisi = txtKoltukSayisi.Text;
                a.YakitCinsi = txtYakitCinsi.Text;
                a.SilindirHacmi = Convert.ToInt32(txtSHacmi.Text);
                a.Cekis = txtCekis.Text;
                a.SasiNo = txtSasiNo.Text;
                a.SanzimanTuru = txtSanzimanTuru.Text;
                a.GunlukUcret = Convert.ToInt32(txtGunlukUcret.Text);
                if (a.AracGuncelle(a))
                {
                    MessageBox.Show("Değişiklikler Yapıldı.");
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Eksik Bilgiler Bulunmaktadır!");
            }
        }   

        private void cbYakitCinsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtYakitCinsi.Text = cbYakitCinsi.Text;
        }

        private void cbSanzimanTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSanzimanTuru.Text = cbSanzimanTuru.Text;
        }

        private void btnAracGetir_Click(object sender, EventArgs e)
        {
            frmAracSorgulama frm = new frmAracSorgulama();
            frm.ShowDialog();

            cArac arc = new cArac();
            cArac a = new cArac();

            txtID.Text = cGenel.AracID.ToString();

            arc.AraclariGetirByAracID(cGenel.AracID, a);

            txtMarka.Text = a.Marka;
            txtModel.Text = a.Model;
            txtPlaka.Text = a.Plaka;
            txtYil.Text = a.Yil.ToString();
            txtLokasyon.Text = a.Lokasyon;
            txtKm.Text = a.Km.ToString();
            txtKasaTipi.Text = a.KasaTipi;
            txtRenk.Text = a.Renk;
            txtKoltukSayisi.Text = a.KoltukSayisi;
            txtYakitCinsi.Text = a.YakitCinsi;
            txtSHacmi.Text = a.SilindirHacmi.ToString();
            txtCekis.Text = a.Cekis;
            txtSasiNo.Text = a.SasiNo;
            txtSanzimanTuru.Text = a.SanzimanTuru;
            txtGunlukUcret.Text = a.GunlukUcret.ToString();
            
        }
    }
}
