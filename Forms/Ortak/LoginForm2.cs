using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;
using TinyHauseProject.Forms.Kiraci;
using TinyHauseProject.Models;

namespace TinyHauseProject.Forms.Ortak
{
    public partial class LoginForm2 : Form
    {
        public LoginForm2()
        {
            InitializeComponent();

            // Başlangıç ayarları
            lblHataMesaji.Visible = false;
            txtSifre.PasswordChar = '*';

            // Buton olayları
            btnGiris.Click += btnGiris_Click;
            btnKaydol.Click += btnKaydol_Click;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                lblHataMesaji.Text = "Lütfen e-posta ve şifre giriniz.";
                lblHataMesaji.Visible = true;
                return;
            }

            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand(@"
                        SELECT KullaniciID, Rol, Ad FROM Kullanicilar 
                        WHERE Email = @email AND Sifre = @sifre AND Aktif = 1", conn);

                    Veritabani.ParametreEkle(cmd, "@email", email);
                    Veritabani.ParametreEkle(cmd, "@sifre", sifre);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        int rol = Convert.ToInt32(dr["Rol"]);
                        int kullaniciId = Convert.ToInt32(dr["KullaniciID"]);
                        string kullaniciAdi = dr["Ad"].ToString();

                      

                        switch (rol)
                        {
                            case 0:
                               new Admin.AdminDashboard(kullaniciId).Show();
                                break;
                            case 1:
                               new EvSahibi.EvSahibiDashboard(kullaniciId).Show();
                                break;
                            case 2:
                                new Kiraci.KiraciDashboard(kullaniciId,kullaniciAdi).Show();
                                break;
                            default:
                                MessageBox.Show("Geçersiz rol.");
                                this.Show();
                                break;
                        }
                    }
                    else
                    {
                        lblHataMesaji.Text = "E-posta veya şifre hatalı.";
                        lblHataMesaji.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }



   





        private void btnKaydol_Click(object sender, EventArgs e)
        {
            this.Hide();
            var kayitForm = new KayitOlForm();
            kayitForm.ShowDialog();
            this.Show();
        }
    }
}
