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
    public partial class FrmRandevuListe : Form
    {
        public FrmRandevuListe()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmRandevuListe_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevu" ,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskTarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskSaat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            CmbDoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            ChbxDurum.Checked = Convert.ToBoolean( dataGridView1.Rows[secilen].Cells[5].Value);
            MskHastaTC.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Randevu set RandevuTarih=@p2,RandevuSaat=@p3,RandevuBrans=@p4,RandevuDoktor=@p5,RandevuDurum=@p6,HastaTC=@p7  where RandevuID=@p1",bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtID.Text);
            komutguncelle.Parameters.AddWithValue("@p2", MskTarih.Text);
            komutguncelle.Parameters.AddWithValue("@p3", MskSaat.Text);
            komutguncelle.Parameters.AddWithValue("@p4", CmbBrans.Text);
            komutguncelle.Parameters.AddWithValue("@p5", CmbDoktor.Text);
            komutguncelle.Parameters.AddWithValue("@p6", ChbxDurum.Checked);
            komutguncelle.Parameters.AddWithValue("@p7", MskHastaTC.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Güncellendi");








        }
    }
}
