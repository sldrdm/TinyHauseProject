using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Admin
{
    public partial class AdminDashboard : Form
    {
        private int kullaniciId;

        public AdminDashboard(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
        }

        private void IlanlariYukle()
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Evler", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                var dt = new System.Data.DataTable();
                dt.Load(dr);

                dgvIlanlar.DataSource = dt;
            }
        }


        private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            new KullaniciYonetimForm().ShowDialog();
        }

        private void btnRezervasyonYonetimi_Click(object sender, EventArgs e)
        {
            new RezervasyonYonetimForm().ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvIlanlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ilanı seçiniz.");
                return;
            }

            int evID = Convert.ToInt32(dgvIlanlar.SelectedRows[0].Cells["EvID"].Value);

            DialogResult result = MessageBox.Show(
                "Bu ilanı pasif hale getirmek istediğinize emin misiniz?\nİlan artık kullanıcılar tarafından görünmeyecektir.",
                "İlan Pasif Hale Getirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Evler SET Aktif = 0 WHERE EvID = @evID", conn);
                    cmd.Parameters.AddWithValue("@evID", evID);
                    cmd.ExecuteNonQuery();
                }

                IlanlariYukle(); // Listeyi yenile
                MessageBox.Show("İlan başarıyla pasif hale getirildi.");
            }
        }


        private void btnOdemeRaporlari_Click(object sender, EventArgs e)
        {
            new OdemeRaporForm().ShowDialog();
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            IstatistikForm istatistikForm = new IstatistikForm();
            istatistikForm.ShowDialog();
        }
        private void btnIlanYonetimi_Click(object sender, EventArgs e)
        {
            new IlanYonetimForm().ShowDialog();
        }
    }
}
