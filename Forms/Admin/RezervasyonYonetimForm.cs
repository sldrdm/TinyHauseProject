// RezervasyonYonetimForm.cs
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Admin
{
    public partial class RezervasyonYonetimForm : Form
    {
        public RezervasyonYonetimForm()
        {
            InitializeComponent();
            dgvRezervasyonlar.AutoGenerateColumns = true;
            dgvRezervasyonlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRezervasyonlar.MultiSelect = false;
            dgvRezervasyonlar.ReadOnly = true;
            KolonlariOlustur();
            RezervasyonlariYukle();
            this.Load += new System.EventHandler(this.RezervasyonYonetimForm_Load);

        }
        private void RezervasyonYonetimForm_Load(object sender, EventArgs e)
        {
            cmbOdemeDurumu.Items.Clear(); // Önce tamamen temizle!
            cmbOdemeDurumu.Items.Add("Tümü");
            cmbOdemeDurumu.Items.Add("Bekliyor");
            cmbOdemeDurumu.Items.Add("Ödendi");
            cmbOdemeDurumu.Items.Add("İptal");
            cmbOdemeDurumu.SelectedIndex = 0; // "Tümü" varsayılan
        }
        private void btnAktifYap_Click(object sender, EventArgs e)
        {
            int? rezervasyonId = SeciliRezervasyonID();
            if (rezervasyonId == null)
            {
                MessageBox.Show("Lütfen aktif yapılacak rezervasyonu seçin.");
                return;
            }

            var sonuc = MessageBox.Show("Rezervasyonu tekrar aktif yapmak istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Rezervasyonlar SET Aktif = 1 WHERE RezervasyonID = @id", conn);
                    Veritabani.ParametreEkle(cmd, "@id", rezervasyonId);
                    cmd.ExecuteNonQuery();
                    RezervasyonlariYukle();
                }
            }
        }



        private void KolonlariOlustur()
        {
            dgvRezervasyonlar.Columns.Clear();
            dgvRezervasyonlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RezervasyonID",
                DataPropertyName = "RezervasyonID",
                Visible = false
            });
            dgvRezervasyonlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Kiraci",
                HeaderText = "Kiracı",
                DataPropertyName = "Kiraci",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvRezervasyonlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Ev",
                HeaderText = "Ev",
                DataPropertyName = "Ev",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvRezervasyonlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BaslangicTarihi",
                HeaderText = "Başlangıç Tarihi",
                DataPropertyName = "BaslangicTarihi",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvRezervasyonlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BitisTarihi",
                HeaderText = "Bitiş Tarihi",
                DataPropertyName = "BitisTarihi",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvRezervasyonlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tutar",
                HeaderText = "Tutar (₺)",
                DataPropertyName = "Tutar",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvRezervasyonlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OdemeDurumu",
                HeaderText = "Ödeme Durumu",
                DataPropertyName = "OdemeDurumu",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvRezervasyonlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Aktif",
                HeaderText = "Rezervasyon Durumu",
                DataPropertyName = "Aktif",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }

      
        private void RezervasyonlariYukle(string odemeDurumuFiltre = "Tümü")
        {
            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    string sorgu = @"
                SELECT 
                    r.RezervasyonID,
                    k.Ad + ' ' + k.Soyad AS Kiraci,
                    e.Baslik AS Ev,
                    r.BaslangicTarihi,
                    r.BitisTarihi,
                    o.Tutar,
                    CASE o.OdemeDurumu
                        WHEN 0 THEN 'Bekliyor'
                        WHEN 1 THEN 'Ödendi'
                        WHEN 2 THEN 'İptal'
                    END AS OdemeDurumu,
                    CASE r.Aktif
                        WHEN 1 THEN 'Aktif'
                        ELSE 'Pasif'
                    END AS Aktif
                FROM Rezervasyonlar r
                INNER JOIN Kullanicilar k ON r.KiraciID = k.KullaniciID
                INNER JOIN Evler e ON r.EvID = e.EvID
                LEFT JOIN Odemeler o ON o.RezervasyonID = r.RezervasyonID";

                    if (odemeDurumuFiltre != "Tümü")
                    {
                        sorgu += " WHERE o.OdemeDurumu = @durum";
                    }

                    sorgu += " ORDER BY r.RezervasyonTarihi DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);

                    if (odemeDurumuFiltre != "Tümü")
                    {
                        short durumKodu = 0;
                        if (odemeDurumuFiltre == "Bekliyor") durumKodu = 0;
                        else if (odemeDurumuFiltre == "Ödendi") durumKodu = 1;
                        else if (odemeDurumuFiltre == "İptal") durumKodu = 2;

                        da.SelectCommand.Parameters.AddWithValue("@durum", durumKodu);
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRezervasyonlar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        private int? SeciliRezervasyonID()
        {
            if (dgvRezervasyonlar.CurrentRow != null)
            {
                return Convert.ToInt32(dgvRezervasyonlar.CurrentRow.Cells["RezervasyonID"].Value);
            }
            return null;
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            int? rezervasyonId = SeciliRezervasyonID();
            if (rezervasyonId == null)
            {
                MessageBox.Show("Lütfen iptal edilecek rezervasyonu seçin.");
                return;
            }

            var sonuc = MessageBox.Show("Rezervasyonu iptal etmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Rezervasyonlar SET Aktif = 0 WHERE RezervasyonID = @id", conn);
                    Veritabani.ParametreEkle(cmd, "@id", rezervasyonId);
                    cmd.ExecuteNonQuery();
                    RezervasyonlariYukle();
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            cmbOdemeDurumu.SelectedIndex = 0; // Tümü
            RezervasyonlariYukle("Tümü");
        }

        private void cmbOdemeDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliDurum = cmbOdemeDurumu.SelectedItem?.ToString() ?? "Tümü";
            RezervasyonlariYukle(seciliDurum);
        }

        private void dgvRezervasyonlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtArama_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
