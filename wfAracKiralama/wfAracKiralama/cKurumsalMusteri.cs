using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfAracKiralama
{
    class cKurumsalMusteri
    {
        private int _firmaID;
        private string _unvan;
        private string _yetkili;
        private string _adres;
        private string _telefon;
        private string _vergiNo;
        private string _vergiDairesi;

        #region Properties
        public int FirmaID
        {
            get { return _firmaID; }
            set { _firmaID = value; }
        }


        public string Unvan
        {
            get { return _unvan; }
            set { _unvan = value; }
        }


        public string Yetkili
        {
            get { return _yetkili; }
            set { _yetkili = value; }
        }


        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }


        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }


        public string VergiNo
        {
            get { return _vergiNo; }
            set { _vergiNo = value; }
        }


        public string VergiDairesi
        {
            get { return _vergiDairesi; }
            set { _vergiDairesi = value; }
        } 
        #endregion


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

        public void MusteriGetirKurumsal(DataGridView dgv, cKurumsalMusteri kr)
        {
            kr._firmaID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
        }

        public void MusterileriGetirByFirmaID(int ID, cKurumsalMusteri kr)
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from Firma where FirmaID=@FirmaID", conn);
            comm.Parameters.Add("@FirmaID", SqlDbType.Int).Value = ID;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    kr._firmaID = Convert.ToInt32(dr[0]);
                    kr._unvan = dr[1].ToString();
                    kr._yetkili = dr[2].ToString();
                    kr._adres = dr[3].ToString();
                    kr._telefon = dr[4].ToString();
                    kr._vergiNo = dr[5].ToString();
                    kr._vergiDairesi = dr[6].ToString();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
        }

        public List<cKurumsalMusteri> KurumsalMusterileriGetirByDetayli(string UnvanaGore)
        {
            List<cKurumsalMusteri> list = new List<cKurumsalMusteri>();

            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand();
            if (UnvanaGore == null)
            {
                comm = new SqlCommand("Select * from Firma where Silindi=0", conn);
            }
            else
            {
                comm = new SqlCommand("Select * from Firma where Unvan like @Unvan + '%'", conn);
                comm.Parameters.Add("@Unvan", SqlDbType.VarChar).Value = UnvanaGore;
            }
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cKurumsalMusteri kr = new cKurumsalMusteri();
                    kr._firmaID = Convert.ToInt32(dr["FirmaID"]);
                    kr._unvan = dr["Unvan"].ToString();
                    kr._yetkili = dr["Yetkili"].ToString();
                    kr._adres = dr["Adres"].ToString();
                    kr._telefon = dr["Telefon"].ToString();
                    kr._vergiNo = dr["VergiNo"].ToString();
                    kr._vergiDairesi = dr["VergiDairesi"].ToString();

                    list.Add(kr);

                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            return list;
        }

        public bool KurumsalMusteriKontrol(string VergiNo)
        {
            bool Varmi = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from Firma where VergiNo=@VergiNo", conn);
            comm.Parameters.Add("@VergiNo", SqlDbType.VarChar).Value = VergiNo;
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

        public bool KurumsalMusteriEkle(cKurumsalMusteri kr)
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Insert into Firma (Unvan,Yetkili,Adres,Telefon,VergiNo,VergiDairesi) values(@Unvan,@Yetkili,@Adres,@Telefon,@VergiNo,@VergiDairesi)", conn);
            comm.Parameters.Add("@Unvan", SqlDbType.VarChar).Value = kr._unvan;
            comm.Parameters.Add("@Yetkili", SqlDbType.VarChar).Value = kr._yetkili;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value =kr._adres;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = kr._telefon;
            comm.Parameters.Add("@VergiNo", SqlDbType.VarChar).Value = kr._vergiNo;
            comm.Parameters.Add("@VergiDairesi", SqlDbType.VarChar).Value = kr._vergiDairesi;

            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }

        public bool KurumsalMusteriGuncelle(cKurumsalMusteri kr)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Update Firma Set Unvan=@Unvan,Yetkili=@Yetkili,Adres=@Adres,Telefon=@Telefon,VergiNo=@VergiNo,VergiDairesi=@VergiDairesi where FirmaID=@FirmaID", conn);

            comm.Parameters.Add("@FirmaID", SqlDbType.Int).Value = kr._firmaID;
            comm.Parameters.Add("@Unvan", SqlDbType.VarChar).Value = kr._unvan;
            comm.Parameters.Add("@Yetkili", SqlDbType.VarChar).Value = kr._yetkili;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = kr._adres;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = kr._telefon;
            comm.Parameters.Add("@VergiNo", SqlDbType.VarChar).Value = kr._vergiNo;
            comm.Parameters.Add("@VergiDairesi", SqlDbType.VarChar).Value = kr._vergiDairesi;
            

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
