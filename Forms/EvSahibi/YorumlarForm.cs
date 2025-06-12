using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.EvSahibi
{
    public partial class YorumlarForm : Form
    {
        private int sahipId;

        public YorumlarForm(int evSahibiId)
        {
            InitializeComponent();
            sahipId = evSahibiId;
            this.Load += new EventHandler(YorumlarForm_Load);
        }

        private void YorumlarForm_Load(object sender, EventArgs e)
        {
            EvleriYukle();
        }

        private void EvleriYukle()
        {
            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand(@"
                        SELECT EvID, Baslik 
                        FROM Evler 
                        WHERE SahipID = @sahipId", conn);
                    // Dilersen aşağıdaki satırı AddWithValue ile değiştir:
                    // cmd.Parameters.AddWithValue("@sahipId", sahipId);
                    Veritabani.ParametreEkle(cmd, "@sahipId", sahipId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbEvSecimi.DisplayMember = "Baslik";
                    cmbEvSecimi.ValueMember = "EvID";
                    cmbEvSecimi.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ev listesi yüklenemedi: " + ex.Message);
            }
        }

        private void YorumlariYukle()
        {
            if (cmbEvSecimi.SelectedItem == null)
                return;

            int evId = Convert.ToInt32(cmbEvSecimi.SelectedValue);

            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("SP_YorumlariGetir", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    Veritabani.ParametreEkle(cmd, "@EvID", evId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvYorumlar.DataSource = dt;

                    if (dgvYorumlar.Columns.Contains("YorumID"))
                        dgvYorumlar.Columns["YorumID"].Visible = false;
                    if (dgvYorumlar.Columns.Contains("Puan"))
                        dgvYorumlar.Columns["Puan"].HeaderText = "Puan";
                    if (dgvYorumlar.Columns.Contains("Yorum"))
                        dgvYorumlar.Columns["Yorum"].HeaderText = "Yorum";
                    if (dgvYorumlar.Columns.Contains("Ad"))
                        dgvYorumlar.Columns["Ad"].HeaderText = "Ad";
                    if (dgvYorumlar.Columns.Contains("Soyad"))
                        dgvYorumlar.Columns["Soyad"].HeaderText = "Soyad";
                    if (dgvYorumlar.Columns.Contains("Cevap"))
                        dgvYorumlar.Columns["Cevap"].HeaderText = "Ev Sahibi Cevabı";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yorumlar yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            YorumlariYukle();
        }

        private void cmbEvSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            YorumlariYukle();
        }

        private void btnCevapYaz_Click(object sender, EventArgs e)
        {
            if (dgvYorumlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cevaplamak için bir yorum seçin.");
                return;
            }

            var row = dgvYorumlar.SelectedRows[0];
            int yorumID = Convert.ToInt32(row.Cells["YorumID"].Value);
            string yorumMetni = row.Cells["Yorum"].Value?.ToString() ?? "";

            string cevap = Prompt.ShowDialog("Yoruma cevap yazın:", "Yorum Cevapla");

            if (string.IsNullOrWhiteSpace(cevap))
            {
                MessageBox.Show("Cevap boş olamaz.");
                return;
            }

            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Yorumlar SET Cevap = @cevap WHERE YorumID = @yorumID", conn);
                    cmd.Parameters.AddWithValue("@cevap", cevap);
                    cmd.Parameters.AddWithValue("@yorumID", yorumID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cevabınız kaydedildi.");
                    YorumlariYukle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cevap eklenirken hata: " + ex.Message);
            }
        }
    }

    // Prompt dialog tanımı
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent
            };
            Label textLabel = new Label() { Left = 16, Top = 16, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 16, Top = 50, Width = 340 };
            Button confirmation = new Button() { Text = "Tamam", Left = 270, Width = 80, Top = 85, DialogResult = DialogResult.OK };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
