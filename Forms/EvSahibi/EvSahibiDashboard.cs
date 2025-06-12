using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TinyHauseProject.Forms.EvSahibi
{
    public partial class EvSahibiDashboard : Form
    {
        private int kullaniciId;

        public EvSahibiDashboard(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;

          
        }

        private void BtnEvlerim_Click(object sender, EventArgs e)
        {
            new Evlerim(kullaniciId).Show();
        }

        private void BtnRezervasyonlar_Click(object sender, EventArgs e)
        {
            new RezervasyonlarForm(kullaniciId).Show();
        }

        private void BtnYorumlar_Click(object sender, EventArgs e)
        {
            new YorumlarForm(kullaniciId).Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["LoginForm2"]?.Show();
        }
    }
}
