using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Admin
{
    public partial class IlanDuzenleForm : Form
    {
        private int evID;

        public IlanDuzenleForm(int evID)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.IlanDuzenleForm_Load);

            this.evID = evID;

            this.AcceptButton = btnKaydet;
            this.CancelButton = btnIptal;

         
        }

        private void IlanDuzenleForm_Load(object sender, EventArgs e)
        {
            IlaniGetir(); // Veritabanından verileri çek ve formu doldur
        }


     

        private void IlaniGetir()
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                string sorgu = @"
                    SELECT Baslik, Aciklama, Fiyat, Konum, Aktif 
                    FROM Evler 
                    WHERE EvID = @evID";

                using (SqlCommand cmd = new SqlCommand(sorgu, conn))
                {
                    Veritabani.ParametreEkle(cmd, "@evID", evID);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtBaslik.Text = dr["Baslik"].ToString();
                            txtAciklama.Text = dr["Aciklama"].ToString();
                            txtFiyat.Text = Convert.ToDecimal(dr["Fiyat"]).ToString("0.00");
                            txtKonum.Text = dr["Konum"].ToString();
                            chkAktif.Checked = (bool)dr["Aktif"];
                        }
                        else
                        {
                            MessageBox.Show("İlan bulunamadı.");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {    //// burayı sonradan ekledim
            if (string.IsNullOrWhiteSpace(txtBaslik.Text) ||
    string.IsNullOrWhiteSpace(txtAciklama.Text) ||
    string.IsNullOrWhiteSpace(txtFiyat.Text) ||
    string.IsNullOrWhiteSpace(txtKonum.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                string sorgu = @"
                    UPDATE Evler 
                    SET Baslik = @Baslik,
                        Aciklama = @Aciklama,
                        Fiyat = @Fiyat,
                        Konum = @Konum,
                        Aktif = @Aktif
                    WHERE EvID = @evID";

                using (SqlCommand cmd = new SqlCommand(sorgu, conn))
                {
                    Veritabani.ParametreEkle(cmd, "@Baslik", txtBaslik.Text.Trim());
                    Veritabani.ParametreEkle(cmd, "@Aciklama", txtAciklama.Text.Trim());
                    Veritabani.ParametreEkle(cmd, "@Fiyat", decimal.Parse(txtFiyat.Text.Trim()));
                    Veritabani.ParametreEkle(cmd, "@Konum", txtKonum.Text.Trim());
                    Veritabani.ParametreEkle(cmd, "@Aktif", chkAktif.Checked);
                    Veritabani.ParametreEkle(cmd, "@evID", evID);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("İlan başarıyla güncellendi.");
            this.DialogResult = DialogResult.OK;
            this.Close();

        

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam, virgül ve backspace kabul edilir
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
