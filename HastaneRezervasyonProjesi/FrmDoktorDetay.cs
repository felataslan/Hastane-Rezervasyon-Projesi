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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
          public string TCno;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblDoktorTC.Text = TCno;
            // Ad-Soyad Çekme
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad From Tbl_Doktor where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblDoktorTC.Text);
            SqlDataReader veri = komut.ExecuteReader();
            while (veri.Read())
            {
                LblDoktorAdSoyad.Text = veri[0].ToString()+" "+veri[1].ToString();
            }
            bgl.baglanti().Close();
            //Doktora Ait Randevuları çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * From Tbl_Randevu where RandevuDoktor="+"'"+LblDoktorAdSoyad.Text+ "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular duyuru = new FrmDuyurular();
            duyuru.Show();
            this.Hide();
        }

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenleme duzenle = new FrmDoktorBilgiDuzenleme();
            duzenle.TcNo = LblDoktorTC.Text;
            duzenle.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            LblHastaTC.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            RtxtSikayet.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            SqlCommand vericekme = new SqlCommand("select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            vericekme.Parameters.AddWithValue("@p1", LblHastaTC.Text);
            SqlDataReader dr = vericekme.ExecuteReader();
            while (dr.Read())
            {
                LblHastaAdsoyad.Text = dr[0].ToString() + " " + dr[1].ToString();
            }
            bgl.baglanti().Close();





        }

        
    }
}
