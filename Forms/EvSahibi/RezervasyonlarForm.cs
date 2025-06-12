using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.EvSahibi
{
    public partial class RezervasyonlarForm : Form
    {
        private int sahipId;

        public RezervasyonlarForm(int sahipId)
        {
            InitializeComponent();
            this.sahipId = sahipId;
            this.Load += RezervasyonlarForm_Load;
            dgvRezervasyonlar.SelectionChanged += DgvRezervasyonlar_SelectionChanged;
            btnYenile.Click += btnYenile_Click;
            btnOnayla.Click += btnOnayla_Click;
            btnReddet.Click += btnReddet_Click;
            cmbDurumFiltre.SelectedIndexChanged += cmbDurumFiltre_SelectedIndexChanged;
            txtAra.TextChanged += txtAra_TextChanged;
        }

        private void RezervasyonlarForm_Load(object sender, EventArgs e)
        {
            cmbDurumFiltre.SelectedIndex = 0;
            RezervasyonlariYukle();
        }

        private void RezervasyonlariYukle()
        {
            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    string sorgu = @"
                        SELECT 
                            r.RezervasyonID,
                            e.Baslik AS EvBaslik,
                            k.Ad + ' ' + k.Soyad AS KiraciAdi,
                            r.BaslangicTarihi,
                            r.BitisTarihi,
                            CASE r.Aktif WHEN 1 THEN 'Aktif' ELSE 'İptal' END AS Aktif,
                            CASE o.OdemeDurumu
                                WHEN 0 THEN 'Bekliyor'
                                WHEN 1 THEN 'Ödendi'
                                WHEN 2 THEN 'İptal'
                                ELSE 'Yok'
                            END AS OdemeDurumu
                        FROM Rezervasyonlar r
                        INNER JOIN Evler e ON r.EvID = e.EvID
                        INNER JOIN Kullanicilar k ON r.KiraciID = k.KullaniciID
                        LEFT JOIN Odemeler o ON r.RezervasyonID = o.RezervasyonID
                        WHERE e.SahipID = @sahipID";
                    if (cmbDurumFiltre.SelectedIndex == 1)
                        sorgu += " AND r.Aktif = 1";
                    else if (cmbDurumFiltre.SelectedIndex == 2)
                        sorgu += " AND r.Aktif = 0";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
                    da.SelectCommand.Parameters.AddWithValue("@sahipID", sahipId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRezervasyonlar.DataSource = dt;

                    if (dgvRezervasyonlar.Columns.Contains("RezervasyonID"))
                        dgvRezervasyonlar.Columns["RezervasyonID"].Visible = false;

                    lblSeciliRezervasyon.Text = dt.Rows.Count == 0 ? "Listede rezervasyon yok." : "";
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

        private void btnYenile_Click(object sender, EventArgs e)
        {
            RezervasyonlariYukle();
        }

        private void cmbDurumFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            RezervasyonlariYukle();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int? rezervasyonId = SeciliRezervasyonID();
            if (rezervasyonId == null)
            {
                MessageBox.Show("Lütfen onaylanacak rezervasyonu seçin.");
                return;
            }

            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Rezervasyonlar SET Aktif = 1 WHERE RezervasyonID = @id", conn);
                cmd.Parameters.AddWithValue("@id", rezervasyonId);
                cmd.ExecuteNonQuery();
            }
            RezervasyonlariYukle();
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            int? rezervasyonId = SeciliRezervasyonID();
            if (rezervasyonId == null)
            {
                MessageBox.Show("Lütfen iptal edilecek rezervasyonu seçin.");
                return;
            }

            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Rezervasyonlar SET Aktif = 0 WHERE RezervasyonID = @id", conn);
                cmd.Parameters.AddWithValue("@id", rezervasyonId);
                cmd.ExecuteNonQuery();
            }
            RezervasyonlariYukle();
        }

        private void DgvRezervasyonlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.CurrentRow != null)
            {
                var baslik = dgvRezervasyonlar.CurrentRow.Cells["EvBaslik"].Value?.ToString();
                var kiraci = dgvRezervasyonlar.CurrentRow.Cells["KiraciAdi"].Value?.ToString();
                var tarih = dgvRezervasyonlar.CurrentRow.Cells["BaslangicTarihi"].Value?.ToString();
                lblSeciliRezervasyon.Text = $"Seçili Rezervasyon: Ev: {baslik}, Kiracı: {kiraci}, Başlangıç: {tarih}";
            }
            else
            {
                lblSeciliRezervasyon.Text = "Seçili rezervasyon yok.";
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.DataSource is DataTable dt)
            {
                string filter = $"EvBaslik LIKE '%{txtAra.Text}%' OR KiraciAdi LIKE '%{txtAra.Text}%'";
                dt.DefaultView.RowFilter = filter;
            }
        }
    }
}
