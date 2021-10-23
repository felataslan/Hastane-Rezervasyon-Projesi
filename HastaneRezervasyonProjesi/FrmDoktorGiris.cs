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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * From Tbl_Doktor where DoktorTc=@p1 and DoktorSifre=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay doktor = new FrmDoktorDetay();
                doktor.TCno = MskTC.Text;
                doktor.Show();
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
