
namespace TinyHauseProject.Forms.Admin
{
    partial class KullaniciYonetimForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAktifYap = new System.Windows.Forms.Button();
            this.btnPasifYap = new System.Windows.Forms.Button();
            this.btnYeniKullanici = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(25, 100);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.RowHeadersWidth = 51;
            this.dgvKullanicilar.RowTemplate.Height = 24;
            this.dgvKullanicilar.Size = new System.Drawing.Size(888, 354);
            this.dgvKullanicilar.TabIndex = 0;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(25, 25);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(100, 40);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(135, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 40);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAktifYap
            // 
            this.btnAktifYap.Location = new System.Drawing.Point(245, 25);
            this.btnAktifYap.Name = "btnAktifYap";
            this.btnAktifYap.Size = new System.Drawing.Size(100, 40);
            this.btnAktifYap.TabIndex = 5;
            this.btnAktifYap.Text = "Aktif Yap";
            this.btnAktifYap.UseVisualStyleBackColor = true;
            this.btnAktifYap.Click += new System.EventHandler(this.btnAktifYap_Click);
            // 
            // btnPasifYap
            // 
            this.btnPasifYap.Location = new System.Drawing.Point(355, 25);
            this.btnPasifYap.Name = "btnPasifYap";
            this.btnPasifYap.Size = new System.Drawing.Size(100, 40);
            this.btnPasifYap.TabIndex = 4;
            this.btnPasifYap.Text = "Pasif Yap";
            this.btnPasifYap.UseVisualStyleBackColor = true;
            this.btnPasifYap.Click += new System.EventHandler(this.btnPasifYap_Click);
            // 
            // btnYeniKullanici
            // 
            this.btnYeniKullanici.Location = new System.Drawing.Point(465, 25);
            this.btnYeniKullanici.Name = "btnYeniKullanici";
            this.btnYeniKullanici.Size = new System.Drawing.Size(130, 40);
            this.btnYeniKullanici.TabIndex = 3;
            this.btnYeniKullanici.Text = "Yeni Kullanıcı";
            this.btnYeniKullanici.UseVisualStyleBackColor = true;
            this.btnYeniKullanici.Click += new System.EventHandler(this.btnYeniKullanici_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(605, 25);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 40);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(25, 420);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 16);
            this.lblMesaj.TabIndex = 1;
            // 
            // KullaniciYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 499);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYeniKullanici);
            this.Controls.Add(this.btnPasifYap);
            this.Controls.Add(this.btnAktifYap);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dgvKullanicilar);
            this.Name = "KullaniciYonetimForm";
            this.Text = "Kullanıcı Yönetim";
            this.Load += new System.EventHandler(this.KullaniciYonetimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAktifYap;
        private System.Windows.Forms.Button btnPasifYap;
        private System.Windows.Forms.Button btnYeniKullanici;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Label lblMesaj;
    }
}
