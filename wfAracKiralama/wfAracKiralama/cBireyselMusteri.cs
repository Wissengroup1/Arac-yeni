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
    class cBireyselMusteri
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

        public void MusteriGetirBireysel(DataGridView dgv, cBireyselMusteri bm)
        {
            bm._musteriID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
        }

        public void MusterileriGetirByMusteriID(int ID, cBireyselMusteri bm)
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from Musteri where MusteriID=@MusteriID", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = ID;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    bm._musteriID = Convert.ToInt32(dr[0]);
                    bm._musteriAd = dr[1].ToString();
                    bm._musteriSoyad = dr[2].ToString();
                    bm._kimlikNo = dr[3].ToString();
                    bm._uyruk = dr[4].ToString();
                    bm._dogumYeri = dr[5].ToString();
                    bm._dogumTarihi = Convert.ToDateTime(dr[6]);
                    bm.Cinsiyet = dr[7].ToString();
                    bm._telefon = dr[8].ToString();
                    bm._adres = dr[9].ToString();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
        }

        public List<cBireyselMusteri> BireyselMusterileriGetirByDetayli(string AdaGore)
        {
            List<cBireyselMusteri> list = new List<cBireyselMusteri>();

            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand();
            if (AdaGore == null)
            {
                comm = new SqlCommand("Select * from Arac where Silindi=0", conn);
            }
            else
            {
                comm = new SqlCommand("Select * from Musteri where MusteriAd like @MusteriAd + '%'", conn);
                comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = AdaGore;
            }
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cBireyselMusteri bm = new cBireyselMusteri();
                    bm._musteriID = Convert.ToInt32(dr["MusteriID"]);
                    bm._musteriAd = dr["MusteriAd"].ToString();
                    bm._musteriSoyad = dr["MusteriSoyad"].ToString();
                    bm._kimlikNo = dr["KimlikNo"].ToString();
                    bm._uyruk = dr["Uyruk"].ToString();
                    bm._dogumYeri = dr["DYeri"].ToString();
                    bm._dogumTarihi = Convert.ToDateTime(dr["DTarihi"]);
                    bm._cinsiyet = dr["Cinsiyet"].ToString();
                    bm._telefon = dr["Telefon"].ToString();
                    bm._adres = dr["Adres"].ToString();

                    list.Add(bm);

                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            return list;
        }

        public bool BireyselMusteriKontrol(string VergiNo)
        {
            bool Varmi = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from Musteri where KimlikNo=@KimlikNo", conn);
            comm.Parameters.Add("@KimlikNo", SqlDbType.VarChar).Value = VergiNo;
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

        public bool BireyselMusteriEkle(cBireyselMusteri br)
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Insert into Musteri (MusteriAd,MusteriSoyad,KimlikNo,Uyruk,DYeri,DTarihi,Cinsiyet,Telefon,Adres) values(@MusteriAd,@MusteriSoyad,@KimlikNo,@Uyruk,@DYeri,@DTarihi,@Cinsiyet,@Telefon,@Adres)", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = br._musteriAd;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = br._musteriSoyad;
            comm.Parameters.Add("@KimlikNo", SqlDbType.VarChar).Value = br._kimlikNo;
            comm.Parameters.Add("@Uyruk", SqlDbType.VarChar).Value = br._uyruk;
            comm.Parameters.Add("@DYeri", SqlDbType.VarChar).Value = br._dogumYeri;
            comm.Parameters.Add("@DTarihi", SqlDbType.VarChar).Value = br._dogumTarihi;
            comm.Parameters.Add("@Cinsiyet", SqlDbType.VarChar).Value = br._cinsiyet;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = br.Telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = br._adres;

            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }

        public bool BireyselMusteriGuncelle(cBireyselMusteri br)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Update Musteri Set MusteriAd=@MusteriAd,MusteriSoyad=@MusteriSoyad,KimlikNo=@KimlikNo,Uyruk=@Uyruk,DYeri=@DYeri,DTarihi=@DTarihi,Cinsiyet=@Cinsiyet,Telefon=@Telefon,Adres=@Adres where MusteriID=@MusteriID", conn);

            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = br._musteriID;
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = br._musteriAd;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = br._musteriSoyad;
            comm.Parameters.Add("@KimlikNo", SqlDbType.VarChar).Value = br._kimlikNo;
            comm.Parameters.Add("@Uyruk", SqlDbType.VarChar).Value = br._uyruk;
            comm.Parameters.Add("@DYeri", SqlDbType.VarChar).Value = br._dogumYeri;
            comm.Parameters.Add("@DTarihi", SqlDbType.DateTime).Value = br._dogumTarihi;
            comm.Parameters.Add("@Cinsiyet", SqlDbType.VarChar).Value = br._cinsiyet;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = br.Telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = br._adres;


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
    }
}
