using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;
using TinyHauseProject.Models;
using TinyHauseProject.Services;

namespace TinyHauseProject.Forms.Kiraci
{
    public partial class RezervasyonYapForm : Form
    {
        private int kullaniciID;
        private int evID;

        public RezervasyonYapForm(int kullaniciID, int evID)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
            this.evID = evID;
        }

        private void RezervasyonYapForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("SELECT Baslik, Fiyat, Konum FROM Evler WHERE EvID = @EvID", conn);
                    cmd.Parameters.AddWithValue("@EvID", evID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblEvBilgisi.Text = $"Ev: {reader["Baslik"]} - {reader["Konum"]} - {reader["Fiyat"]} ₺ / Gece";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ev bilgisi yüklenemedi: " + ex.Message);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           

            DateTime baslangic = dtpBaslangic.Value.Date;
            DateTime bitis = dtpBitis.Value.Date;

            if (bitis <= baslangic)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden sonra olmalıdır.");
                return;
            }

            int gunSayisi = (bitis - baslangic).Days;

            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("SELECT Fiyat FROM dbo.Evler WHERE EvID = @EvID", conn);
                    cmd.Parameters.AddWithValue("@EvID", evID);
                    decimal fiyat = Convert.ToDecimal(cmd.ExecuteScalar());

                    decimal toplamTutar = gunSayisi * fiyat;
                    lblTutar.Text = $"Toplam Tutar: {toplamTutar:C2}";
                    lblTutar.Tag = toplamTutar; // Tutarı sakla
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tutar hesaplanırken hata oluştu: " + ex.Message);
            }
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dtpBaslangic.Value.Date;
            DateTime bitis = dtpBitis.Value.Date;

            if (lblTutar.Tag == null)
            {
                MessageBox.Show("Lütfen önce tutarı hesaplayın.");
                return;
            }

            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand checkEv = new SqlCommand("SELECT COUNT(*) FROM Evler WHERE EvID = @EvID", conn);
                    checkEv.Parameters.AddWithValue("@EvID", evID);
                    int evVarMi = (int)checkEv.ExecuteScalar();
                    if (evVarMi == 0)
                    {
                        MessageBox.Show("Gelen EvID: " + evID);
                        MessageBox.Show("Seçili ev bulunamadı. Lütfen tekrar deneyin.");
                        return;
                    }
                    SqlCommand rezervasyonCmd = new SqlCommand(@"
                        INSERT INTO Rezervasyonlar (KiraciID, EvID, BaslangicTarihi, BitisTarihi)
                        VALUES (@KiraciID, @EvID, @Baslangic, @Bitis)", conn);

                    rezervasyonCmd.Parameters.AddWithValue("@KiraciID", kullaniciID);
                    rezervasyonCmd.Parameters.AddWithValue("@EvID", evID);
                    rezervasyonCmd.Parameters.AddWithValue("@Baslangic", baslangic);
                    rezervasyonCmd.Parameters.AddWithValue("@Bitis", bitis);

                    rezervasyonCmd.ExecuteNonQuery();

                    MessageBox.Show("Rezervasyon başarıyla oluşturuldu. Ödeme ve onay bilgisi yakında eklenecek.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon yapılırken hata oluştu: " + ex.Message);
            }
        }

        private void RezervasyonYapForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
