using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyHauseProject.Config;


namespace TinyHauseProject.Forms.Admin
{
    public partial class KullaniciYonetimForm : Form
    {
        public KullaniciYonetimForm()
        {
            InitializeComponent();
            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                string sorgu = "SELECT KullaniciID, Ad, Soyad, Email, Rol, Aktif FROM Kullanicilar";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKullanicilar.DataSource = dt;
            }
        }

        private int? SeciliKullaniciID()
        {
            if (dgvKullanicilar.SelectedRows.Count > 0)
                return Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells["KullaniciID"].Value);
            return null;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int? seciliID = SeciliKullaniciID();
            if (seciliID == null)
            {
                lblMesaj.Text = "Lütfen bir kullanıcı seçin.";
                return;
            }

            DialogResult sonuc = MessageBox.Show("Kullanıcıyı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Kullanicilar WHERE KullaniciID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", seciliID);
                    cmd.ExecuteNonQuery();
                    lblMesaj.Text = "Kullanıcı silindi.";
                    ListeyiYenile();
                }
            }
        }

        private void btnPasifYap_Click(object sender, EventArgs e)
        {
            DurumGuncelle(false);
        }

        private void btnAktifYap_Click(object sender, EventArgs e)
        {
            DurumGuncelle(true);
        }

        private void DurumGuncelle(bool aktifMi)
        {
            int? seciliID = SeciliKullaniciID();
            if (seciliID == null)
            {
                lblMesaj.Text = "Lütfen bir kullanıcı seçin.";
                return;
            }

            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET Aktif = @aktif WHERE KullaniciID = @id", conn);
                cmd.Parameters.AddWithValue("@aktif", aktifMi);
                cmd.Parameters.AddWithValue("@id", seciliID);
                cmd.ExecuteNonQuery();
                lblMesaj.Text = aktifMi ? "Kullanıcı aktif yapıldı." : "Kullanıcı pasif yapıldı.";
                ListeyiYenile();
            }
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            // KayitOlForm Ortak klasöründe olduğu için namespace'i kullanıyoruz:
            var kayitForm = new TinyHauseProject.Forms.Ortak.KayitOlForm();
            kayitForm.ShowDialog();

            // Kayıt başarılı ise otomatik olarak Close() çağrılır, sonra ana listeyi yenile:
            ListeyiYenile();
        }


        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int? seciliID = SeciliKullaniciID();
            if (seciliID == null)
            {
                lblMesaj.Text = "Lütfen bir kullanıcı seçin.";
                return;
            }

            var frm = new KullaniciDuzenleForm(seciliID.Value);
            frm.ShowDialog();
            ListeyiYenile();
        }

        private void KullaniciYonetimForm_Load(object sender, EventArgs e)
        {

        }
    }
}
