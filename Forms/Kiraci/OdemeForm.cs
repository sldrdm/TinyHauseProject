using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Kiraci
{
    public partial class OdemeForm : Form
    {
        private int rezervasyonId;
        private decimal tutar;

        public OdemeForm(int rezervasyonId, string evBilgi, decimal tutar)
        {
            InitializeComponent();
            this.rezervasyonId = rezervasyonId;
            this.tutar = tutar;

            lblEvBilgi.Text = evBilgi;
            txtTutar.Text = tutar.ToString("N2");
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "";

            // Validasyon
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
                    // Önce varsa sil → sonra INSERT
                    SqlCommand deleteIfExists = new SqlCommand("DELETE FROM Odemeler WHERE RezervasyonID = @rezId", conn);
                    deleteIfExists.Parameters.AddWithValue("@rezId", rezervasyonId);
                    deleteIfExists.ExecuteNonQuery();

                    // INSERT işlemi
                    SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO Odemeler (RezervasyonID, Tutar, OdemeDurumu, OdemeTarihi, Aktif)
                        VALUES (@rezId, @tutar, 1, GETDATE(), 1)", conn);

                    cmd.Parameters.AddWithValue("@rezId", rezervasyonId);
                    cmd.Parameters.AddWithValue("@tutar", tutar);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ödeme başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                lblMesaj.Text = "Hata: " + ex.Message;
            }
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {
            // Gerekirse başlangıçta işlem yapılabilir
        }
    }
}
