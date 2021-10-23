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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * From Tbl_Sekreterler where SekreterTc=@p1 and SekreterSifre=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay Sekreter =new FrmSekreterDetay();
                Sekreter.TCno = MskTc.Text;
                Sekreter.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Hatalı TC & Sifre  lütfen kontrol edip tekrar deneyiniz.");
            }
            bgl.baglanti().Close();
        }
    }
}
