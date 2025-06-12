using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Kiraci
{
    public partial class YorumEkleForm : Form
    {
        private int kullaniciID;
        private int evID;

        public YorumEkleForm(int girisYapanKullaniciID, int secilenEvID)
        {
            InitializeComponent();
            kullaniciID = girisYapanKullaniciID;
            evID = secilenEvID;
        }

        private void YorumEkleForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT Baslik, Konum FROM Evler WHERE EvID = @EvID", conn);
                    cmd.Parameters.AddWithValue("@EvID", evID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblSeciliEv.Text = $"Ev: {reader["Baslik"]} ({reader["Konum"]})";
                        }
                        else
                        {
                            lblSeciliEv.Text = "Ev bilgisi bulunamadı!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ev bilgisi yüklenemedi: " + ex.Message);
            }
        }

        private void btnYorumGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYorum.Text))
            {
                MessageBox.Show("Lütfen bir yorum girin.");
                return;
            }

            int puan = (int)nudPuan.Value;
            string yorumMetni = txtYorum.Text.Trim();

            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO Yorumlar (EvID, KullaniciID, Puan, Yorum)
                        VALUES (@EvID, @KullaniciID, @Puan, @Yorum)", conn);

                    cmd.Parameters.AddWithValue("@EvID", evID);
                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                    cmd.Parameters.AddWithValue("@Puan", puan);
                    cmd.Parameters.AddWithValue("@Yorum", yorumMetni);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Yorum başarıyla eklendi.");
                    txtYorum.Clear();
                    nudPuan.Value = 5;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Yorum gönderilirken hata oluştu: " + ex.Message);
            }
        }
    }
}
