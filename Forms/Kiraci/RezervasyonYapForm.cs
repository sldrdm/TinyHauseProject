using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;
using TinyHauseProject.Forms.Kiraci;
using TinyHauseProject.Models;

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

           

            int gunSayisi = (bitis - baslangic).Days;

            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("SELECT Fiyat FROM Evler WHERE EvID = @EvID", conn);
                    cmd.Parameters.AddWithValue("@EvID", evID);

                    decimal fiyat = Convert.ToDecimal(cmd.ExecuteScalar());
                    decimal toplamTutar = gunSayisi * fiyat;

                    lblTutar.Text = $"Toplam Tutar: {toplamTutar:C2}";
                    lblTutar.Tag = toplamTutar; // saklama
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

            if (bitis <= baslangic)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden sonra olmalıdır.");
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
                        MessageBox.Show("Seçili ev bulunamadı. Lütfen tekrar deneyin.");
                        return;
                    }

                    // 1. INSERT komutu
                    SqlCommand insertCmd = new SqlCommand(@"
                    INSERT INTO Rezervasyonlar 
                        (KiraciID, EvID, BaslangicTarihi, BitisTarihi, Aktif, RezervasyonTarihi)
                    VALUES 
                        (@KiraciID, @EvID, @Baslangic, @Bitis, 1, GETDATE());", conn);

                    insertCmd.Parameters.AddWithValue("@KiraciID", kullaniciID);
                    insertCmd.Parameters.AddWithValue("@EvID", evID);
                    insertCmd.Parameters.AddWithValue("@Baslangic", baslangic);
                    insertCmd.Parameters.AddWithValue("@Bitis", bitis);
                    insertCmd.ExecuteNonQuery();


                    // 2. En son ID'yi al
                    SqlCommand idCmd = new SqlCommand(@"
                    SELECT MAX(RezervasyonID) 
                    FROM Rezervasyonlar 
                    WHERE KiraciID = @KiraciID AND EvID = @EvID AND BaslangicTarihi = @Baslangic AND BitisTarihi = @Bitis", conn);

                    idCmd.Parameters.AddWithValue("@KiraciID", kullaniciID);
                    idCmd.Parameters.AddWithValue("@EvID", evID);
                    idCmd.Parameters.AddWithValue("@Baslangic", baslangic);
                    idCmd.Parameters.AddWithValue("@Bitis", bitis);

                    object rezIDobj = idCmd.ExecuteScalar();

                    if (rezIDobj == DBNull.Value || rezIDobj == null)
                    {
                        MessageBox.Show("Rezervasyon ID alınamadı. Lütfen tekrar deneyin.");
                        return;
                    }

                    int rezervasyonID = Convert.ToInt32(rezIDobj);

                    decimal toplamTutar = (decimal)lblTutar.Tag;
                    string evBilgi = lblEvBilgisi.Text;

                    SqlCommand odemeInsert = new SqlCommand(@"
                    INSERT INTO Odemeler (RezervasyonID, Tutar, OdemeDurumu, Aktif)
                    VALUES (@rezID, @tutar, 0, 1)", conn);
                    odemeInsert.Parameters.AddWithValue("@rezID", rezervasyonID);
                    odemeInsert.Parameters.AddWithValue("@tutar", toplamTutar);
                    odemeInsert.ExecuteNonQuery();

                    OdemeForm odemeForm = new OdemeForm(rezervasyonID, evBilgi, toplamTutar);
                    this.Hide();
                    odemeForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata detay: " + ex.ToString());
                MessageBox.Show("Rezervasyon yapılırken hata oluştu: " + ex.Message);
            }
        }

    }
}

