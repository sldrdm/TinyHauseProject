namespace TinyHauseProject.Forms.EvSahibi
{
    partial class EvDuzenleForm
    {
        private System.ComponentModel.IContainer components = null;

        // === Form Elemanları ===
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtKonum;
        private System.Windows.Forms.TextBox txtFotoUrl;
        private System.Windows.Forms.CheckBox chkAktifMi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblMesaj;

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.Label lblFotoUrl;
        private System.Windows.Forms.Label lblAktif;

        /// <summary>
        /// Temizleme işlemleri
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Form bileşenleri tanımı
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtKonum = new System.Windows.Forms.TextBox();
            this.txtFotoUrl = new System.Windows.Forms.TextBox();
            this.chkAktifMi = new System.Windows.Forms.CheckBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKonum = new System.Windows.Forms.Label();
            this.lblFotoUrl = new System.Windows.Forms.Label();
            this.lblAktif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(120, 20);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(280, 22);
            this.txtBaslik.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 60);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(280, 22);
            this.txtAciklama.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(120, 100);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(280, 22);
            this.txtFiyat.TabIndex = 5;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnGuncelle_Click);
            // 
            // txtKonum
            // 
            this.txtKonum.Location = new System.Drawing.Point(120, 140);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.Size = new System.Drawing.Size(280, 22);
            this.txtKonum.TabIndex = 7;
            // 
            // txtFotoUrl
            // 
            this.txtFotoUrl.Location = new System.Drawing.Point(120, 180);
            this.txtFotoUrl.Multiline = true;
            this.txtFotoUrl.Name = "txtFotoUrl";
            this.txtFotoUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFotoUrl.Size = new System.Drawing.Size(280, 60);
            this.txtFotoUrl.TabIndex = 9;
            // 
            // chkAktifMi
            // 
            this.chkAktifMi.Location = new System.Drawing.Point(120, 260);
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Size = new System.Drawing.Size(104, 24);
            this.chkAktifMi.TabIndex = 11;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(120, 300);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 30);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.ForeColor = System.Drawing.Color.Green;
            this.lblMesaj.Location = new System.Drawing.Point(120, 350);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(280, 40);
            this.lblMesaj.TabIndex = 13;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(100, 23);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Başlık:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Location = new System.Drawing.Point(20, 60);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(100, 23);
            this.lblAciklama.TabIndex = 2;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.Location = new System.Drawing.Point(20, 100);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(100, 23);
            this.lblFiyat.TabIndex = 4;
            this.lblFiyat.Text = "Fiyat (₺):";
            // 
            // lblKonum
            // 
            this.lblKonum.Location = new System.Drawing.Point(20, 140);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(100, 23);
            this.lblKonum.TabIndex = 6;
            this.lblKonum.Text = "Konum:";
            // 
            // lblFotoUrl
            // 
            this.lblFotoUrl.Location = new System.Drawing.Point(20, 180);
            this.lblFotoUrl.Name = "lblFotoUrl";
            this.lblFotoUrl.Size = new System.Drawing.Size(100, 23);
            this.lblFotoUrl.TabIndex = 8;
            this.lblFotoUrl.Text = "Foto URL (JSON):";
            // 
            // lblAktif
            // 
            this.lblAktif.Location = new System.Drawing.Point(20, 260);
            this.lblAktif.Name = "lblAktif";
            this.lblAktif.Size = new System.Drawing.Size(100, 23);
            this.lblAktif.TabIndex = 10;
            this.lblAktif.Text = "Aktif mi?";
            // 
            // EvDuzenleForm
            // 
            this.ClientSize = new System.Drawing.Size(685, 480);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblKonum);
            this.Controls.Add(this.txtKonum);
            this.Controls.Add(this.lblFotoUrl);
            this.Controls.Add(this.txtFotoUrl);
            this.Controls.Add(this.lblAktif);
            this.Controls.Add(this.chkAktifMi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblMesaj);
            this.Name = "EvDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ev Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
