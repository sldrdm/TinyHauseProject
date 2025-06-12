using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Ortak
{
    public partial class KayitOlForm : Form
    {
        public KayitOlForm()
        {
            InitializeComponent();

            cmbRol.Items.Add("Ev Sahibi"); // 1
            cmbRol.Items.Add("Kiracı");    // 2
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            int rol = cmbRol.SelectedIndex == 0 ? 1 : cmbRol.SelectedIndex == 1 ? 2 : -1;

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(sifre) || rol == -1)
            {
                lblMesaj.Text = "Lütfen tüm alanları doldurun.";
                lblMesaj.Visible = true;
                return;
            }

            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("EXEC SP_YeniKullaniciEkle @Ad, @Soyad, @Email, @Sifre, @Rol", conn);
                    Veritabani.ParametreEkle(cmd, "@Ad", ad);
                    Veritabani.ParametreEkle(cmd, "@Soyad", soyad);
                    Veritabani.ParametreEkle(cmd, "@Email", email);
                    Veritabani.ParametreEkle(cmd, "@Sifre", sifre);
                    Veritabani.ParametreEkle(cmd, "@Rol", rol);

                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.");
                        this.Close();
                    }
                    else
                    {
                        lblMesaj.Text = "Kayıt başarısız.";
                        lblMesaj.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMesaj.Text = "Hata: " + ex.Message;
                lblMesaj.Visible = true;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtEmail.Clear();
            txtSifre.Clear();
            cmbRol.SelectedIndex = -1;
            lblMesaj.Visible = false;
        }
    }
}
