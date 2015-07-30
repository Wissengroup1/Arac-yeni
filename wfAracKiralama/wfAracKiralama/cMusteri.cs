using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace wfAracKiralama
{
    class cMusteri
    {
        


        private int _musteriID;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _kimlikNo;
        private string _uyruk;
        private string _dogumYeri;
        private DateTime _dogumTarihi;
        private string _cinsiyet;
        private string _telefon;
        private string _adres;

        #region Properties
        public int MusteriID
        {
            get { return _musteriID; }
            set { _musteriID = value; }
        }


        public string MusteriAd
        {
            get { return _musteriAd; }
            set { _musteriAd = value; }
        }


        public string MusteriSoyad
        {
            get { return _musteriSoyad; }
            set { _musteriSoyad = value; }
        }


        public string KimlikNo
        {
            get { return _kimlikNo; }
            set { _kimlikNo = value; }
        }


        public string Uyruk
        {
            get { return _uyruk; }
            set { _uyruk = value; }
        }


        public string DogumYeri
        {
            get { return _dogumYeri; }
            set { _dogumYeri = value; }
        }


        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }


        public string Cinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }


        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }


        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        } 
        #endregion

        public DataTable BireyselMusterileriGetir()
        {

            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Musteri", conn);
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }

        public DataTable KurumsalMusterileriGetir()
        {

            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Firma", conn);
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }
    }
}
