using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_LinqToObject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<cOgrenci> liste = new List<cOgrenci>();
            cOgrenci ogr;

            ogr = new cOgrenci(); //referans tip olduğu için her defasında yeni nesne oluşturulur ve içine bilgiler atılır.(heap hafıza)
            ogr.ID = 1;
            ogr.Ad = "Ali";
            ogr.Soyad = "Uçar";
            ogr.Adres = "İnönü Mah. Sefaköy";
            ogr.Sehir = "İstanbul";
            ogr.Yas = 28;
            liste.Add(ogr);

            ogr = new cOgrenci();
            ogr.ID = 2;
            ogr.Ad = "Hakan";
            ogr.Soyad = "Coşar";
            ogr.Adres = "Altıyol Kadıköy";
            ogr.Sehir = "İstanbul";
            ogr.Yas = 24;
            liste.Add(ogr);

            ogr = new cOgrenci();
            ogr.ID = 3;
            ogr.Ad = "Zeynep";
            ogr.Soyad = "Sever";
            ogr.Adres = "Rıhtım Cad. Karşıyaka";
            ogr.Sehir = "İzmir";
            ogr.Yas = 18;
            liste.Add(ogr);

            ogr = new cOgrenci();
            ogr.ID = 4;
            ogr.Ad = "Ayşe";
            ogr.Soyad = "Koşar";
            ogr.Adres = "1. Kordon Konak";
            ogr.Sehir = "İzmir";
            ogr.Yas = 32;
            liste.Add(ogr);

            ogr = new cOgrenci();
            ogr.ID = 5;
            ogr.Ad = "Oya";
            ogr.Soyad = "Kayalı";
            ogr.Adres = "Bakanlıklar Cad. Bahçelievler";
            ogr.Sehir = "Ankara";
            ogr.Yas = 22;
            liste.Add(ogr);

            foreach (cOgrenci o in liste)
            {
                lbOgrenciler.Items.Add(o.Ad + " "+o.Soyad);
                lbOgrenciler.Items.Add(o.Adres + "-" + o.Sehir);
                lbOgrenciler.Items.Add("Yaş = " + o.Yas);
            }

            //var Students = from ogrenci in liste where ogrenci.Sehir == "İzmir" select ogrenci; //İzmir'de oturan öğrenciler

            //foreach (cOgrenci o in Students)
            //{
            //    lbStudents.Items.Add(o.Ad + " " + o.Soyad);
            //    lbStudents.Items.Add(o.Adres + "-" + o.Sehir);
            //    lbStudents.Items.Add("Yaş = " + o.Yas);
            //}

            //var Students = from ogrenci in liste where ogrenci.Sehir == "İzmir" || ogrenci.Sehir == "Ankara" select ogrenci; //İzmir yada Ankara'da oturanlar

            //foreach (cOgrenci o in Students)
            //{
            //    lbStudents.Items.Add(o.Ad + " " + o.Soyad);
            //    lbStudents.Items.Add(o.Adres + "-" + o.Sehir);
            //    lbStudents.Items.Add("Yaş = " + o.Yas);
            //}

            //var Students = from ogrenci in liste where ogrenci.Sehir == "İzmir" || ogrenci.Sehir == "Ankara" select ogrenci.Ad;

            //foreach (var isim in Students)
            //{
            //    lbStudents.Items.Add(isim);
            //}

            //var Students = from ogrenci in liste where ogrenci.Ad.StartsWith("A") select ogrenci; //İsmi A ile başlayan öğrenciler

            //foreach (cOgrenci o in Students)
            //{
            //    lbStudents.Items.Add(o.Ad + " " + o.Soyad);
            //    lbStudents.Items.Add(o.Adres + "-" + o.Sehir);
            //    lbStudents.Items.Add("Yaş = " + o.Yas);
            //}

            //var Students = from ogrenci in liste where ogrenci.Ad.ToLower().Contains("a") select ogrenci; //İsmin içinde a harfi geçen öğrenciler

            //foreach (cOgrenci o in Students)
            //{
            //    lbStudents.Items.Add(o.Ad + " " + o.Soyad);
            //    lbStudents.Items.Add(o.Adres + "-" + o.Sehir);
            //    lbStudents.Items.Add("Yaş = " + o.Yas);
            //}

            //var Students = from ogrenci in liste where ogrenci.Yas > 20 select new { ogrenci.Ad, ogrenci.Soyad, ogrenci.Yas }; //Yaşı 20'den büyük öğrencilerin adı,soyadı, yaşı //burası cOgrenci türünden bir nesne olmaz, yüzden select new ile ismi bilinmeyen yeni bir class oluşturulur ve bunun elemanları da  {} içinde verilir.

            //foreach (var o in Students)
            //{
            //    lbStudents.Items.Add(o.Ad + " " + o.Soyad);
            //    lbStudents.Items.Add("Yaş = " + o.Yas);
            //}

            //var Students = from ogrenci in liste where ogrenci.Yas > 20 select new cYeni { isim = ogrenci.Ad, soyisim = ogrenci.Soyad, yasi = ogrenci.Yas }; //yukarıdaki durum gibi bir durumda oluşan yeni class a isim vermek istiyorsak(bu class ı başka yerde kullanma gereksinimi varsa, formda yeni bir class oluşturulup properties tanımlanır.

            //foreach (cYeni o in Students)
            //{
            //    lbStudents.Items.Add(o.isim + " " + o.soyisim);
            //    lbStudents.Items.Add("Yaş = " + o.yasi);
            //}

            //int sayisi = (from ogrenci in liste where ogrenci.Yas<30 && ogrenci.Yas>20 select ogrenci).Count(); //yaşı 20 ile 30 arasında olan öğrencilerin sayısı

            //MessageBox.Show(sayisi.ToString());

            //int sayisi = (from ogrenci in liste select ogrenci).Count(); //toplam öğrenci sayısı

            //MessageBox.Show(sayisi.ToString());

            //int sayisi = (from ogrenci in liste select ogrenci.Sehir).Count(); //kolonlardan bir tanesini saydırma

            //MessageBox.Show(sayisi.ToString());

            int sayisi = (from ogrenci in liste select ogrenci.Sehir).Distinct().Count(); //öğrenciler kaç farklı şehirden geliyor

            MessageBox.Show(sayisi.ToString());

        }
    }
    class cYeni
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int yasi { get; set; }
    }
}
