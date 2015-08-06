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
        private int _gunlukUcret;
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


        public int GunlukUcret
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
            SqlCommand comm = new SqlCommand("Select * from Arac where Silindi=0 and Kiralanabilir=1", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cArac a = new cArac();
                    if (Convert.ToInt32(dr["AracID"]) != cGenel.aracid[0] && Convert.ToInt32(dr["AracID"]) != cGenel.aracid[1] && Convert.ToInt32(dr["AracID"]) != cGenel.aracid[2] && Convert.ToInt32(dr["AracID"]) != cGenel.aracid[3] && Convert.ToInt32(dr["AracID"]) != cGenel.aracid[4] && Convert.ToInt32(dr["AracID"]) != cGenel.aracid[5] && Convert.ToInt32(dr["AracID"]) != cGenel.aracid[6])
                    {
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
                        a._gunlukUcret = Convert.ToInt32(dr["GunlukUcret"]);
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
                        a._gunlukUcret = Convert.ToInt32(dr["GunlukUcret"]);
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

        public bool AracEkle(cArac a)
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Insert into Arac (Marka,Model, Plaka, Lokasyon, Yil,Km,KasaTipi,Renk,KoltukSayisi,YakitCinsi,SilindirHacmi,Cekis,SasiNo,SanzimanTuru,GunlukUcret) values(@Marka,@Model, @Plaka, @Lokasyon, @Yil,@Km,@KasaTipi,@Renk,@KoltukSayisi,@YakitCinsi,@SilindirHacmi,@Cekis,@SasiNo,@SanzimanTuru,@GunlukUcret)", conn);
            comm.Parameters.Add("@Marka", SqlDbType.VarChar).Value = a._marka;
            comm.Parameters.Add("@Model", SqlDbType.VarChar).Value = a._model;
            comm.Parameters.Add("@Plaka", SqlDbType.VarChar).Value = a._plaka;
            comm.Parameters.Add("@Lokasyon", SqlDbType.VarChar).Value = a._lokasyon;
            comm.Parameters.Add("@Yil", SqlDbType.Int).Value = a._yil;
            comm.Parameters.Add("@Km", SqlDbType.Int).Value = a._km;
            comm.Parameters.Add("@KasaTipi", SqlDbType.VarChar).Value = a._kasaTipi;
            comm.Parameters.Add("@Renk", SqlDbType.VarChar).Value = a._renk;
            comm.Parameters.Add("@KoltukSayisi", SqlDbType.VarChar).Value = a._koltukSayisi;
            comm.Parameters.Add("@YakitCinsi", SqlDbType.VarChar).Value = a._yakitCinsi;
            comm.Parameters.Add("@SilindirHacmi", SqlDbType.Int).Value = a._silindirHacmi;
            comm.Parameters.Add("@Cekis", SqlDbType.VarChar).Value = a._cekis;
            comm.Parameters.Add("@SasiNo", SqlDbType.VarChar).Value = a._sasiNo;
            comm.Parameters.Add("@SanzimanTuru", SqlDbType.VarChar).Value = a._sanzimanTuru;
            comm.Parameters.Add("@GunlukUcret", SqlDbType.Money).Value = a._gunlukUcret;

            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }

        public bool AracGuncelle(cArac a)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Update Arac Set Marka=@Marka,Model=@Model, Plaka=@Plaka, Lokasyon=@Lokasyon, Yil=@Yil,Km=@Km,KasaTipi=@KasaTipi,Renk=@Renk,KoltukSayisi=@KoltukSayisi,YakitCinsi=@YakitCinsi,SilindirHacmi=@SilindirHacmi,Cekis=@Cekis,SasiNo=@SasiNo,SanzimanTuru=@SanzimanTuru,GunlukUcret=@GunlukUcret where AracID=@AracID", conn);

            comm.Parameters.Add("@AracID", SqlDbType.Int).Value = a._aracID;
            comm.Parameters.Add("@Marka", SqlDbType.VarChar).Value = a._marka;
            comm.Parameters.Add("@Model", SqlDbType.VarChar).Value = a._model;
            comm.Parameters.Add("@Plaka", SqlDbType.VarChar).Value = a._plaka;
            comm.Parameters.Add("@Lokasyon", SqlDbType.VarChar).Value = a._lokasyon;
            comm.Parameters.Add("@Yil", SqlDbType.Int).Value = a._yil;
            comm.Parameters.Add("@Km", SqlDbType.Int).Value = a._km;
            comm.Parameters.Add("@KasaTipi", SqlDbType.VarChar).Value = a._kasaTipi;
            comm.Parameters.Add("@Renk", SqlDbType.VarChar).Value = a._renk;
            comm.Parameters.Add("@KoltukSayisi", SqlDbType.VarChar).Value = a._koltukSayisi;
            comm.Parameters.Add("@YakitCinsi", SqlDbType.VarChar).Value = a._yakitCinsi;
            comm.Parameters.Add("@SilindirHacmi", SqlDbType.Int).Value = a._silindirHacmi;
            comm.Parameters.Add("@Cekis", SqlDbType.VarChar).Value = a._cekis;
            comm.Parameters.Add("@SasiNo", SqlDbType.VarChar).Value = a._sasiNo;
            comm.Parameters.Add("@SanzimanTuru", SqlDbType.VarChar).Value = a._sanzimanTuru;
            comm.Parameters.Add("@GunlukUcret", SqlDbType.Money).Value = a._gunlukUcret;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public bool AracKontrol(string SasiNo)
        {
            bool Varmi = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from Arac where SasiNo=@SasiNo and Silindi=0", conn);
            comm.Parameters.Add("@SasiNo", SqlDbType.VarChar).Value = SasiNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                Varmi = true;
            }
            dr.Close();
            conn.Close();
            return Varmi;
        }

        public void AracGetir(DataGridView dgv, cArac a)
        {
            a._aracID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);

        }

        public List<cArac> AraclariGetirByAracID(int ID, cArac a)
        {
            List<cArac> list = new List<cArac>();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from Arac where Silindi=0 and AracID=@AracID", conn);
            comm.Parameters.Add("@AracID", SqlDbType.Int).Value = ID;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    a.AracID = Convert.ToInt32(dr[0]);
                    a.Marka = dr[1].ToString();
                    a.Model = dr[2].ToString();
                    a.Plaka = dr[3].ToString();
                    a.Yil = Convert.ToInt32(dr[4]);
                    a.Lokasyon = dr[5].ToString();
                    a.Km = Convert.ToInt32(dr[6]);
                    a.KasaTipi = dr[7].ToString();
                    a.Renk = dr[8].ToString();
                    a.KoltukSayisi = dr[9].ToString();
                    a.YakitCinsi = dr[10].ToString();
                    a.SilindirHacmi = Convert.ToInt32(dr[11]);
                    a.Cekis = dr[12].ToString();
                    a.SasiNo = dr[13].ToString();
                    a.SanzimanTuru = dr[14].ToString();
                    a.GunlukUcret = Convert.ToInt32(dr[15]);
                    list.Add(a);
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return list;
        }
        public bool AracSil(string AracID)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Update Arac set Silindi=1,Kiralanabilir=0 where AracID=@AracID", conn);//kiralanabilir column u da 1 yapılacak.
            comm.Parameters.Add("@AracID", SqlDbType.VarChar).Value = AracID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show(hata);
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public void AracGuncelleKiralanamaz(int AracID)
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Update Arac Set Kiralanabilir=@Kiralanabilir where AracID=@AracID", conn);

            comm.Parameters.Add("@Kiralanabilir", SqlDbType.Bit).Value = false;
            comm.Parameters.Add("@AracID", SqlDbType.Int).Value = AracID;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public void AracGuncelleKiralanabilir(int AracID)
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Update Arac Set Kiralanabilir=@Kiralanabilir where AracID=@AracID", conn);

            comm.Parameters.Add("@Kiralanabilir", SqlDbType.Bit).Value = true;
            comm.Parameters.Add("@AracID", SqlDbType.Int).Value = AracID;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }
       
    }
}
 
