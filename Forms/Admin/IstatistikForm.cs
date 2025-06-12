using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;

using System.Windows.Forms.DataVisualization.Charting;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Admin
{
    public partial class IstatistikForm : Form
    {
        public IstatistikForm()
        {
            InitializeComponent();
        }

        private void IstatistikForm_Load(object sender, EventArgs e)
        {
            GenelIstatistikleriGetir();
            RezervasyonTrendGrafik();
            OdemeTrendGrafik();
        }

        private void GenelIstatistikleriGetir()
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                // Toplam Kullanıcı
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Kullanicilar", conn))
                    lblToplamKullanici.Text = cmd.ExecuteScalar().ToString();

                // Aktif Kullanıcı
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Kullanicilar WHERE Aktif = 1", conn))
                    lblAktifKullanici.Text = cmd.ExecuteScalar().ToString();

                // Son 30 gün yeni üye
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Kullanicilar WHERE KayitTarihi >= DATEADD(DAY, -30, GETDATE())", conn))
                    lblYeniUye.Text = cmd.ExecuteScalar().ToString();

                // Toplam Rezervasyon
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Rezervasyonlar", conn))
                    lblToplamRezervasyon.Text = cmd.ExecuteScalar().ToString();

                // Toplam Ödeme
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Odemeler", conn))
                    lblToplamOdeme.Text = cmd.ExecuteScalar().ToString();

                // Toplam Yorum
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Yorumlar", conn))
                    lblToplamYorum.Text = cmd.ExecuteScalar().ToString();
            }
        }

        private void RezervasyonTrendGrafik()
        {
            chartRezervasyon.Series.Clear();
            Series seri = new Series("Rezervasyonlar")
            {
                ChartType = SeriesChartType.Column
            };

            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                string sorgu = @"
                    SELECT FORMAT(BaslangicTarihi, 'yyyy-MM') AS Ay, COUNT(*) AS Sayi
                    FROM Rezervasyonlar
                    WHERE BaslangicTarihi >= DATEADD(MONTH, -11, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))
                    GROUP BY FORMAT(BaslangicTarihi, 'yyyy-MM')
                    ORDER BY Ay";
                using (SqlCommand cmd = new SqlCommand(sorgu, conn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        seri.Points.AddXY(dr["Ay"].ToString(), Convert.ToInt32(dr["Sayi"]));
                    }
                }
            }
            chartRezervasyon.Series.Add(seri);
            chartRezervasyon.ChartAreas[0].AxisX.Title = "Ay";
            chartRezervasyon.ChartAreas[0].AxisY.Title = "Rezervasyon Sayısı";
        }

        private void OdemeTrendGrafik()
        {
            chartOdeme.Series.Clear();
            Series seri = new Series("Ödemeler")
            {
                ChartType = SeriesChartType.Column
            };

            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                string sorgu = @"
                    SELECT FORMAT(OdemeTarihi, 'yyyy-MM') AS Ay, COUNT(*) AS Sayi
                    FROM Odemeler
                    WHERE OdemeTarihi >= DATEADD(MONTH, -11, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))
                    GROUP BY FORMAT(OdemeTarihi, 'yyyy-MM')
                    ORDER BY Ay";
                using (SqlCommand cmd = new SqlCommand(sorgu, conn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        seri.Points.AddXY(dr["Ay"].ToString(), Convert.ToInt32(dr["Sayi"]));
                    }
                }
            }
            chartOdeme.Series.Add(seri);
            chartOdeme.ChartAreas[0].AxisX.Title = "Ay";
            chartOdeme.ChartAreas[0].AxisY.Title = "Ödeme Sayısı";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
