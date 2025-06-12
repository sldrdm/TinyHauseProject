using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;
using TinyHauseProject.Forms.Admin;

namespace TinyHauseProject.Forms.EvSahibi
{
    public partial class Evlerim : Form
    {
        private int evSahibiID;

        public Evlerim(int evSahibiID)
        {
            InitializeComponent();
            this.evSahibiID = evSahibiID;

            this.Load += Evlerim_Load;
        }

        private void Evlerim_Load(object sender, EventArgs e)
        {
            EvleriYukle();
        }

        private void EvleriYukle()
        {
            try
            {
                dgvEvler.Rows.Clear();
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    string query = @"SELECT EvID, Baslik, Fiyat, Konum, Aktif, EklenmeTarihi 
                                     FROM Evler 
                                     WHERE SahipID = @sahipId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@sahipId", evSahibiID);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dgvEvler.Rows.Add(
                            dr["EvID"],
                            dr["Baslik"],
                            string.Format("{0:C0}", dr["Fiyat"]),
                            dr["Konum"],
                            Convert.ToBoolean(dr["Aktif"]) ? "Aktif" : "Pasif",
                            Convert.ToDateTime(dr["EklenmeTarihi"]).ToString("dd.MM.yyyy")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Evler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnEvEkle_Click(object sender, EventArgs e)
        {
            EvEkleForm form = new EvEkleForm(evSahibiID);
            form.ShowDialog();
            EvleriYukle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvEvler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir ev seçin.");
                return;
            }

            int seciliEvID = Convert.ToInt32(dgvEvler.SelectedRows[0].Cells["EvID"].Value);
            IlanDuzenleForm form = new IlanDuzenleForm(seciliEvID);
            form.ShowDialog();
            EvleriYukle();
        }

        private void btnDurumDegistir_click(object sender, EventArgs e)
        {
            if (dgvEvler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir ev seçin.");
                return;
            }

            int seciliEvID = Convert.ToInt32(dgvEvler.SelectedRows[0].Cells["EvID"].Value);
            string mevcutDurum = dgvEvler.SelectedRows[0].Cells["Aktif"].Value.ToString();
            bool yeniDurum = mevcutDurum != "Aktif";

            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Evler SET Aktif = @aktif WHERE EvID = @evID", conn);
                    cmd.Parameters.AddWithValue("@aktif", yeniDurum);
                    cmd.Parameters.AddWithValue("@evID", seciliEvID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Aktif başarıyla güncellendi.");
                EvleriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aktif güncellenirken hata oluştu: " + ex.Message);
            }
        }
    }
}
