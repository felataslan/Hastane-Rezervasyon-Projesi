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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TCno;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCno;
            // Ad-Soyad Çekme
            SqlCommand komut = new SqlCommand("select SekreterAdSoyad From Tbl_Sekreterler where SekreterTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader veri = komut.ExecuteReader();
            while (veri.Read())
            {
                LblAdSoyad.Text = veri[0].ToString();
            }
            bgl.baglanti().Close();

            // Branşları Çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * From Tbl_Branslar ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Doktorları Tabloya Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select DoktorID, (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktor ", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //Branşları Combobox a çekme
            SqlCommand komut1 = new SqlCommand("select BransAdi From Tbl_Branslar ", bgl.baglanti());
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                CmbBrans.Items.Add(dr[0]);


            }
            bgl.baglanti().Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@p1", MskTarih.Text);
            komutKaydet.Parameters.AddWithValue("@p2", MskSaat.Text);
            komutKaydet.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutKaydet.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(" Randevu Oluşturuldu");


        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select (DoktorAd+ ' ' +DoktorSoyad) From Tbl_Doktor where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RTxtDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPanel panel = new FrmDoktorPanel();
            panel.Show();
            this.Hide();
        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPanel panel = new FrmBransPanel();
            panel.Show();
            this.Hide();
        }

        private void BtnRandevuListesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListe randevuListe = new FrmRandevuListe();
            randevuListe.Show();
            this.Hide();
        }

        
    }
}
