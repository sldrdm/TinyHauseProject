using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;
using TinyHauseProject.Forms.EvSahibi;

namespace TinyHauseProject.Forms.Kiraci
{ 
    public partial class KiraciDashboard : Form
    {
        private int kullaniciID;
        private string kullaniciAdi;

        public KiraciDashboard(int kullaniciID, string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
            this.kullaniciAdi = kullaniciAdi;
            this.Load += KiraciDashboard_Load;
        }

        private void KiraciDashboard_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = $"Hoş geldiniz, {kullaniciAdi}";

            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand(@"
                        SELECT 
                            COUNT(*) AS Toplam,
                            SUM(CASE WHEN Aktif = 1 THEN 1 ELSE 0 END) AS Aktif,
                            SUM(CASE WHEN Aktif = 0 THEN 1 ELSE 0 END) AS Iptal
                        FROM Rezervasyonlar
                        WHERE KiraciID = @KullaniciID", conn);

                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblToplamRezervasyon.Text = $"Toplam Rezervasyon: {reader["Toplam"]}";
                            lblAktifRezervasyon.Text = $"Aktif Rezervasyon: {reader["Aktif"]}";
                            lblIptalEdilen.Text = $"İptal Edilen: {reader["Iptal"]}";
                        }
                    }

                    // Ortalama puanı çek
                    SqlCommand puanCmd = new SqlCommand(@"
                        SELECT AVG(CAST(Puan AS FLOAT))
                        FROM Yorumlar
                        WHERE KullaniciID = @KullaniciID", conn);
                    puanCmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                    object ortPuan = puanCmd.ExecuteScalar();
                    double ortalama = ortPuan != DBNull.Value ? Convert.ToDouble(ortPuan) : 0.0;
                    lblOrtalamaPuan.Text = $"Ortalama Puan: {ortalama:F2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnEvAra_Click(object sender, EventArgs e)
        {
            EvAraForm evAraForm = new EvAraForm(kullaniciID);
            evAraForm.Show();
        }

        private void btnRezervasyonlarim_Click(object sender, EventArgs e)
        {
           RezervasyonlarimForm rezervasyonForm = new RezervasyonlarimForm(kullaniciID);
            rezervasyonForm.Show();
        }

        private void btnPopulerEvler_Click(object sender, EventArgs e)
        {
            var frm = new PopulerEvlerForm();
            frm.Show();
        }

    }
}
