using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config; // Veritabani.cs burada olmalı

namespace TinyHauseProject.Forms.EvSahibi
{
    public partial class EvEkleForm : Form
    {
        private int aktifEvSahibiID;

        public EvEkleForm(int evSahibiID)
        {
            InitializeComponent();
            this.aktifEvSahibiID = evSahibiID;

            // Event'leri bağla
            btnKaydet.Click += new EventHandler(this.btnKaydet_Click);
            txtFiyat.KeyPress += new KeyPressEventHandler(this.txtFiyat_KeyPress);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBaslik.Text) ||
                    string.IsNullOrWhiteSpace(txtAciklama.Text) ||
                    string.IsNullOrWhiteSpace(txtFiyat.Text) ||
                    string.IsNullOrWhiteSpace(txtKonum.Text))
                {
                    lblMesaj.Text = "Lütfen tüm zorunlu alanları doldurun.";
                    return;
                }
                else
                {

                    using (SqlConnection conn = Veritabani.BaglantiGetir())
                    {
                        SqlCommand cmd = new SqlCommand("SP_EvEkle", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@SahipID", aktifEvSahibiID);
                        cmd.Parameters.AddWithValue("@Baslik", txtBaslik.Text.Trim());
                        cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text.Trim());
                        cmd.Parameters.AddWithValue("@Fiyat", decimal.Parse(txtFiyat.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Konum", txtKonum.Text.Trim());

                        if (string.IsNullOrWhiteSpace(txtFotoUrl.Text))
                            cmd.Parameters.AddWithValue("@FotoUrl", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@FotoUrl", txtFotoUrl.Text.Trim());

                        cmd.ExecuteNonQuery();
                        lblMesaj.Text = "Ev başarıyla eklendi.";
                        Temizle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayı ve virgül girilsin
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void Temizle()
        {
            txtBaslik.Text = "";
            txtAciklama.Text = "";
            txtFiyat.Text = "";
            txtKonum.Text = "";
            txtFotoUrl.Text = "";
        }
    }
}
