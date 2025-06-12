

namespace TinyHauseProject.Forms.Admin
{
    partial class IstatistikForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRezervasyon;
        private System.Windows.Forms.Label lblBaslikToplamKullanici;
        private System.Windows.Forms.Label lblBaslikAktifKullanici;
        private System.Windows.Forms.Label lblBaslikYeniUye;
        private System.Windows.Forms.Label lblBaslikToplamRezervasyon;
        private System.Windows.Forms.Label lblBaslikToplamOdeme;
        private System.Windows.Forms.Label lblBaslikToplamYorum;
        private System.Windows.Forms.Label lblToplamKullanici;
        private System.Windows.Forms.Label lblAktifKullanici;
        private System.Windows.Forms.Label lblYeniUye;
        private System.Windows.Forms.Label lblToplamRezervasyon;
        private System.Windows.Forms.Label lblToplamOdeme;
        private System.Windows.Forms.Label lblToplamYorum;
       
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOdeme;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lblBaslikToplamKullanici = new System.Windows.Forms.Label();
            this.lblBaslikAktifKullanici = new System.Windows.Forms.Label();
            this.lblBaslikYeniUye = new System.Windows.Forms.Label();
            this.lblBaslikToplamRezervasyon = new System.Windows.Forms.Label();
            this.lblBaslikToplamOdeme = new System.Windows.Forms.Label();
            this.lblBaslikToplamYorum = new System.Windows.Forms.Label();
            this.lblToplamKullanici = new System.Windows.Forms.Label();
            this.lblAktifKullanici = new System.Windows.Forms.Label();
            this.lblYeniUye = new System.Windows.Forms.Label();
            this.lblToplamRezervasyon = new System.Windows.Forms.Label();
            this.lblToplamOdeme = new System.Windows.Forms.Label();
            this.lblToplamYorum = new System.Windows.Forms.Label();
            this.chartRezervasyon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOdeme = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRezervasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOdeme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslikToplamKullanici
            // 
            this.lblBaslikToplamKullanici.AutoSize = true;
            this.lblBaslikToplamKullanici.Location = new System.Drawing.Point(35, 30);
            this.lblBaslikToplamKullanici.Name = "lblBaslikToplamKullanici";
            this.lblBaslikToplamKullanici.Size = new System.Drawing.Size(109, 16);
            this.lblBaslikToplamKullanici.TabIndex = 0;
            this.lblBaslikToplamKullanici.Text = "Toplam Kullanıcı:";
            // 
            // lblBaslikAktifKullanici
            // 
            this.lblBaslikAktifKullanici.AutoSize = true;
            this.lblBaslikAktifKullanici.Location = new System.Drawing.Point(35, 60);
            this.lblBaslikAktifKullanici.Name = "lblBaslikAktifKullanici";
            this.lblBaslikAktifKullanici.Size = new System.Drawing.Size(87, 16);
            this.lblBaslikAktifKullanici.TabIndex = 1;
            this.lblBaslikAktifKullanici.Text = "Aktif Kullanıcı:";
            // 
            // lblBaslikYeniUye
            // 
            this.lblBaslikYeniUye.AutoSize = true;
            this.lblBaslikYeniUye.Location = new System.Drawing.Point(35, 90);
            this.lblBaslikYeniUye.Name = "lblBaslikYeniUye";
            this.lblBaslikYeniUye.Size = new System.Drawing.Size(106, 16);
            this.lblBaslikYeniUye.TabIndex = 2;
            this.lblBaslikYeniUye.Text = "Son 30 Gün Üye:";
            // 
            // lblBaslikToplamRezervasyon
            // 
            this.lblBaslikToplamRezervasyon.AutoSize = true;
            this.lblBaslikToplamRezervasyon.Location = new System.Drawing.Point(270, 30);
            this.lblBaslikToplamRezervasyon.Name = "lblBaslikToplamRezervasyon";
            this.lblBaslikToplamRezervasyon.Size = new System.Drawing.Size(140, 16);
            this.lblBaslikToplamRezervasyon.TabIndex = 3;
            this.lblBaslikToplamRezervasyon.Text = "Toplam Rezervasyon:";
            // 
            // lblBaslikToplamOdeme
            // 
            this.lblBaslikToplamOdeme.AutoSize = true;
            this.lblBaslikToplamOdeme.Location = new System.Drawing.Point(270, 60);
            this.lblBaslikToplamOdeme.Name = "lblBaslikToplamOdeme";
            this.lblBaslikToplamOdeme.Size = new System.Drawing.Size(105, 16);
            this.lblBaslikToplamOdeme.TabIndex = 4;
            this.lblBaslikToplamOdeme.Text = "Toplam Ödeme:";
            // 
            // lblBaslikToplamYorum
            // 
            this.lblBaslikToplamYorum.AutoSize = true;
            this.lblBaslikToplamYorum.Location = new System.Drawing.Point(270, 90);
            this.lblBaslikToplamYorum.Name = "lblBaslikToplamYorum";
            this.lblBaslikToplamYorum.Size = new System.Drawing.Size(99, 16);
            this.lblBaslikToplamYorum.TabIndex = 5;
            this.lblBaslikToplamYorum.Text = "Toplam Yorum:";
            // 
            // lblToplamKullanici
            // 
            this.lblToplamKullanici.AutoSize = true;
            this.lblToplamKullanici.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamKullanici.Location = new System.Drawing.Point(160, 30);
            this.lblToplamKullanici.Name = "lblToplamKullanici";
            this.lblToplamKullanici.Size = new System.Drawing.Size(20, 23);
            this.lblToplamKullanici.TabIndex = 6;
            this.lblToplamKullanici.Text = "0";
            // 
            // lblAktifKullanici
            // 
            this.lblAktifKullanici.AutoSize = true;
            this.lblAktifKullanici.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAktifKullanici.Location = new System.Drawing.Point(160, 60);
            this.lblAktifKullanici.Name = "lblAktifKullanici";
            this.lblAktifKullanici.Size = new System.Drawing.Size(20, 23);
            this.lblAktifKullanici.TabIndex = 7;
            this.lblAktifKullanici.Text = "0";
            // 
            // lblYeniUye
            // 
            this.lblYeniUye.AutoSize = true;
            this.lblYeniUye.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYeniUye.Location = new System.Drawing.Point(160, 90);
            this.lblYeniUye.Name = "lblYeniUye";
            this.lblYeniUye.Size = new System.Drawing.Size(20, 23);
            this.lblYeniUye.TabIndex = 8;
            this.lblYeniUye.Text = "0";
            // 
            // lblToplamRezervasyon
            // 
            this.lblToplamRezervasyon.AutoSize = true;
            this.lblToplamRezervasyon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamRezervasyon.Location = new System.Drawing.Point(420, 30);
            this.lblToplamRezervasyon.Name = "lblToplamRezervasyon";
            this.lblToplamRezervasyon.Size = new System.Drawing.Size(20, 23);
            this.lblToplamRezervasyon.TabIndex = 9;
            this.lblToplamRezervasyon.Text = "0";
            // 
            // lblToplamOdeme
            // 
            this.lblToplamOdeme.AutoSize = true;
            this.lblToplamOdeme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamOdeme.Location = new System.Drawing.Point(420, 60);
            this.lblToplamOdeme.Name = "lblToplamOdeme";
            this.lblToplamOdeme.Size = new System.Drawing.Size(20, 23);
            this.lblToplamOdeme.TabIndex = 10;
            this.lblToplamOdeme.Text = "0";
            // 
            // lblToplamYorum
            // 
            this.lblToplamYorum.AutoSize = true;
            this.lblToplamYorum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamYorum.Location = new System.Drawing.Point(420, 90);
            this.lblToplamYorum.Name = "lblToplamYorum";
            this.lblToplamYorum.Size = new System.Drawing.Size(20, 23);
            this.lblToplamYorum.TabIndex = 11;
            this.lblToplamYorum.Text = "0";
            // 
            // chartRezervasyon
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRezervasyon.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRezervasyon.Legends.Add(legend1);
            this.chartRezervasyon.Location = new System.Drawing.Point(38, 189);
            this.chartRezervasyon.Name = "chartRezervasyon";
            this.chartRezervasyon.Size = new System.Drawing.Size(430, 300);
            this.chartRezervasyon.TabIndex = 12;
            this.chartRezervasyon.Text = "Rezervasyon Grafik";
            // 
            // chartOdeme
            // 
            chartArea2.Name = "ChartArea1";
            this.chartOdeme.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartOdeme.Legends.Add(legend2);
            this.chartOdeme.Location = new System.Drawing.Point(514, 189);
            this.chartOdeme.Name = "chartOdeme";
            this.chartOdeme.Size = new System.Drawing.Size(430, 300);
            this.chartOdeme.TabIndex = 13;
            this.chartOdeme.Text = "Ödeme Grafik";
            // 
            // IstatistikForm
            // 
            this.ClientSize = new System.Drawing.Size(1010, 548);
            this.Controls.Add(this.lblBaslikToplamKullanici);
            this.Controls.Add(this.lblBaslikAktifKullanici);
            this.Controls.Add(this.lblBaslikYeniUye);
            this.Controls.Add(this.lblBaslikToplamRezervasyon);
            this.Controls.Add(this.lblBaslikToplamOdeme);
            this.Controls.Add(this.lblBaslikToplamYorum);
            this.Controls.Add(this.lblToplamKullanici);
            this.Controls.Add(this.lblAktifKullanici);
            this.Controls.Add(this.lblYeniUye);
            this.Controls.Add(this.lblToplamRezervasyon);
            this.Controls.Add(this.lblToplamOdeme);
            this.Controls.Add(this.lblToplamYorum);
            this.Controls.Add(this.chartRezervasyon);
            this.Controls.Add(this.chartOdeme);
            this.Name = "IstatistikForm";
            this.Text = "İstatistik ve Raporlama";
            this.Load += new System.EventHandler(this.IstatistikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRezervasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOdeme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
    }
}
