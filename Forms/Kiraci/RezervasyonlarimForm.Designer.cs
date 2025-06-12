using System.Windows.Forms;

namespace TinyHauseProject.Forms.Kiraci
{
    partial class RezervasyonlarimForm
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
            this.dgvRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYorumYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(217, 32);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Rezervasyonlarım";
            // 
            // dgvRezervasyonlar
            // 
            this.dgvRezervasyonlar.AllowUserToAddRows = false;
            this.dgvRezervasyonlar.AllowUserToDeleteRows = false;
            this.dgvRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervasyonlar.Location = new System.Drawing.Point(20, 60);
            this.dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            this.dgvRezervasyonlar.ReadOnly = true;
            this.dgvRezervasyonlar.RowHeadersWidth = 51;
            this.dgvRezervasyonlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervasyonlar.Size = new System.Drawing.Size(750, 250);
            this.dgvRezervasyonlar.TabIndex = 1;
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.Location = new System.Drawing.Point(20, 330);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(120, 30);
            this.btnIptalEt.TabIndex = 2;
            this.btnIptalEt.Text = "İptal Et";
            this.btnIptalEt.UseVisualStyleBackColor = true;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(150, 330);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(120, 30);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(20, 370);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 16);
            this.lblMesaj.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
        

            // btnYorumYap
            this.btnYorumYap = new System.Windows.Forms.Button();
            this.btnYorumYap.Location = new System.Drawing.Point(280, 330);
            this.btnYorumYap.Name = "btnYorumYap";
            this.btnYorumYap.Size = new System.Drawing.Size(120, 30);
            this.btnYorumYap.TabIndex = 6;
            this.btnYorumYap.Text = "Yorum Yap";
            this.btnYorumYap.UseVisualStyleBackColor = true;
            this.btnYorumYap.Click += new System.EventHandler(this.btnYorumYap_Click);
            this.Controls.Add(this.btnYorumYap);


            

            // 
            // RezervasyonlarimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnYorumYap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dgvRezervasyonlar);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.lblMesaj);
            this.Name = "RezervasyonlarimForm";
            this.Text = "Rezervasyonlarım";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnYorumYap;

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dgvRezervasyonlar;
        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label label1;
       

    }
}
