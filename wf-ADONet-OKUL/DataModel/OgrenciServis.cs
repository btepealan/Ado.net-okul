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
    public class OgrenciServis : IOgrenciServis
    {
        SqlConnection conn = new SqlConnection(Genel.connStr);

        public List<Ogrenci> OgrenciListesi()
        {
            List<Ogrenci> listOgrenciler = new List<Ogrenci>();
            SqlCommand comm = new SqlCommand("Select * from Ogrenciler", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Ogrenci o = new Ogrenci();
                        o.Id = Convert.ToInt32(dr[0]);
                        o.Adi = dr[1].ToString();
                        o.Soyadi = dr[2].ToString();
                        o.Telefon = dr[3].ToString();
                        o.Adres = dr[4].ToString();
                        o.TCKNo = dr[5].ToString();
                        o.TaksitSayisi = Convert.ToByte(dr[6]);
                        o.TaksitTutari = Convert.ToDouble(dr[7]);
                        o.SinifId = Convert.ToInt32(dr[8]);
                        listOgrenciler.Add(o);
                    }
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return listOgrenciler;
        }
        public bool OgrenciKontrolByTCKNo(string TCKimlikNo)
        {
            bool sonuc=false;
            SqlCommand comm = new SqlCommand("Select * from Ogrenciler where TCKNo=@TCKimlikNo ", conn);
            comm.Parameters.Add("@TCKimlikNo", SqlDbType.VarChar).Value =TCKimlikNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
         
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
           
        }
        public bool OgrenciEkle(Ogrenci o)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Ogrenciler(Adi,Soyadi, Telefon,Adres,TCKNo,TaksitSayisi,TaksitTutari,SinifId) values(@Adi,@Soyadi, @Telefon,@Adres,@TCKNo,@TaksitSayisi,@TaksitTutari,@SinifId)", conn);
            comm.Parameters.Add("@Adi", SqlDbType.VarChar).Value = o.Adi;
            comm.Parameters.Add("@Soyadi", SqlDbType.VarChar).Value = o.Soyadi;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = o.Telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value =o.Adres;
            comm.Parameters.Add("@TCKNo", SqlDbType.VarChar).Value = o.TCKNo;
            comm.Parameters.Add("@TaksitSayisi", SqlDbType.TinyInt).Value = o.TaksitSayisi;
            comm.Parameters.Add("@TaksitTutari", SqlDbType.Money).Value = o.TaksitTutari;
            comm.Parameters.Add("@SinifId", SqlDbType.Int).Value =o.SinifId;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return sonuc;
        }

        public Ogrenci OgrenciGetirByID(int ID)
        {
            throw new NotImplementedException();
        }

        public bool OgrenciGuncelle(Ogrenci o)
        {
            throw new NotImplementedException();
        }

        public bool OgrenciSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool OgrenciSil(Ogrenci o)
        {
            throw new NotImplementedException();
        }
    }
}
