using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.EvSahibi
{
    public partial class EvDuzenleForm : Form
    {
        private int evID;

        public EvDuzenleForm(int evID)
        {
            InitializeComponent();
            this.evID = evID;

            // Event handler bağlantısı
            btnGuncelle.Click += new EventHandler(this.btnGuncelle_Click);
            txtFiyat.KeyPress += new KeyPressEventHandler(this.txtFiyat_KeyPress);

            // Form yüklenince ev detayları getirilsin
            EvDetaylariniGetir();
        }

        private void EvDetaylariniGetir()
        {
            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("SELECT Baslik, Aciklama, Fiyat, Konum, FotoUrl, Aktif FROM Evler WHERE EvID = @EvID", conn);
                    cmd.Parameters.AddWithValue("@EvID", evID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtBaslik.Text = reader["Baslik"].ToString();
                            txtAciklama.Text = reader["Aciklama"].ToString();
                            txtFiyat.Text = reader["Fiyat"].ToString();
                            txtKonum.Text = reader["Konum"].ToString();
                            txtFotoUrl.Text = reader["FotoUrl"].ToString();
                            chkAktifMi.Checked = Convert.ToBoolean(reader["Aktif"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ev bilgileri alınırken hata oluştu: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBaslik.Text) ||
                    string.IsNullOrWhiteSpace(txtAciklama.Text) ||
                    string.IsNullOrWhiteSpace(txtFiyat.Text) ||
                    string.IsNullOrWhiteSpace(txtKonum.Text))
                {
                    lblMesaj.Text = "Lütfen tüm alanları doldurun.";
                    lblMesaj.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand(@"
                        UPDATE Evler
                        SET Baslik = @Baslik,
                            Aciklama = @Aciklama,
                            Fiyat = @Fiyat,
                            Konum = @Konum,
                            FotoUrl = @FotoUrl,
                            Aktif = @Aktif
                        WHERE EvID = @EvID", conn);

                    cmd.Parameters.AddWithValue("@Baslik", txtBaslik.Text.Trim());
                    cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text.Trim());
                    cmd.Parameters.AddWithValue("@Fiyat", decimal.Parse(txtFiyat.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Konum", txtKonum.Text.Trim());
                    cmd.Parameters.AddWithValue("@FotoUrl", string.IsNullOrWhiteSpace(txtFotoUrl.Text) ? DBNull.Value : (object)txtFotoUrl.Text.Trim());
                    cmd.Parameters.AddWithValue("@Aktif", chkAktifMi.Checked);
                    cmd.Parameters.AddWithValue("@EvID", evID);

                    int etkilenen = cmd.ExecuteNonQuery();
                    if (etkilenen > 0)
                    {
                        lblMesaj.Text = "Ev başarıyla güncellendi.";
                        lblMesaj.ForeColor = System.Drawing.Color.Green;
                        this.DialogResult = DialogResult.OK; // Ana forma geri bildirim
                    }
                    else
                    {
                        lblMesaj.Text = "Güncelleme başarısız.";
                        lblMesaj.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message);
            }
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Yalnızca sayı ve virgül girişine izin ver
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
