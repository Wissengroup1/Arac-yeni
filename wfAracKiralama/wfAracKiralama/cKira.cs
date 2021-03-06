﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfAracKiralama
{
    class cKira
    {
        private int _kiraID;
        private int _musteriNo;
        private int _firmaNo;
        private int _aracNo;
        private DateTime _kirayaGidisTarihi;
        private DateTime _kiradanDonusTarihi;
        private int _tutar;
        private int _kiraDetayID;

        #region Properties 
        public int KiraID
        {
            get { return _kiraID; }
            set { _kiraID = value; }
        }
        public int MusteriNo
        {
            get { return _musteriNo; }
            set { _musteriNo = value; }
        }


        public int FirmaNo
        {
            get { return _firmaNo; }
            set { _firmaNo = value; }
        }


        public int AracNo
        {
            get { return _aracNo; }
            set { _aracNo = value; }
        }


        public DateTime KirayaGidisTarihi
        {
            get { return _kirayaGidisTarihi; }
            set { _kirayaGidisTarihi = value; }
        }


        public DateTime KiradanDonusTarihi
        {
            get { return _kiradanDonusTarihi; }
            set { _kiradanDonusTarihi = value; }
        }


        public int Tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        }       
        public int KiraDetayID
        {
            get { return _kiraDetayID; }
            set { _kiraDetayID = value; }
        }
        #endregion

        public bool BireyselKirala(cKira bk)
        {
            int a = 0;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm3 = new SqlCommand("select KiraDetayID from KiraDetay", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm3.ExecuteReader();
                while (dr.Read())
                {
                    a = Convert.ToInt32(dr[0]);
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
            a++;

            SqlCommand comm1 = new SqlCommand("Insert into KiraDetay (ToplamTutar,KiraDetayID) values(@ToplamTutar,@KiraDetayID)", conn);
            comm1.Parameters.Add("@ToplamTutar", SqlDbType.Int).Value = bk._tutar;
            comm1.Parameters.Add("@KiraDetayID", SqlDbType.Int).Value = a;
            if (conn.State == ConnectionState.Closed) conn.Open();
            comm1.ExecuteNonQuery();
            conn.Close();
            SqlCommand comm2 = new SqlCommand("select KiraDetayID from KiraDetay", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr1;
            try
            {
                dr1 = comm2.ExecuteReader();
                while (dr1.Read())
                {
                    bk._kiraDetayID = Convert.ToInt32(dr1[0]);
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();

            SqlCommand comm = new SqlCommand("Insert into Kiralama (MusteriNo,AracNo,KirayaGidisTarihi,KiradanDonusTarihi,Tutar,KiraDetayID) values(@MusteriNo,@AracNo,@KirayaGidisTarihi,@KiradanDonusTarihi,@Tutar,@KiraDetayID)", conn);
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = bk._musteriNo;
            comm.Parameters.Add("@AracNo", SqlDbType.Int).Value = bk._aracNo;
            comm.Parameters.Add("@KirayaGidisTarihi", SqlDbType.DateTime).Value = bk._kirayaGidisTarihi;
            comm.Parameters.Add("@KiradanDonusTarihi", SqlDbType.DateTime).Value = bk._kiradanDonusTarihi;
            comm.Parameters.Add("@Tutar", SqlDbType.Int).Value = bk._tutar;
            comm.Parameters.Add("@KiraDetayID", SqlDbType.Int).Value = bk._kiraDetayID;          

            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }

        public List<cKira> KiralananGetirBireysel()
        {
            List<cKira> list = new List<cKira>();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from Kiralama where Silindi=0 and MusteriNo not like 'NULL'", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {              
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cKira a = new cKira();
                    a._kiraID = Convert.ToInt32(dr["KiraID"]);                   
                    a._musteriNo = Convert.ToInt32(dr["MusteriNo"]);
                    a._aracNo = Convert.ToInt32(dr["AracNo"]);
                    a._kirayaGidisTarihi = Convert.ToDateTime(dr["KirayaGidisTarihi"]);
                    a._kiradanDonusTarihi = Convert.ToDateTime(dr["KiradanDonusTarihi"]);
                    a._tutar = Convert.ToInt32(dr["Tutar"]);
                    a._kiraDetayID = Convert.ToInt32(dr["KiraDetayID"]);
                    list.Add(a);
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return list;
        }

        public List<cKira> KiralananGetirKurumsal()
        {
            List<cKira> list = new List<cKira>();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from Kiralama where Silindi=0 and FirmaNo not like 'NULL'", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cKira a = new cKira();
                    a._kiraID = Convert.ToInt32(dr["KiraID"]);
                    a._firmaNo = Convert.ToInt32(dr["FirmaNo"]);
                    a._aracNo = Convert.ToInt32(dr["AracNo"]);
                    a._kirayaGidisTarihi = Convert.ToDateTime(dr["KirayaGidisTarihi"]);
                    a._kiradanDonusTarihi = Convert.ToDateTime(dr["KiradanDonusTarihi"]);
                    a._tutar = Convert.ToInt32(dr["Tutar"]);
                    a._kiraDetayID = Convert.ToInt32(dr["KiraDetayID"]);
                    list.Add(a);
                }
                for (int i = 0; i < cGenel.AracEkle; i++)
                {
                    
                }
                
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return list;
        }

        public void KurumsalKirala(cKira kk)
        {
       
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm1 = new SqlCommand("Insert into KiraDetay (ToplamTutar,KiraDetayID) values(@ToplamTutar,@KiraDetayID)", conn);

            comm1.Parameters.Add("@ToplamTutar", SqlDbType.Int).Value = kk._tutar;
            comm1.Parameters.Add("@KiraDetayID", SqlDbType.Int).Value = cGenel.KiraDetayKurumsal;

            if (conn.State == ConnectionState.Closed) conn.Open();
            comm1.ExecuteNonQuery();
            conn.Close();

            SqlCommand comm2 = new SqlCommand();

            comm2.Connection = conn;
            comm2.CommandText = "Insert into Kiralama (FirmaNo,AracNo,KirayaGidisTarihi,KiradanDonusTarihi,Tutar,KiraDetayID) values (@FirmaNo,@AracNo,@KirayaGidisTarihi,@KiradanDonusTarihi,@Tutar,@KiraDetayID)";

            comm2.Parameters.Add("@FirmaNo", SqlDbType.Int).Value = kk._firmaNo;
            comm2.Parameters.Add("@AracNo", SqlDbType.Int).Value = kk._aracNo;
            comm2.Parameters.Add("@KirayaGidisTarihi", SqlDbType.DateTime).Value = kk._kirayaGidisTarihi;
            comm2.Parameters.Add("@KiradanDonusTarihi", SqlDbType.DateTime).Value = kk._kiradanDonusTarihi;
            comm2.Parameters.Add("@Tutar", SqlDbType.Int).Value = kk._tutar;
            comm2.Parameters.Add("@KiraDetayID", SqlDbType.Int).Value = cGenel.KiraDetayKurumsal;
            if (conn.State == ConnectionState.Closed) conn.Open();
            comm2.ExecuteNonQuery();
            conn.Close();
        }

        public int KiraDetayIDGetir()
        {
            int a = 0;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("select KiraDetayID from KiraDetay", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    a = Convert.ToInt32(dr[0]);
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
            int ID = a + 1;
            return ID;
        }

        public void AracDetayIDGetir(DataGridView dgv, cKira k)
        {
            k._kiraDetayID = Convert.ToInt32(dgv.SelectedRows[0].Cells[7].Value);
        }

        public List<cKira> KiralananGetirKurumsalByKiraDetayID(cKira k)
        {
            List<cKira> list = new List<cKira>();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from Kiralama where KiraDetayID=@KiraDetayID and FirmaNo not like 'NULL'", conn);
            comm.Parameters.Add("@KiraDetayID", SqlDbType.Int).Value = k._kiraDetayID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cKira a = new cKira();
                    a._aracNo = Convert.ToInt32(dr["AracNo"]);
                    list.Add(a);
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
