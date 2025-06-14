using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Kiraci
{
    public partial class PopulerEvlerForm : Form
    {
        public PopulerEvlerForm()
        {
            InitializeComponent();
        }

        private void PopulerEvlerForm_Load(object sender, EventArgs e)
        {
            PopulerEvleriYukle();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            PopulerEvleriYukle();
        }

        private void PopulerEvleriYukle()
        {
            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    string query = @"
                        SELECT 
                            e.EvID,
                            e.Baslik,
                            e.Konum,
                            e.Fiyat,
                            COALESCE(AVG(y.Puan), 0) AS OrtalamaPuan,
                            COUNT(y.YorumID) AS YorumSayisi
                        FROM Evler e
                        LEFT JOIN Yorumlar y ON e.EvID = y.EvID
                        GROUP BY e.EvID, e.Baslik, e.Konum, e.Fiyat
                        ORDER BY OrtalamaPuan DESC, YorumSayisi DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPopulerEvler.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Popüler evler yüklenirken hata oluştu: " + ex.Message);
            }
        }

    
    }
}
