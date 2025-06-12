namespace TinyHauseProject.Forms.Admin
{
    partial class RezervasyonYonetimForm
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
            this.dgvRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.RezervasyonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiraci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslangicTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdemeDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbOdemeDurumu = new System.Windows.Forms.ComboBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.btnAktifYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezervasyonlar
            // 
            this.dgvRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervasyonlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervasyonID,
            this.Kiraci,
            this.Ev,
            this.BaslangicTarihi,
            this.BitisTarihi,
            this.Tutar,
            this.OdemeDurumu,
            this.Durum});
            this.dgvRezervasyonlar.Location = new System.Drawing.Point(12, 79);
            this.dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            this.dgvRezervasyonlar.RowHeadersWidth = 51;
            this.dgvRezervasyonlar.RowTemplate.Height = 24;
            this.dgvRezervasyonlar.Size = new System.Drawing.Size(776, 359);
            this.dgvRezervasyonlar.TabIndex = 0;
            this.dgvRezervasyonlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervasyonlar_CellContentClick);
            // 
            // RezervasyonID
            // 
            this.RezervasyonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RezervasyonID.HeaderText = "ID";
            this.RezervasyonID.MinimumWidth = 6;
            this.RezervasyonID.Name = "RezervasyonID";
            this.RezervasyonID.ReadOnly = true;
            this.RezervasyonID.Visible = false;
            this.RezervasyonID.Width = 125;
            // 
            // Kiraci
            // 
            this.Kiraci.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kiraci.HeaderText = "Kiracı";
            this.Kiraci.MinimumWidth = 6;
            this.Kiraci.Name = "Kiraci";
            this.Kiraci.ReadOnly = true;
            // 
            // Ev
            // 
            this.Ev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ev.HeaderText = "Ev";
            this.Ev.MinimumWidth = 6;
            this.Ev.Name = "Ev";
            this.Ev.ReadOnly = true;
            // 
            // BaslangicTarihi
            // 
            this.BaslangicTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BaslangicTarihi.HeaderText = "Başlangıç Tarihi";
            this.BaslangicTarihi.MinimumWidth = 6;
            this.BaslangicTarihi.Name = "BaslangicTarihi";
            this.BaslangicTarihi.ReadOnly = true;
            this.BaslangicTarihi.Width = 122;
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BitisTarihi.HeaderText = "Bitiş Tarihi";
            this.BitisTarihi.MinimumWidth = 6;
            this.BitisTarihi.Name = "BitisTarihi";
            this.BitisTarihi.ReadOnly = true;
            this.BitisTarihi.Width = 91;
            // 
            // Tutar
            // 
            this.Tutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tutar.HeaderText = "Tutar(₺)";
            this.Tutar.MinimumWidth = 6;
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            this.Tutar.Width = 82;
            // 
            // OdemeDurumu
            // 
            this.OdemeDurumu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OdemeDurumu.HeaderText = "\tÖdeme Durumu";
            this.OdemeDurumu.MinimumWidth = 6;
            this.OdemeDurumu.Name = "OdemeDurumu";
            this.OdemeDurumu.ReadOnly = true;
            this.OdemeDurumu.Width = 119;
            // 
            // Durum
            // 
            this.Durum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Durum.HeaderText = "Rezervasyon Durumu";
            this.Durum.MinimumWidth = 6;
            this.Durum.Name = "Durum";
            this.Durum.ReadOnly = true;
            this.Durum.Width = 151;
            // 
            // cmbOdemeDurumu
            // 
            this.cmbOdemeDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeDurumu.FormattingEnabled = true;
            this.cmbOdemeDurumu.Location = new System.Drawing.Point(40, 21);
            this.cmbOdemeDurumu.Name = "cmbOdemeDurumu";
            this.cmbOdemeDurumu.Size = new System.Drawing.Size(216, 24);
            this.cmbOdemeDurumu.TabIndex = 1;
            this.cmbOdemeDurumu.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeDurumu_SelectedIndexChanged);
            this.cmbOdemeDurumu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArama_KeyDown);
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(570, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(218, 54);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Listeyi Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptalEt.Location = new System.Drawing.Point(402, 447);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(322, 42);
            this.btnIptalEt.TabIndex = 3;
            this.btnIptalEt.Text = "Seçili Rezervasyonu İptal";
            this.btnIptalEt.UseVisualStyleBackColor = true;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // btnAktifYap
            // 
            this.btnAktifYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnAktifYap.Location = new System.Drawing.Point(12, 444);
            this.btnAktifYap.Name = "btnAktifYap";
            this.btnAktifYap.Size = new System.Drawing.Size(384, 45);
            this.btnAktifYap.TabIndex = 4;
            this.btnAktifYap.Text = "Seçili Rezervasyonu Aktif Yap";
            this.btnAktifYap.UseVisualStyleBackColor = true;
            this.btnAktifYap.Click += new System.EventHandler(this.btnAktifYap_Click);
            // 
            // RezervasyonYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 543);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.cmbOdemeDurumu);
            this.Controls.Add(this.dgvRezervasyonlar);
            this.Controls.Add(this.btnAktifYap);
            this.Name = "RezervasyonYonetimForm";
            this.Text = "RezervasyonYonetimForm";
            this.Load += new System.EventHandler(this.RezervasyonYonetimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRezervasyonlar;
        private System.Windows.Forms.ComboBox cmbOdemeDurumu;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervasyonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiraci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ev;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslangicTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdemeDurumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.Button btnAktifYap;


    }
}