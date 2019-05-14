using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wf_ADONet_OKUL.DataModel;
using wf_ADONet_OKUL.Models;

namespace wf_ADONet_OKUL
{
    public partial class frmOgrenciIsleri : Form
    {
        public frmOgrenciIsleri()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(Genel.connStr);
        OgrenciServis os = new OgrenciServis();
        SinifServis ss = new SinifServis();
        int SinifID;
        private void frmOgrenciIsleri_Load(object sender, EventArgs e)
        {
            Listele(os.OgrenciListesi());
            cbSiniflar.DataSource = ss.SinifModelListesi();
            List<SinifModel> liste = ss.SinifModelListesi();
            SinifModel sm = new SinifModel();
            sm.Id = 0;
            sm.SinifAdi = "Tüm Siniflar";
            liste.Insert(0,sm);
            comboBox1.DataSource = liste;
            dataGridView1.DataSource = os.OgrenciListesi();
        }
        private void Listele(List<Ogrenci> liste)
        {
            dgvOgrenciler.DataSource = liste;
            dgvOgrenciler.Columns[0].Visible = false;
            dgvOgrenciler.Columns[8].Visible = false;
        }
        private void tsYeni_Click(object sender, EventArgs e)
        {
            tsKaydet.Enabled = true;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;
            Genel.Temizle(tpOgrenciKayit); //???TabPage control'lerinde aratılacak.
            txtAdi.Focus();
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        { 
             
            SqlCommand comm = new SqlCommand(" select* from Ogrenciler where Adi like '@Adi%'", conn);
            comm.Parameters.Add("@Adi", SqlDbType.VarChar).Value = txtAdaGore.Text;
           
            if (conn.State == ConnectionState.Closed) conn.Open();


            //SqlDataReader dr = comm.ExecuteReader();
            //while (dr.Read())
            //{
            //    dgvOgrenciler.DataSource = dr["Ogrenciler"].ToString();
            //}

            conn.Close();


        }

        private void dgvOgrenciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSoyadaGore_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTCKNo.Text.Trim() != "")
            {
                if (os.OgrenciKontrolByTCKNo(txtTCKNo.Text))
                {
                    MessageBox.Show("var bu");
                    txtAdi.Focus();
                }
                else
                {
                    Ogrenci o = new Ogrenci();
                    
                    o.Adi = txtAdi.Text;
                    o.Soyadi = txtSoyadi.Text;
                    o.Telefon = txtTelefon.Text;
                    o.Adres =txtAdres.Text;
                    o.TCKNo =txtTCKNo.Text;
                    o.TaksitSayisi = Convert.ToByte(txtTaksitSayisi.Text);
                    o.TaksitTutari = Convert.ToDouble(txtTaksitTutari.Text);
                   o.SinifId =SinifID;
                    if (os.OgrenciEkle(o))
                    {
                        MessageBox.Show("ok");
                       dataGridView1.DataSource=os.OgrenciListesi();
                        dgvOgrenciler.DataSource = os.OgrenciListesi();
                    }
                    else
                    {
                        MessageBox.Show("Ürün bilgileri eklenemedi.", "Kayıt Gerçekleşmedi.");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("eksik");
                txtAdi.Focus();
            }

            }

        private void cbSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SinifModel secilen = (SinifModel)cbSiniflar.SelectedItem;
            SinifID = secilen.Id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Ogrenciler where Adi like @Adi+'%'",conn);
            da.SelectCommand.Parameters.Add("@Adi",SqlDbType.VarChar).Value=textBox1.Text;
            DataSet ds = new DataSet();

            da.Fill(ds, "OgrenciAd");
            dataGridView1.DataSource = ds.Tables["OgrenciAd"];
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SElect * from Ogrenciler where Soyadi like'" + textBox2.Text + "%'", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "OgrenciSOYAd");
            dataGridView1.DataSource = ds.Tables["OgrenciSOYAd"];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SElect * from Ogrenciler where Telefon like'" + textBox3.Text + "%'", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "Ogrencitel");
            dataGridView1.DataSource = ds.Tables["Ogrencitel"];
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SElect * from Ogrenciler where Adres like'" + textBox4.Text + "%'", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "OgrenciAdres");
            dataGridView1.DataSource = ds.Tables["OgrenciAdres"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsKullanici_Click(object sender, EventArgs e)
        {

        }
    }
    }

