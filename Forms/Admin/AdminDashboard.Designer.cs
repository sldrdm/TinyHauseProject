namespace TinyHauseProject.Forms.Admin
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvIlanlar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.btnKullaniciYonetimi = new System.Windows.Forms.Button();
            this.btnRezervasyonYonetimi = new System.Windows.Forms.Button();
            this.btnIlanYonetimi = new System.Windows.Forms.Button();
            this.btnOdemeRaporlari = new System.Windows.Forms.Button();
            this.btnIstatistikler = new System.Windows.Forms.Button();
            this.lblOzet = new System.Windows.Forms.Label();
            this.dgvIlanlar = new System.Windows.Forms.DataGridView();

            this.SuspendLayout();

            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.Text = "Hoş Geldiniz, Admin!";
            this.lblHosgeldin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHosgeldin.Location = new System.Drawing.Point(30, 20);
            this.lblHosgeldin.Size = new System.Drawing.Size(400, 30);

            // 
            // lblOzet
            // 
            this.lblOzet.Text = "Sistem Özeti: 25 kullanıcı, 8 ilan, 14 rezervasyon";
            this.lblOzet.Location = new System.Drawing.Point(30, 60);
            this.lblOzet.Size = new System.Drawing.Size(400, 25);

            // 
            // btnKullaniciYonetimi
            // 
            this.btnKullaniciYonetimi.Text = "Kullanıcı Yönetimi";
            this.btnKullaniciYonetimi.Location = new System.Drawing.Point(30, 110);
            this.btnKullaniciYonetimi.Size = new System.Drawing.Size(200, 40);
            this.btnKullaniciYonetimi.Click += new System.EventHandler(this.btnKullaniciYonetimi_Click);

            // 
            // btnRezervasyonYonetimi
            // 
            this.btnRezervasyonYonetimi.Text = "Rezervasyon Yönetimi";
            this.btnRezervasyonYonetimi.Location = new System.Drawing.Point(30, 160);
            this.btnRezervasyonYonetimi.Size = new System.Drawing.Size(200, 40);
            this.btnRezervasyonYonetimi.Click += new System.EventHandler(this.btnRezervasyonYonetimi_Click);

            // 
            // btnIlanYonetimi
            // 
            this.btnIlanYonetimi.Text = "İlan Yönetimi";
            this.btnIlanYonetimi.Location = new System.Drawing.Point(30, 210);
            this.btnIlanYonetimi.Size = new System.Drawing.Size(200, 40);
            this.btnIlanYonetimi.Click += new System.EventHandler(this.btnIlanYonetimi_Click);

            // 
            // btnOdemeRaporlari
            // 
            this.btnOdemeRaporlari.Text = "Ödeme Raporları";
            this.btnOdemeRaporlari.Location = new System.Drawing.Point(30, 260);
            this.btnOdemeRaporlari.Size = new System.Drawing.Size(200, 40);
            this.btnOdemeRaporlari.Click += new System.EventHandler(this.btnOdemeRaporlari_Click);

            // 
            // btnIstatistikler
            // 
            this.btnIstatistikler.Text = "İstatistikler";
            this.btnIstatistikler.Location = new System.Drawing.Point(30, 310);
            this.btnIstatistikler.Size = new System.Drawing.Size(200, 40);
            this.btnIstatistikler.Click += new System.EventHandler(this.btnIstatistikler_Click);

            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.lblHosgeldin);
            this.Controls.Add(this.lblOzet);
            this.Controls.Add(this.btnKullaniciYonetimi);
            this.Controls.Add(this.btnRezervasyonYonetimi);
            this.Controls.Add(this.btnIlanYonetimi);
            this.Controls.Add(this.btnOdemeRaporlari);
            this.Controls.Add(this.btnIstatistikler);
            this.Controls.Add(this.dgvIlanlar);

          this.Name = "AdminDashboard";
            this.Text = "Admin Paneli";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Label lblOzet;
        private System.Windows.Forms.Button btnKullaniciYonetimi;
        private System.Windows.Forms.Button btnRezervasyonYonetimi;
        private System.Windows.Forms.Button btnIlanYonetimi;
        private System.Windows.Forms.Button btnOdemeRaporlari;
        private System.Windows.Forms.Button btnIstatistikler;
    }
}
