namespace TinyHauseProject.Forms.Admin
{
    partial class IlanYonetimForm
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
            this.dgvIlanlar = new System.Windows.Forms.DataGridView();
            this.EvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvSahibi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EklenmeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.txtBaslikAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIlanlar
            // 
            this.dgvIlanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIlanlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EvID,
            this.EvSahibi,
            this.Baslik,
            this.Aciklama,
            this.Fiyat,
            this.Konum,
            this.Aktif,
            this.EklenmeTarihi});
            this.dgvIlanlar.Location = new System.Drawing.Point(3, 163);
            this.dgvIlanlar.Name = "dgvIlanlar";
            this.dgvIlanlar.RowHeadersWidth = 51;
            this.dgvIlanlar.RowTemplate.Height = 24;
            this.dgvIlanlar.Size = new System.Drawing.Size(937, 438);
            this.dgvIlanlar.TabIndex = 0;
            // 
            // EvID
            // 
            this.EvID.Frozen = true;
            this.EvID.HeaderText = "Ev ID";
            this.EvID.MinimumWidth = 6;
            this.EvID.Name = "EvID";
            this.EvID.Width = 125;
            // 
            // EvSahibi
            // 
            this.EvSahibi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EvSahibi.Frozen = true;
            this.EvSahibi.HeaderText = "Ev Sahibi";
            this.EvSahibi.MinimumWidth = 6;
            this.EvSahibi.Name = "EvSahibi";
            this.EvSahibi.ReadOnly = true;
            this.EvSahibi.Width = 86;
            // 
            // Baslik
            // 
            this.Baslik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Baslik.HeaderText = "Başlık";
            this.Baslik.MinimumWidth = 6;
            this.Baslik.Name = "Baslik";
            // 
            // Aciklama
            // 
            this.Aciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aciklama.HeaderText = "Açiklama";
            this.Aciklama.MinimumWidth = 6;
            this.Aciklama.Name = "Aciklama";
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Width = 65;
            // 
            // Konum
            // 
            this.Konum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Konum.HeaderText = "Konum";
            this.Konum.MinimumWidth = 6;
            this.Konum.Name = "Konum";
            this.Konum.Width = 77;
            // 
            // Aktif
            // 
            this.Aktif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Aktif.HeaderText = "Durum";
            this.Aktif.MinimumWidth = 6;
            this.Aktif.Name = "Aktif";
            this.Aktif.Width = 75;
            // 
            // EklenmeTarihi
            // 
            this.EklenmeTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EklenmeTarihi.HeaderText = "Eklenme Tarihi";
            this.EklenmeTarihi.MinimumWidth = 6;
            this.EklenmeTarihi.Name = "EklenmeTarihi";
            this.EklenmeTarihi.Width = 116;
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(333, 68);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(267, 62);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Listeyi güncelle";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(606, 68);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(310, 62);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Seçilen ilanı sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(28, 68);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(299, 62);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Seçilen ilanı düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // txtBaslikAra
            // 
            this.txtBaslikAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslikAra.Location = new System.Drawing.Point(349, 12);
            this.txtBaslikAra.Name = "txtBaslikAra";
            this.txtBaslikAra.Size = new System.Drawing.Size(312, 30);
            this.txtBaslikAra.TabIndex = 4;
            this.txtBaslikAra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBaslikAra_KeyDown);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAra.Location = new System.Drawing.Point(193, 9);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(150, 32);
            this.lblAra.TabIndex = 5;
            this.lblAra.Text = "Başlık Ara:";
            // 
            // IlanYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 643);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtBaslikAra);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dgvIlanlar);
            this.Name = "IlanYonetimForm";
            this.Text = "IlanYonetimForm";
            this.Load += new System.EventHandler(this.IlanYonetimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIlanlar;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.TextBox txtBaslikAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvSahibi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktif;
        private System.Windows.Forms.DataGridViewTextBoxColumn EklenmeTarihi;

    }
}