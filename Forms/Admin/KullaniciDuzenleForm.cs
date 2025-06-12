using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Admin
{
    public partial class KullaniciDuzenleForm : Form
    {
        private int _kullaniciID;

        public KullaniciDuzenleForm(int kullaniciID)
        {
            InitializeComponent();
            _kullaniciID = kullaniciID;
        }

        private void KullaniciDuzenleForm_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Admin");     // 0 → 0 veya 99 ise
            cmbRol.Items.Add("Ev Sahibi"); // 1
            cmbRol.Items.Add("Kiracı");    // 2

            BilgileriGetir();
        }

        private void BilgileriGetir()
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciID = @id", conn);
                cmd.Parameters.AddWithValue("@id", _kullaniciID);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        txtAd.Text = dr["Ad"].ToString();
                        txtSoyad.Text = dr["Soyad"].ToString();
                        txtEmail.Text = dr["Email"].ToString();
                        txtSifre.Text = dr["Sifre"].ToString(); // güvenlik için hashlenmişse gösterme!
                        int rol = Convert.ToInt32(dr["Rol"]);
                        cmbRol.SelectedIndex = rol == 1 ? 1 : rol == 2 ? 2 : 0;
                        chkAktif.Checked = Convert.ToBoolean(dr["Aktif"]);
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            int rol = cmbRol.SelectedIndex == 1 ? 1 : cmbRol.SelectedIndex == 2 ? 2 : 0;
            bool aktif = chkAktif.Checked;

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(sifre) || cmbRol.SelectedIndex == -1)
            {
                lblMesaj.Text = "Lütfen tüm alanları doldurun.";
                lblMesaj.Visible = true;
                return;
            }

            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Kullanicilar SET Ad=@ad, Soyad=@soyad, Email=@email, Sifre=@sifre, Rol=@rol, Aktif=@aktif WHERE KullaniciID=@id", conn);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@aktif", aktif);
                cmd.Parameters.AddWithValue("@id", _kullaniciID);

                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                    this.Close();
                }
                else
                {
                    lblMesaj.Text = "Güncelleme başarısız.";
                    lblMesaj.Visible = true;
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
