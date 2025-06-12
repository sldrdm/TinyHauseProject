namespace TinyHauseProject.Forms.EvSahibi
{
    partial class RezervasyonlarForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.cmbDurumFiltre = new System.Windows.Forms.ComboBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.lblSeciliRezervasyon = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezervasyonlar
            // 
            this.dgvRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervasyonlar.Location = new System.Drawing.Point(23, 138);
            this.dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            this.dgvRezervasyonlar.RowHeadersWidth = 51;
            this.dgvRezervasyonlar.RowTemplate.Height = 24;
            this.dgvRezervasyonlar.Size = new System.Drawing.Size(860, 330);
            this.dgvRezervasyonlar.TabIndex = 6;
            // 
            // cmbDurumFiltre
            // 
            this.cmbDurumFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurumFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDurumFiltre.FormattingEnabled = true;
            this.cmbDurumFiltre.Items.AddRange(new object[] {
            "Tümü",
            "Aktif",
            "İptal"});
            this.cmbDurumFiltre.Location = new System.Drawing.Point(601, 36);
            this.cmbDurumFiltre.Name = "cmbDurumFiltre";
            this.cmbDurumFiltre.Size = new System.Drawing.Size(232, 33);
            this.cmbDurumFiltre.TabIndex = 1;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblBaslik.Location = new System.Drawing.Point(290, 12);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(241, 32);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Rezervasyonlarım";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOnayla.Location = new System.Drawing.Point(23, 82);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(243, 40);
            this.btnOnayla.TabIndex = 3;
            this.btnOnayla.Text = "Rezervasyonu Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnYenile.Location = new System.Drawing.Point(550, 82);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(248, 40);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Listeyi Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            // 
            // btnReddet
            // 
            this.btnReddet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReddet.Location = new System.Drawing.Point(272, 82);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(272, 40);
            this.btnReddet.TabIndex = 4;
            this.btnReddet.Text = "Rezervasyonu İptal Et";
            this.btnReddet.UseVisualStyleBackColor = true;
            // 
            // lblSeciliRezervasyon
            // 
            this.lblSeciliRezervasyon.AutoSize = true;
            this.lblSeciliRezervasyon.Location = new System.Drawing.Point(20, 440);
            this.lblSeciliRezervasyon.Name = "lblSeciliRezervasyon";
            this.lblSeciliRezervasyon.Size = new System.Drawing.Size(0, 16);
            this.lblSeciliRezervasyon.TabIndex = 7;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(130, 50);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(208, 22);
            this.txtAra.TabIndex = 9;
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(23, 53);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(101, 16);
            this.lblAra.TabIndex = 10;
            this.lblAra.Text = "Ara (Ev / Kiracı):";
            // 
            // RezervasyonlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 470);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.cmbDurumFiltre);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dgvRezervasyonlar);
            this.Controls.Add(this.lblSeciliRezervasyon);
            this.Name = "RezervasyonlarForm";
            this.Text = "Ev Sahibi Rezervasyonlarım";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvRezervasyonlar;
        private System.Windows.Forms.ComboBox cmbDurumFiltre;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Label lblSeciliRezervasyon;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
    }
}
