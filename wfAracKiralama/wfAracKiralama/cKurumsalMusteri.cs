using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
