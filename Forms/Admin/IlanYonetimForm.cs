using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Admin
{
    public partial class IlanYonetimForm : Form
    {
        public IlanYonetimForm()
        {
            InitializeComponent();
        }

        private void IlanYonetimForm_Load(object sender, EventArgs e)
        {
            dgvIlanlar.AutoGenerateColumns = false; // Otomatik kolon oluşmasın
            IlanlariYukle();
        }

        private void IlanlariYukle(string filtre = "")
        {
            dgvIlanlar.Rows.Clear();

            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                string sorgu = @"
                    SELECT e.EvID, k.Ad + ' ' + k.Soyad AS EvSahibi, e.Baslik, e.Aciklama, e.Fiyat, e.Konum, 
                           e.Aktif, e.EklenmeTarihi
                    FROM Evler e
                    INNER JOIN Kullanicilar k ON e.SahipID = k.KullaniciID";

                if (!string.IsNullOrWhiteSpace(filtre))
                    sorgu += " WHERE e.Baslik LIKE @filtre";

                using (SqlCommand cmd = new SqlCommand(sorgu, conn))
                {
                    if (!string.IsNullOrWhiteSpace(filtre))
                        Veritabani.ParametreEkle(cmd, "@filtre", $"%{filtre}%");

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgvIlanlar.Rows.Add(
                                dr["EvID"],
                                dr["EvSahibi"],
                                dr["Baslik"],
                                dr["Aciklama"],
                                dr["Fiyat"],
                                dr["Konum"],
                                (bool)dr["Aktif"] ? "Aktif" : "Pasif",
                                Convert.ToDateTime(dr["EklenmeTarihi"]).ToString("dd.MM.yyyy")
                            );
                        }
                    }
                }
            }
        }

        private void txtBaslikAra_TextChanged(object sender, EventArgs e)
        {
            IlanlariYukle(txtBaslikAra.Text.Trim());
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtBaslikAra.Clear();
            IlanlariYukle();
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


        
            private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvIlanlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz ilanı seçiniz.");
                return;
            }

            int evID = Convert.ToInt32(dgvIlanlar.SelectedRows[0].Cells["EvID"].Value);

            // IlanDuzenleForm ekranına geçiş
            IlanDuzenleForm frm = new IlanDuzenleForm(evID); // Form constructor'ı evID almalı
            frm.ShowDialog(); // Modal olarak aç

            // Düzenleme sonrası listeyi yenile
            IlanlariYukle(txtBaslikAra.Text.Trim());
        }

        private void txtBaslikAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IlanlariYukle(txtBaslikAra.Text.Trim());
                e.Handled = true;
                e.SuppressKeyPress = true; // Enter'ın ding sesini engeller
            }
        }

    }
}

