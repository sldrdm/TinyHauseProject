namespace TinyHauseProject.Forms.Kiraci
{
    partial class PopulerEvlerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dgvPopulerEvler;
        private System.Windows.Forms.Button btnYenile;

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
            this.dgvPopulerEvler = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopulerEvler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(150, 32);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Popüler Evler";
            // 
            // dgvPopulerEvler
            // 
            this.dgvPopulerEvler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopulerEvler.Location = new System.Drawing.Point(20, 60);
            this.dgvPopulerEvler.Name = "dgvPopulerEvler";
            this.dgvPopulerEvler.ReadOnly = true;
            this.dgvPopulerEvler.RowHeadersWidth = 51;
            this.dgvPopulerEvler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopulerEvler.Size = new System.Drawing.Size(600, 250);
            this.dgvPopulerEvler.TabIndex = 1;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(20, 330);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(120, 30);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // PopulerEvlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dgvPopulerEvler);
            this.Controls.Add(this.btnYenile);
            this.Name = "PopulerEvlerForm";
            this.Text = "Popüler Evler";
            this.Load += new System.EventHandler(this.PopulerEvlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopulerEvler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
