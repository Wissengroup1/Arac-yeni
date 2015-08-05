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
    public partial class frmKurumsalMusteriEkle : Form
    {
        public frmKurumsalMusteriEkle()
        {
            InitializeComponent();
        }

        private void frmKurumsalMusteriEkle_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            btnKaydet.Visible = false;
            btnDegistir.Visible = false;
            rbKayitEkle.Checked = true;
            btnMusteriGetir.Visible = false;
        }

        private void Temizle()
        {
            txtUnvan.Clear();
            txtYetkili.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();
            txtVergiNo.Clear();
            txtVergiDairesi.Clear();

        }

        private void rbKayitDegistirme_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
            if (rbKayitEkle.Checked == true)
            {
                btnKaydet.Visible = true;
                btnDegistir.Visible = false;
                btnMusteriGetir.Visible = false;
            }

            else
            {
                btnDegistir.Visible = true;
                btnKaydet.Visible = false;
                btnMusteriGetir.Visible = true;
            }
        }

        private void rbKayitEkle_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
            if (rbKayitEkle.Checked == true)
            {
                btnKaydet.Visible = true;
                btnDegistir.Visible = false;
                btnMusteriGetir.Visible = false;
            }

            else
            {
                btnDegistir.Visible = true;
                btnKaydet.Visible = false;
                btnMusteriGetir.Visible = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUnvan.Text.Trim() != "" && txtYetkili.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtTelefon.Text.Trim() != "" && txtVergiNo.Text.Trim() != "" && txtVergiDairesi.Text.Trim() != "")
            {

                cKurumsalMusteri kr = new cKurumsalMusteri();
                if (kr.KurumsalMusteriKontrol(txtVergiNo.Text))
                {
                    MessageBox.Show("Önceden sisteme girilmiş!", "Zaten Kayıtlı Müşteri");
                    Temizle();
                    txtUnvan.Focus();
                }
                else
                {
                    kr.Unvan = txtUnvan.Text;
                    kr.Yetkili = txtYetkili.Text;
                    kr.Adres = txtAdres.Text;
                    kr.Telefon = txtTelefon.Text;
                    kr.VergiNo = txtVergiNo.Text;
                    kr.VergiDairesi = txtVergiDairesi.Text;


                    bool Sonuc = kr.KurumsalMusteriEkle(kr);
                    if (Sonuc)
                    {
                        MessageBox.Show("Müşteri Bilgileri eklendi.");
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri eklenemedi!!");
                    }
                }
            }
            else { MessageBox.Show("Gerekli alanları doldurmadınız!!"); }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtUnvan.Text.Trim() != "" && txtYetkili.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtTelefon.Text.Trim() != "" && txtVergiNo.Text.Trim() != "" && txtVergiDairesi.Text.Trim() != "")
            {
                cKurumsalMusteri kr = new cKurumsalMusteri();
                kr.FirmaID = Convert.ToInt32(txtID.Text);
                kr.Unvan = txtUnvan.Text;
                kr.Yetkili = txtYetkili.Text;
                kr.Adres = txtAdres.Text;
                kr.Telefon = txtTelefon.Text;
                kr.VergiNo = txtVergiNo.Text;
                kr.VergiDairesi = txtVergiDairesi.Text;

                if (kr.KurumsalMusteriGuncelle(kr))
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

        private void btnMusteriGetir_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            cGenel.MusteriTipi = "Kurumsal Müşteri";
            cGenel.FormMusteri = "Musteri Getir";
            frm.ShowDialog();

            cKurumsalMusteri krm = new cKurumsalMusteri();
            cKurumsalMusteri kr = new cKurumsalMusteri();

            txtID.Text = cGenel.KurumsalMusteriID.ToString();

            krm.MusterileriGetirByFirmaID(cGenel.KurumsalMusteriID, kr);

            txtUnvan.Text = kr.Unvan;
            txtYetkili.Text = kr.Yetkili;
            txtAdres.Text = kr.Adres;
            txtTelefon.Text = kr.Telefon;
            txtVergiNo.Text = kr.VergiNo;
            txtVergiDairesi.Text = kr.VergiDairesi;
        }
    }
}
