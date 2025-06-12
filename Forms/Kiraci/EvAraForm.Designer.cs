namespace TinyHauseProject.Forms.Kiraci
{
    partial class EvAraForm
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dgvEvler = new System.Windows.Forms.DataGridView();
            this.EvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBaslik.Location = new System.Drawing.Point(40, 25);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(190, 29);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ev Ara ve Listele";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(40, 74);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(265, 22);
            this.txtAra.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(320, 71);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 28);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dgvEvler
            // 
            this.dgvEvler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EvID,
            this.Baslik,
            this.Fiyat,
            this.Konum,
            this.Aktif});
            this.dgvEvler.Location = new System.Drawing.Point(40, 116);
            this.dgvEvler.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEvler.Name = "dgvEvler";
            this.dgvEvler.ReadOnly = true;
            this.dgvEvler.RowHeadersWidth = 51;
            this.dgvEvler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvler.Size = new System.Drawing.Size(649, 258);
            this.dgvEvler.TabIndex = 3;
            this.dgvEvler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvler_CellDoubleClick);
            // 
            // EvID
            // 
            this.EvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EvID.DataPropertyName = "EvID";
            this.EvID.HeaderText = "Ev ID";
            this.EvID.MinimumWidth = 6;
            this.EvID.Name = "EvID";
            this.EvID.ReadOnly = true;
            this.EvID.Visible = false;
            this.EvID.Width = 125;
            // 
            // Baslik
            // 
            this.Baslik.DataPropertyName = "Baslik";
            this.Baslik.HeaderText = "Başlık";
            this.Baslik.MinimumWidth = 6;
            this.Baslik.Name = "Baslik";
            this.Baslik.ReadOnly = true;
            this.Baslik.Width = 125;
            // 
            // Fiyat
            // 
            this.Fiyat.DataPropertyName = "Fiyat";
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            this.Fiyat.Width = 125;
            // 
            // Konum
            // 
            this.Konum.DataPropertyName = "Konum";
            this.Konum.HeaderText = "Konum";
            this.Konum.MinimumWidth = 6;
            this.Konum.Name = "Konum";
            this.Konum.ReadOnly = true;
            this.Konum.Width = 125;
            // 
            // Aktif
            // 
            this.Aktif.DataPropertyName = "AktifText";
            this.Aktif.HeaderText = "Aktif";
            this.Aktif.MinimumWidth = 6;
            this.Aktif.Name = "Aktif";
            this.Aktif.ReadOnly = true;
            this.Aktif.Width = 125;
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.Location = new System.Drawing.Point(40, 382);
            this.btnRezervasyonYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(200, 37);
            this.btnRezervasyonYap.TabIndex = 4;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = true;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(484, 71);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(124, 27);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // EvAraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 455);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dgvEvler);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EvAraForm";
            this.Text = "Ev Ara";
            this.Load += new System.EventHandler(this.EvAraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvEvler;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktif;

        private System.Windows.Forms.Button btnYenile;
    }
}
