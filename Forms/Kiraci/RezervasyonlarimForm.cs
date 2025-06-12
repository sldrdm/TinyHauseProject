using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Kiraci
{
    public partial class RezervasyonlarimForm : Form
    {
        private int aktifKullaniciID; // Giriş yapan kiracının ID'si

        public RezervasyonlarimForm(int kullaniciID)
        {
            InitializeComponent();
            aktifKullaniciID = kullaniciID;
        }

        private void RezervasyonlarimForm_Load(object sender, EventArgs e)
        {
            RezervasyonlariYukle();
        }

        private void RezervasyonlariYukle()
        {
            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    string query = @"
                        SELECT 
                            r.RezervasyonID,
                            e.EvID,
                            e.Baslik AS EvBaslik,
                            r.BaslangicTarihi,
                            r.BitisTarihi,
                            o.Tutar,
                            CASE o.OdemeDurumu
                                WHEN 0 THEN 'Bekliyor'
                                WHEN 1 THEN 'Ödendi'
                                WHEN 2 THEN 'İptal'
                                ELSE 'Bilinmiyor'
                            END AS OdemeDurumu,
                            CASE r.Aktif
                                WHEN 1 THEN 'Aktif'
                                WHEN 0 THEN 'İptal Edildi'
                                ELSE 'Bilinmiyor'
                            END AS Durum
                        FROM Rezervasyonlar r
                        INNER JOIN Evler e ON r.EvID = e.EvID
                        LEFT JOIN Odemeler o ON r.RezervasyonID = o.RezervasyonID
                        WHERE r.KiraciID = @KiraciID
                        ORDER BY r.BaslangicTarihi DESC";

       


                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KiraciID", aktifKullaniciID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRezervasyonlar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                lblMesaj.Text = "Veriler yüklenirken hata oluştu: " + ex.Message;
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            RezervasyonlariYukle();
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.SelectedRows.Count == 0)
            {
                lblMesaj.Text = "Lütfen iptal edilecek bir rezervasyon seçin.";
                return;
            }

            int rezervasyonID = Convert.ToInt32(dgvRezervasyonlar.SelectedRows[0].Cells["RezervasyonID"].Value);

            DialogResult dr = MessageBox.Show("Seçilen rezervasyonu iptal etmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Veritabani.BaglantiGetir())
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Rezervasyonlar SET Aktif = 0 WHERE RezervasyonID = @id", conn);
                        cmd.Parameters.AddWithValue("@id", rezervasyonID);
                        cmd.ExecuteNonQuery();
                    }
                    lblMesaj.Text = "Rezervasyon başarıyla iptal edildi.";
                    RezervasyonlariYukle();
                }
                catch (Exception ex)
                {
                    lblMesaj.Text = "İptal sırasında hata oluştu: " + ex.Message;
                }
            }
        }


        private void btnYorumYap_Click(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.SelectedRows.Count == 0)
            {
                lblMesaj.Text = "Lütfen yorum yapmak için bir rezervasyon seçiniz.";
                return;
            }

            // DataGridView'de EvID kolonunun adı "EvID" ise:
            int evID = Convert.ToInt32(dgvRezervasyonlar.SelectedRows[0].Cells["EvID"].Value);

            // YorumEkleForm'u EvID ile aç
            YorumEkleForm yorumForm = new YorumEkleForm(aktifKullaniciID, evID);
            yorumForm.ShowDialog();
        }

    }
}
