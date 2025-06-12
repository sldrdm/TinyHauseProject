using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Kiraci
{
    public partial class EvAraForm : Form
    {
        private int kullaniciID;

        public EvAraForm(int kullaniciID)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
       
           


        }


        private void EvAraForm_Load(object sender, EventArgs e)
        {
          
           EvleriYukle(); // Form yüklendiğinde evleri listele
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            string baslik = txtAra.Text.Trim(); // veya txtBaslikAra.Text.Trim();
            EvleriYukle(baslik);
        }


        private void EvleriYukle(string baslik = "")
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    string query = @"SELECT EvID, Baslik, Fiyat, Konum,
                             CASE WHEN Aktif = 1 THEN 'Aktif' ELSE 'Pasif' END AS AktifText
                             FROM Evler
                             WHERE Aktif = 1";

                    if (!string.IsNullOrWhiteSpace(baslik))
                    {
                        query += " AND Baslik LIKE @Baslik";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrWhiteSpace(baslik))
                    {
                        cmd.Parameters.AddWithValue("@Baslik", "%" + baslik + "%");
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                dgvEvler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Evler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        

        private void dgvEvler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int evID = Convert.ToInt32(dgvEvler.CurrentRow.Cells["EvID"].Value);
                MessageBox.Show($"Seçilen Ev ID: {evID}\nBurada detay formu açılabilir.");
                // TODO: EvDetayForm gösterilebilir
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            EvleriYukle();
        }


        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if (dgvEvler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen rezervasyon yapmak için bir ev seçiniz.");
                return;
            }

            var row = dgvEvler.SelectedRows[0];

            int evID = Convert.ToInt32(row.Cells["EvID"].Value);
            string baslik = row.Cells["Baslik"].Value.ToString();
            decimal fiyat = Convert.ToDecimal(row.Cells["Fiyat"].Value);
            string konum = row.Cells["Konum"].Value.ToString();
            string aktif = row.Cells["Aktif"].Value.ToString();

            // RezervasyonYapForm'u aç, bilgileri gönder
            var rezervasyonForm = new RezervasyonYapForm(kullaniciID, evID);
            rezervasyonForm.ShowDialog();
        }

    }
}

