namespace TinyHauseProject.Forms.EvSahibi
{
    partial class Evlerim
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
            this.dgvEvler = new System.Windows.Forms.DataGridView();
            this.EvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EklenmeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnEvEkle = new System.Windows.Forms.Button();
            this.btnDurumDegistir = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvler
            // 
            this.dgvEvler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EvID,
            this.Baslik,
            this.Fiyat,
            this.Konum,
            this.Aktif,
            this.EklenmeTarihi});
            this.dgvEvler.Location = new System.Drawing.Point(25, 133);
            this.dgvEvler.Name = "dgvEvler";
            this.dgvEvler.RowHeadersWidth = 51;
            this.dgvEvler.RowTemplate.Height = 24;
            this.dgvEvler.Size = new System.Drawing.Size(735, 305);
            this.dgvEvler.TabIndex = 0;
            // 
            // EvID
            // 
            this.EvID.HeaderText = "ID";
            this.EvID.MinimumWidth = 6;
            this.EvID.Name = "EvID";
            this.EvID.ReadOnly = true;
            this.EvID.Visible = false;
            this.EvID.Width = 125;
            // 
            // Baslik
            // 
            this.Baslik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Baslik.HeaderText = "Başlık";
            this.Baslik.MinimumWidth = 6;
            this.Baslik.Name = "Baslik";
            this.Baslik.ReadOnly = true;
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            this.Fiyat.Width = 65;
            // 
            // Konum
            // 
            this.Konum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Konum.HeaderText = "Konum";
            this.Konum.MinimumWidth = 6;
            this.Konum.Name = "Konum";
            this.Konum.ReadOnly = true;
            this.Konum.Width = 77;
            // 
            // Aktif
            // 
            this.Aktif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Aktif.HeaderText = "Aktif";
            this.Aktif.MinimumWidth = 6;
            this.Aktif.Name = "Aktif";
            this.Aktif.ReadOnly = true;
            this.Aktif.Width = 75;
            // 
            // EklenmeTarihi
            // 
            this.EklenmeTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EklenmeTarihi.HeaderText = "Eklenme Tarihi";
            this.EklenmeTarihi.MinimumWidth = 6;
            this.EklenmeTarihi.Name = "EklenmeTarihi";
            this.EklenmeTarihi.ReadOnly = true;
            this.EklenmeTarihi.Width = 126;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(346, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(109, 32);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Evlerim";
            // 
            // btnEvEkle
            // 
            this.btnEvEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvEkle.Location = new System.Drawing.Point(37, 46);
            this.btnEvEkle.Name = "btnEvEkle";
            this.btnEvEkle.Size = new System.Drawing.Size(221, 58);
            this.btnEvEkle.TabIndex = 2;
            this.btnEvEkle.Text = "Ev Ekle";
            this.btnEvEkle.UseVisualStyleBackColor = true;
            this.btnEvEkle.Click += new System.EventHandler(this.btnEvEkle_Click);
            // 
            // btnDurumDegistir
            // 
            this.btnDurumDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumDegistir.Location = new System.Drawing.Point(539, 46);
            this.btnDurumDegistir.Name = "btnDurumDegistir";
            this.btnDurumDegistir.Size = new System.Drawing.Size(221, 58);
            this.btnDurumDegistir.TabIndex = 3;
            this.btnDurumDegistir.Text = "Aktif Değiştir (Aktif/Pasif)";
            this.btnDurumDegistir.UseVisualStyleBackColor = true;
            this.btnDurumDegistir.Click += new System.EventHandler(this.btnDurumDegistir_click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(290, 46);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(221, 58);
            this.btnDuzenle.TabIndex = 4;
            this.btnDuzenle.Text = "Ev Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // Evlerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnDurumDegistir);
            this.Controls.Add(this.btnEvEkle);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dgvEvler);
            this.Name = "Evlerim";
            this.Text = "EvlerimForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvler;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnEvEkle;
        private System.Windows.Forms.Button btnDurumDegistir;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktif;
        private System.Windows.Forms.DataGridViewTextBoxColumn EklenmeTarihi;
    }
}