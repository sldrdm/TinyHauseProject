namespace TinyHauseProject.Forms.Kiraci
{
    partial class RezervasyonYapForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblEvBilgisi = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBaslik.Location = new System.Drawing.Point(30, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(200, 29);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Rezervasyon Yap";
            // 
            // lblEvBilgisi
            // 
            this.lblEvBilgisi.AutoSize = true;
            this.lblEvBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEvBilgisi.Location = new System.Drawing.Point(30, 60);
            this.lblEvBilgisi.Name = "lblEvBilgisi";
            this.lblEvBilgisi.Size = new System.Drawing.Size(176, 20);
            this.lblEvBilgisi.TabIndex = 1;
            this.lblEvBilgisi.Text = "Seçilen ev: [Ev Bilgisi]";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(160, 95);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dtpBaslangic.TabIndex = 3;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(160, 135);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 22);
            this.dtpBitis.TabIndex = 5;
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(30, 100);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(104, 16);
            this.lblBaslangic.TabIndex = 2;
            this.lblBaslangic.Text = "Başlangıç Tarihi";
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(30, 140);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(69, 16);
            this.lblBitis.TabIndex = 4;
            this.lblBitis.Text = "Bitiş Tarihi";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(30, 180);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(120, 30);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Tutar Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTutar.Location = new System.Drawing.Point(170, 185);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(98, 20);
            this.lblTutar.TabIndex = 7;
            this.lblTutar.Text = "Tutar: ₺0.00";
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.Location = new System.Drawing.Point(30, 230);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(330, 40);
            this.btnRezervasyonYap.TabIndex = 8;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = true;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // RezervasyonYapForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblEvBilgisi);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Name = "RezervasyonYapForm";
            this.Text = "Rezervasyon Yap";
            this.Load += new System.EventHandler(this.RezervasyonYapForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblEvBilgisi;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnRezervasyonYap;
    }
}
