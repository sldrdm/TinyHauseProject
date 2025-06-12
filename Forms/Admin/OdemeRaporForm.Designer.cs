namespace TinyHauseProject.Forms.Admin
{
    partial class OdemeRaporForm
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
            this.dgvOdemeler = new System.Windows.Forms.DataGridView();
            this.cmbOdemeDurumu = new System.Windows.Forms.ComboBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdemeler
            // 
            this.dgvOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeler.Location = new System.Drawing.Point(71, 166);
            this.dgvOdemeler.Name = "dgvOdemeler";
            this.dgvOdemeler.RowHeadersWidth = 51;
            this.dgvOdemeler.RowTemplate.Height = 24;
            this.dgvOdemeler.Size = new System.Drawing.Size(816, 369);
            this.dgvOdemeler.TabIndex = 0;
            // 
            // cmbOdemeDurumu
            // 
            this.cmbOdemeDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeDurumu.FormattingEnabled = true;
           
            this.cmbOdemeDurumu.Location = new System.Drawing.Point(44, 61);
            this.cmbOdemeDurumu.Name = "cmbOdemeDurumu";
            this.cmbOdemeDurumu.Size = new System.Drawing.Size(175, 37);
            this.cmbOdemeDurumu.TabIndex = 1;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltrele.Location = new System.Drawing.Point(225, 50);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(310, 72);
            this.btnFiltrele.TabIndex = 2;
            this.btnFiltrele.Text = "Filtre uygula";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(558, 50);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(329, 72);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Tüm veriyi yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // OdemeRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 608);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.cmbOdemeDurumu);
            this.Controls.Add(this.dgvOdemeler);
            this.Name = "OdemeRaporForm";
            this.Text = "OdemeRaporForm";
            this.Load += new System.EventHandler(this.OdemeRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdemeler;
        private System.Windows.Forms.ComboBox cmbOdemeDurumu;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdemeID;
   
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktif;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdemeTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdemeDurumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervasyonID;   


    }
}