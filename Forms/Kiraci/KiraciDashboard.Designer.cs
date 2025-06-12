namespace TinyHauseProject.Forms.Kiraci
{
    partial class KiraciDashboard
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
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.lblToplamRezervasyon = new System.Windows.Forms.Label();
            this.lblAktifRezervasyon = new System.Windows.Forms.Label();
            this.lblIptalEdilen = new System.Windows.Forms.Label();
            this.lblOrtalamaPuan = new System.Windows.Forms.Label();
            this.btnRezervasyonlarim = new System.Windows.Forms.Button();
            this.btnEvAra = new System.Windows.Forms.Button();
            this.btnPopulerEvler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHosgeldin.Location = new System.Drawing.Point(40, 25);
            this.lblHosgeldin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(175, 25);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "Hoş geldiniz, [İsim]";
            // 
            // lblToplamRezervasyon
            // 
            this.lblToplamRezervasyon.AutoSize = true;
            this.lblToplamRezervasyon.Location = new System.Drawing.Point(40, 74);
            this.lblToplamRezervasyon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamRezervasyon.Name = "lblToplamRezervasyon";
            this.lblToplamRezervasyon.Size = new System.Drawing.Size(150, 16);
            this.lblToplamRezervasyon.TabIndex = 1;
            this.lblToplamRezervasyon.Text = "Toplam Rezervasyon: 0";
            // 
            // lblAktifRezervasyon
            // 
            this.lblAktifRezervasyon.AutoSize = true;
            this.lblAktifRezervasyon.Location = new System.Drawing.Point(40, 111);
            this.lblAktifRezervasyon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAktifRezervasyon.Name = "lblAktifRezervasyon";
            this.lblAktifRezervasyon.Size = new System.Drawing.Size(128, 16);
            this.lblAktifRezervasyon.TabIndex = 2;
            this.lblAktifRezervasyon.Text = "Aktif Rezervasyon: 0";
            // 
            // lblIptalEdilen
            // 
            this.lblIptalEdilen.AutoSize = true;
            this.lblIptalEdilen.Location = new System.Drawing.Point(40, 148);
            this.lblIptalEdilen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIptalEdilen.Name = "lblIptalEdilen";
            this.lblIptalEdilen.Size = new System.Drawing.Size(86, 16);
            this.lblIptalEdilen.TabIndex = 3;
            this.lblIptalEdilen.Text = "İptal Edilen: 0";
            // 
            // lblOrtalamaPuan
            // 
            this.lblOrtalamaPuan.AutoSize = true;
            this.lblOrtalamaPuan.Location = new System.Drawing.Point(40, 185);
            this.lblOrtalamaPuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrtalamaPuan.Name = "lblOrtalamaPuan";
            this.lblOrtalamaPuan.Size = new System.Drawing.Size(126, 16);
            this.lblOrtalamaPuan.TabIndex = 4;
            this.lblOrtalamaPuan.Text = "Ortalama Puan: 0.00";
            // 
            // btnRezervasyonlarim
            // 
            this.btnRezervasyonlarim.Location = new System.Drawing.Point(40, 234);
            this.btnRezervasyonlarim.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezervasyonlarim.Name = "btnRezervasyonlarim";
            this.btnRezervasyonlarim.Size = new System.Drawing.Size(200, 37);
            this.btnRezervasyonlarim.TabIndex = 5;
            this.btnRezervasyonlarim.Text = "Rezervasyonlarım";
            this.btnRezervasyonlarim.UseVisualStyleBackColor = true;
            this.btnRezervasyonlarim.Click += new System.EventHandler(this.btnRezervasyonlarim_Click);
            // 
            // btnEvAra
            // 
            this.btnEvAra.Location = new System.Drawing.Point(40, 283);
            this.btnEvAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvAra.Name = "btnEvAra";
            this.btnEvAra.Size = new System.Drawing.Size(200, 37);
            this.btnEvAra.TabIndex = 6;
            this.btnEvAra.Text = "Ev Ara";
            this.btnEvAra.UseVisualStyleBackColor = true;
            this.btnEvAra.Click += new System.EventHandler(this.btnEvAra_Click);
            // 
            // btnPopulerEvler
            // 
            this.btnPopulerEvler.Location = new System.Drawing.Point(43, 336);
            this.btnPopulerEvler.Name = "btnPopulerEvler";
            this.btnPopulerEvler.Size = new System.Drawing.Size(197, 34);
            this.btnPopulerEvler.TabIndex = 3;
            this.btnPopulerEvler.Text = "Popüler Evler";
            this.btnPopulerEvler.UseVisualStyleBackColor = true;
            this.btnPopulerEvler.Click += new System.EventHandler(this.btnPopulerEvler_Click);
            // 
            // KiraciDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 431);
            this.Controls.Add(this.btnPopulerEvler);
            this.Controls.Add(this.lblHosgeldin);
            this.Controls.Add(this.lblToplamRezervasyon);
            this.Controls.Add(this.lblAktifRezervasyon);
            this.Controls.Add(this.lblIptalEdilen);
            this.Controls.Add(this.lblOrtalamaPuan);
            this.Controls.Add(this.btnRezervasyonlarim);
            this.Controls.Add(this.btnEvAra);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KiraciDashboard";
            this.Text = "Kiracı Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Label lblToplamRezervasyon;
        private System.Windows.Forms.Label lblAktifRezervasyon;
        private System.Windows.Forms.Label lblIptalEdilen;
        private System.Windows.Forms.Label lblOrtalamaPuan;
        private System.Windows.Forms.Button btnRezervasyonlarim;
        private System.Windows.Forms.Button btnEvAra;
        private System.Windows.Forms.Button btnPopulerEvler;


    }
}
