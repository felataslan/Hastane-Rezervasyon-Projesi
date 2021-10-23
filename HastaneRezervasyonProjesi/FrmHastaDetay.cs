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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        private void Lnkbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle duzenle = new FrmHastaBilgiDuzenle();
            duzenle.TCno = LblTC.Text;
            duzenle.Show();
            this.Hide();
        }
        public string TCno;
        public bool durum = false;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            // Ad Soyad Çekme
            LblTC.Text = TCno;
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader veri = komut.ExecuteReader();
            while (veri.Read())
            {
                LblAdSoyad.Text = veri[0] + " " + veri[1];
            }
            bgl.baglanti().Close();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevu where HastaTc="+ TCno,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            // Branşları Çekme
            SqlCommand komut1 = new SqlCommand("select BransAdi from Tbl_Branslar ", bgl.baglanti());
            SqlDataReader veri1 = komut1.ExecuteReader();
            while (veri1.Read())
            {
                cmbBrans.Items.Add(veri1[0]);

            }
            bgl.baglanti().Close();
            





        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Doktorları Çekme
            SqlCommand komut2 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktor where DoktorBrans=@p1 ", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader veri2 = komut2.ExecuteReader();
            CmbDoktor.Items.Clear();
            while (veri2.Read())
            {
                
                CmbDoktor.Items.Add(veri2[0] + " " + veri2[1]);

            }
            
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevu where RandevuBrans=" +"'" + cmbBrans.Text+"'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            cmbBrans.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            CmbDoktor.Text= dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            RtxtSikayet.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();

        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            durum = true;
            SqlCommand randevuekle = new SqlCommand("update Tbl_Randevu set RandevuBrans=@p2,RandevuDoktor=@p3,HastaSikayet=@p4,HastaTC=@p5,RandevuDurum=@p6 where RandevuID=@p1",bgl.baglanti());
            randevuekle.Parameters.AddWithValue("@p2", cmbBrans.Text);
            randevuekle.Parameters.AddWithValue("@p3", CmbDoktor.Text);
            randevuekle.Parameters.AddWithValue("@p4", RtxtSikayet.Text);
            randevuekle.Parameters.AddWithValue("@p5", TCno);
            randevuekle.Parameters.AddWithValue("@p6", durum);
            randevuekle.Parameters.AddWithValue("@p1", TxtId.Text);
            randevuekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Eklendi");


        }
    }
}
