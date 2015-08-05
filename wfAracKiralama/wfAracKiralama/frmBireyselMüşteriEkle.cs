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
    public partial class frmBireyselMüşteriEkle : Form
    {
        public frmBireyselMüşteriEkle()
        {
            InitializeComponent();
        }

        private void frmBireyselMüşteriEkle_Load(object sender, EventArgs e)
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
            txtMusteriAd.Clear();
            txtMusteriSoyad.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();
            txtKimlikNo.Clear();
            txtUyruk.Clear();
            txtDTarihi.Clear();
            txtDYeri.Clear();
            txtCinsiyet.Clear();

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
            if (txtMusteriAd.Text.Trim() != "" && txtMusteriSoyad.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtTelefon.Text.Trim() != "" && txtKimlikNo.Text.Trim() != "" && txtUyruk.Text.Trim() != "" && txtDYeri.Text.Trim() != "" && txtDTarihi.Text.Trim() != "" && txtCinsiyet.Text.Trim() != "")
            {

                cBireyselMusteri br = new cBireyselMusteri();
                if (br.BireyselMusteriKontrol(txtKimlikNo.Text))
                {
                    MessageBox.Show("Önceden sisteme girilmiş!", "Zaten Kayıtlı Müşteri");
                    Temizle();
                    txtMusteriAd.Focus();
                }
                else
                {
                    br.MusteriAd = txtMusteriAd.Text;
                    br.MusteriSoyad = txtMusteriSoyad.Text;
                    br.KimlikNo = txtKimlikNo.Text;
                    br.Uyruk = txtUyruk.Text;
                    br.DogumYeri = txtDYeri.Text;
                    br.DogumTarihi = Convert.ToDateTime(txtDTarihi.Text);
                    br.Cinsiyet = txtCinsiyet.Text;
                    br.Telefon = txtTelefon.Text;
                    br.Adres = txtAdres.Text;

                    bool Sonuc = br.BireyselMusteriEkle(br);
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
            if (txtMusteriAd.Text.Trim() != "" && txtMusteriSoyad.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtTelefon.Text.Trim() != "" && txtKimlikNo.Text.Trim() != "" && txtUyruk.Text.Trim() != "" && txtDYeri.Text.Trim() != "" && txtDTarihi.Text.Trim() != "" && txtCinsiyet.Text.Trim() != "")
            {
                cBireyselMusteri br = new cBireyselMusteri();
                br.MusteriID = Convert.ToInt32(txtID.Text);
                br.MusteriAd = txtMusteriAd.Text;
                br.MusteriSoyad = txtMusteriSoyad.Text;
                br.KimlikNo = txtKimlikNo.Text;
                br.Uyruk = txtUyruk.Text;
                br.DogumYeri = txtDYeri.Text;
                br.DogumTarihi = Convert.ToDateTime(txtDTarihi.Text);
                br.Cinsiyet = txtCinsiyet.Text;
                br.Telefon = txtTelefon.Text;
                br.Adres = txtAdres.Text;

                if (br.BireyselMusteriGuncelle(br))
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
            cGenel.MusteriTipi = "Bireysel Müşteri";
            cGenel.FormMusteri = "Musteri Getir";
            frm.ShowDialog();

            cBireyselMusteri bry = new cBireyselMusteri();
            cBireyselMusteri br = new cBireyselMusteri();

            txtID.Text = cGenel.BireyselMusteriID.ToString();

            bry.MusterileriGetirByMusteriID(cGenel.BireyselMusteriID, br);

            txtMusteriAd.Text = br.MusteriAd;
            txtMusteriSoyad.Text = br.MusteriSoyad;
            txtKimlikNo.Text = br.KimlikNo;
            txtUyruk.Text = br.Uyruk;
            txtDYeri.Text = br.DogumYeri;
            txtDTarihi.Text = br.DogumTarihi.ToShortDateString();
            txtCinsiyet.Text = br.Cinsiyet;
            txtTelefon.Text = br.Telefon;
            txtAdres.Text = br.Adres;
        }
    }
}
