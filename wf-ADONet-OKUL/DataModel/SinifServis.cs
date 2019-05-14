using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_ADONet_OKUL.Models;

namespace wf_ADONet_OKUL.DataModel
{
    public class SinifServis : ISinifServis
    {
        SqlConnection conn = new SqlConnection(Genel.connStr);
        public bool SinifEkle(Sinif s)
        {
            throw new NotImplementedException();
        }

        public Sinif SinifGetirByID(int ID)
        {
            throw new NotImplementedException();
        }

        public bool SinifGuncelle(Sinif s)
        {
            throw new NotImplementedException();
        }

        public List<Sinif> SinifListesi()
        {
            List<Sinif> listSiniflar = new List<Sinif>();
            SqlCommand comm = new SqlCommand("Select * from Siniflar", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Sinif s = new Sinif();
                        s.Id = Convert.ToInt32(dr[0]);
                        s.SinifAdi = dr[1].ToString();
                        s.AcilisTarihi = Convert.ToDateTime(dr[2]);
                        s.KapanisTarihi = Convert.ToDateTime(dr[3]);
                        s.OgretmenId = Convert.ToInt32(dr[4]);
                        s.Aciklama = dr[5].ToString();
                        listSiniflar.Add(s);
                    }
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return listSiniflar;
        }
        public List<SinifModel> SinifModelListesi()
        {
            List<SinifModel> listSiniflar = new List<SinifModel>();
            SqlCommand comm = new SqlCommand("Select * from Siniflar", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SinifModel sm = new SinifModel();
                        sm.Id = Convert.ToInt32(dr[0]);
                        sm.SinifAdi = dr[1].ToString();
                        listSiniflar.Add(sm);
                    }
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return listSiniflar;
        }

        public bool SinifSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool SinifSil(Sinif s)
        {
            throw new NotImplementedException();
        }
    }
}
