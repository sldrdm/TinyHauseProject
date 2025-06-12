using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Kiraci
{
    public partial class OdemeForm : Form
    {
        private int rezervasyonId;

        public OdemeForm(int rezervasyonId, string evBilgi, decimal tutar)
        {
            InitializeComponent();
            this.rezervasyonId = rezervasyonId;
            lblEvBilgi.Text = "Ev: " + evBilgi;
            txtTutar.Text = tutar.ToString("N2");
        }

        private void vet(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
            if (string.IsNullOrWhiteSpace(txtKartAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtKartNo.Text) ||
                string.IsNullOrWhiteSpace(txtSKT.Text) ||
                string.IsNullOrWhiteSpace(txtCVV.Text))
            {
                lblMesaj.Text = "Lütfen tüm ödeme alanlarını doldurun.";
                return;
            }

            if (txtKartNo.Text.Length != 16 || !long.TryParse(txtKartNo.Text, out _))
            {
                lblMesaj.Text = "Kart numarası 16 haneli olmalıdır.";
                return;
            }

            if (txtCVV.Text.Length != 3 || !int.TryParse(txtCVV.Text, out _))
            {
                lblMesaj.Text = "CVV 3 haneli olmalıdır.";
                return;
            }

            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    string query = "INSERT INTO Odemeler (RezervasyonID, Tutar, OdemeDurumu) VALUES (@rezId, 0, 1)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rezId", rezervasyonId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Ödeme başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                lblMesaj.Text = "Hata: " + ex.Message;
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {

        }
    }
}
