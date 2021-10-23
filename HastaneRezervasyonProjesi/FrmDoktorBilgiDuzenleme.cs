using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneRezervasyonProjesi
{
    public partial class FrmDoktorBilgiDuzenleme : Form
    {
        public FrmDoktorBilgiDuzenleme()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string TcNo;
        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update Tbl_Doktor set DoktorAd=@p2,DoktorSoyad=@p3,DoktorBrans=@p4,DoktorSifre=@p5 where DoktorTC=@p1", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", MskTC.Text);
            guncelle.Parameters.AddWithValue("@p2", txtAd.Text);
            guncelle.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p4", cmbBrans.Text);
            guncelle.Parameters.AddWithValue("@p5", TxtSifre.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Veri Güncellendi");






        }

        private void FrmDoktorBilgiDuzenleme_Load(object sender, EventArgs e)
        {
            MskTC.Text = TcNo;
            SqlCommand veriCekme = new SqlCommand("select * from Tbl_Doktor where DoktorTC=@p1", bgl.baglanti());
            veriCekme.Parameters.AddWithValue("@p1", TcNo);
            SqlDataReader dr = veriCekme.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                TxtSifre.Text = dr[5].ToString();
                
            }
            bgl.baglanti().Close();
        }
    }
}
