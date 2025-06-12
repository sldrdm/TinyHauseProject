namespace TinyHauseProject.Forms.EvSahibi
{
    partial class YorumlarForm
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.cmbEvSecimi = new System.Windows.Forms.ComboBox();
            this.dgvYorumlar = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnCevapYaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYorumlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblBaslik.Location = new System.Drawing.Point(328, 24);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(129, 32);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Yorumlar";
            // 
            // cmbEvSecimi
            // 
            this.cmbEvSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEvSecimi.FormattingEnabled = true;
            this.cmbEvSecimi.Location = new System.Drawing.Point(23, 79);
            this.cmbEvSecimi.Name = "cmbEvSecimi";
            this.cmbEvSecimi.Size = new System.Drawing.Size(380, 33);
            this.cmbEvSecimi.TabIndex = 1;
            this.cmbEvSecimi.SelectedIndexChanged += new System.EventHandler(this.cmbEvSecimi_SelectedIndexChanged);
            // 
            // dgvYorumlar
            // 
            this.dgvYorumlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYorumlar.Location = new System.Drawing.Point(12, 134);
            this.dgvYorumlar.Name = "dgvYorumlar";
            this.dgvYorumlar.RowHeadersWidth = 51;
            this.dgvYorumlar.RowTemplate.Height = 24;
            this.dgvYorumlar.Size = new System.Drawing.Size(838, 368);
            this.dgvYorumlar.TabIndex = 2;
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnYenile.Location = new System.Drawing.Point(409, 72);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(120, 40);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnCevapYaz
            // 
            this.btnCevapYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCevapYaz.Location = new System.Drawing.Point(700, 74);
            this.btnCevapYaz.Name = "btnCevapYaz";
            this.btnCevapYaz.Size = new System.Drawing.Size(150, 40);
            this.btnCevapYaz.TabIndex = 4;
            this.btnCevapYaz.Text = "Cevap Yaz";
            this.btnCevapYaz.UseVisualStyleBackColor = true;
            this.btnCevapYaz.Click += new System.EventHandler(this.btnCevapYaz_Click);
            // 
            // YorumlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 524);
            this.Controls.Add(this.btnCevapYaz);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dgvYorumlar);
            this.Controls.Add(this.cmbEvSecimi);
            this.Controls.Add(this.lblBaslik);
            this.Name = "YorumlarForm";
            this.Text = "Yorumlar";
            this.Load += new System.EventHandler(this.YorumlarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYorumlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Fields (En alta yaz)
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.ComboBox cmbEvSecimi;
        private System.Windows.Forms.DataGridView dgvYorumlar;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnCevapYaz;
    }
}
