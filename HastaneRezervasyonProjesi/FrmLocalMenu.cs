using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRezervasyonProjesi
{
    public partial class FrmLocalMenu : Form
    {
        public FrmLocalMenu()
        {
            InitializeComponent();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            FrmHastaGiris hasta = new FrmHastaGiris();
            hasta.Show();
            this.Hide();

        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris doktor = new FrmDoktorGiris();
            doktor.Show();
            this.Hide();
        }

        private void BtnSekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris sekreter = new FrmSekreterGiris();
            sekreter.Show();
            this.Hide();
        }
    }
}
