using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace wfAracKiralama
{
    class cArac
    {
        private int _aracID;
        private string _marka;
        private string _model;
        private string _plaka;
        private string _lokasyon;
        private int _yil;
        private int _km;
        private string _kasaTipi;
        private string _renk;
        private string _koltukSayisi;
        private string _yakitCinsi;
        private int _silindirHacmi;
        private string _cekis;
        private string _sasiNo;
        private string _sanzimanTuru;
        private decimal _gunlukUcret;
        private bool _kiralanabilir;

        

        #region Properties
        public int AracID
        {
            get { return _aracID; }
            set { _aracID = value; }
        }


        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }


        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }


        public string Plaka
        {
            get { return _plaka; }
            set { _plaka = value; }
        }


        public string Lokasyon
        {
            get { return _lokasyon; }
            set { _lokasyon = value; }
        }

        public int Yil
        {
            get { return _yil; }
            set { _yil = value; }
        }

        public int Km
        {
            get { return _km; }
            set { _km = value; }
        }


        public string KasaTipi
        {
            get { return _kasaTipi; }
            set { _kasaTipi = value; }
        }


        public string Renk
        {
            get { return _renk; }
            set { _renk = value; }
        }


        public string KoltukSayisi
        {
            get { return _koltukSayisi; }
            set { _koltukSayisi = value; }
        }


        public string YakitCinsi
        {
            get { return _yakitCinsi; }
            set { _yakitCinsi = value; }
        }


        public int SilindirHacmi
        {
            get { return _silindirHacmi; }
            set { _silindirHacmi = value; }
        }


        public string Cekis
        {
            get { return _cekis; }
            set { _cekis = value; }
        }


        public string SasiNo
        {
            get { return _sasiNo; }
            set { _sasiNo = value; }
        }


        public string SanzimanTuru
        {
            get { return _sanzimanTuru; }
            set { _sanzimanTuru = value; }
        }


        public decimal GunlukUcret
        {
            get { return _gunlukUcret; }
            set { _gunlukUcret = value; }
        }

        public bool Kiralanabilir
        {
            get { return _kiralanabilir; }
            set { _kiralanabilir = value; }
        }

        #endregion

        public List<cArac> AraclariGetir()
        {

            List<cArac> list = new List<cArac>();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from Arac where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cArac a = new cArac();
                    a._aracID = Convert.ToInt32(dr["AracID"]);
                    a._marka = dr["Marka"].ToString();
                    a._model = dr["Model"].ToString();
                    a._plaka = dr["Plaka"].ToString();
                    a._lokasyon = dr["Lokasyon"].ToString();
                    a._yil = Convert.ToInt32(dr["Yil"]);
                    a._km = Convert.ToInt32(dr["Km"]);
                    a._kasaTipi = dr["KasaTipi"].ToString();
                    a._renk = dr["Renk"].ToString();
                    a._koltukSayisi = dr["KoltukSayisi"].ToString();
                    a._yakitCinsi = dr["YakitCinsi"].ToString();
                    a._silindirHacmi = Convert.ToInt32(dr["SilindirHacmi"]);
                    a._cekis = dr["Cekis"].ToString();
                    a._sasiNo = dr["SasiNo"].ToString();
                    a._sanzimanTuru = dr["SanzimanTuru"].ToString();
                    a._gunlukUcret = Convert.ToDecimal(dr["GunlukUcret"]);
                    a._kiralanabilir = Convert.ToBoolean(dr["Kiralanabilir"]);
                    list.Add(a);
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return list;
        }


        public List<cArac> AraclariGetirByDetayli(string SanzimanTipi, string YakitTuru, bool KiraDurumu, string KiraDurumuHepsi, string MarkayaGore)
        {
            List<cArac> list = new List<cArac>();

            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand();
            if (MarkayaGore == null)
            {
                comm = new SqlCommand("Select * from Arac where Silindi=0", conn);
            }
            else
            {
                comm = new SqlCommand("Select * from Arac where Silindi=0 and Marka like @Marka + '%'", conn);
                comm.Parameters.Add("@Marka", SqlDbType.VarChar).Value = MarkayaGore;
            }
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {

                    if ((SanzimanTipi == "Hepsi" || dr[14].ToString() == SanzimanTipi) && (YakitTuru == "Hepsi" || dr[10].ToString() == YakitTuru ) && ((KiraDurumuHepsi == "Hepsi") || Convert.ToBoolean(dr[16]) == KiraDurumu))
                    {
                        cArac a = new cArac();
                        a._aracID = Convert.ToInt32(dr["AracID"]);
                        a._marka = dr["Marka"].ToString();
                        a._model = dr["Model"].ToString();
                        a._plaka = dr["Plaka"].ToString();
                        a._lokasyon = dr["Lokasyon"].ToString();
                        a._yil = Convert.ToInt32(dr["Yil"]);
                        a._km = Convert.ToInt32(dr["Km"]);
                        a._kasaTipi = dr["KasaTipi"].ToString();
                        a._renk = dr["Renk"].ToString();
                        a._koltukSayisi = dr["KoltukSayisi"].ToString();
                        a._yakitCinsi = dr["YakitCinsi"].ToString();
                        a._silindirHacmi = Convert.ToInt32(dr["SilindirHacmi"]);
                        a._cekis = dr["Cekis"].ToString();
                        a._sasiNo = dr["SasiNo"].ToString();
                        a._sanzimanTuru = dr["SanzimanTuru"].ToString();
                        a._gunlukUcret = Convert.ToDecimal(dr["GunlukUcret"]);
                        a._kiralanabilir = Convert.ToBoolean(dr["Kiralanabilir"]);
                        list.Add(a);

                    }
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            return list;
        }
    }
}
 
