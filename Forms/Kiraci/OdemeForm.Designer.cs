namespace TinyHauseProject.Forms.Kiraci
{
    partial class OdemeForm
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
            this.lblEvBilgi = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblKartAdSoyad = new System.Windows.Forms.Label();
            this.txtKartAdSoyad = new System.Windows.Forms.TextBox();
            this.lblKartNo = new System.Windows.Forms.Label();
            this.txtKartNo = new System.Windows.Forms.TextBox();
            this.lblSKT = new System.Windows.Forms.Label();
            this.txtSKT = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(30, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(190, 32);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ödeme Bilgileri";
            // 
            // lblEvBilgi
            // 
            this.lblEvBilgi.AutoSize = true;
            this.lblEvBilgi.Location = new System.Drawing.Point(30, 60);
            this.lblEvBilgi.Name = "lblEvBilgi";
            this.lblEvBilgi.Size = new System.Drawing.Size(92, 16);
            this.lblEvBilgi.TabIndex = 1;
            this.lblEvBilgi.Text = "Ev: [Ev Bilgisi]";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(30, 90);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(59, 16);
            this.lblTutar.TabIndex = 2;
            this.lblTutar.Text = "Tutar (₺):";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(163, 84);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(100, 22);
            this.txtTutar.TabIndex = 3;
            // 
            // lblKartAdSoyad
            // 
            this.lblKartAdSoyad.AutoSize = true;
            this.lblKartAdSoyad.Location = new System.Drawing.Point(30, 130);
            this.lblKartAdSoyad.Name = "lblKartAdSoyad";
            this.lblKartAdSoyad.Size = new System.Drawing.Size(127, 16);
            this.lblKartAdSoyad.TabIndex = 4;
            this.lblKartAdSoyad.Text = "Kart Üzerindeki İsim:";
            // 
            // txtKartAdSoyad
            // 
            this.txtKartAdSoyad.Location = new System.Drawing.Point(163, 127);
            this.txtKartAdSoyad.Name = "txtKartAdSoyad";
            this.txtKartAdSoyad.Size = new System.Drawing.Size(160, 22);
            this.txtKartAdSoyad.TabIndex = 5;
            // 
            // lblKartNo
            // 
            this.lblKartNo.AutoSize = true;
            this.lblKartNo.Location = new System.Drawing.Point(30, 170);
            this.lblKartNo.Name = "lblKartNo";
            this.lblKartNo.Size = new System.Drawing.Size(94, 16);
            this.lblKartNo.TabIndex = 6;
            this.lblKartNo.Text = "Kart Numarası:";
            // 
            // txtKartNo
            // 
            this.txtKartNo.Location = new System.Drawing.Point(163, 167);
            this.txtKartNo.MaxLength = 16;
            this.txtKartNo.Name = "txtKartNo";
            this.txtKartNo.Size = new System.Drawing.Size(160, 22);
            this.txtKartNo.TabIndex = 7;
            // 
            // lblSKT
            // 
            this.lblSKT.AutoSize = true;
            this.lblSKT.Location = new System.Drawing.Point(30, 210);
            this.lblSKT.Name = "lblSKT";
            this.lblSKT.Size = new System.Drawing.Size(91, 16);
            this.lblSKT.TabIndex = 8;
            this.lblSKT.Text = "SKT (MM/YY):";
            // 
            // txtSKT
            // 
            this.txtSKT.Location = new System.Drawing.Point(163, 207);
            this.txtSKT.MaxLength = 5;
            this.txtSKT.Name = "txtSKT";
            this.txtSKT.Size = new System.Drawing.Size(80, 22);
            this.txtSKT.TabIndex = 9;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(30, 250);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(37, 16);
            this.lblCVV.TabIndex = 10;
            this.lblCVV.Text = "CVV:";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(163, 247);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.PasswordChar = '*';
            this.txtCVV.Size = new System.Drawing.Size(80, 22);
            this.txtCVV.TabIndex = 11;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(110, 290);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(209, 56);
            this.btnOdemeYap.TabIndex = 12;
            this.btnOdemeYap.Text = "Ödemeyi Tamamla";
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(30, 360);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 16);
            this.lblMesaj.TabIndex = 13;
            // 
            // OdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblEvBilgi);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblKartAdSoyad);
            this.Controls.Add(this.txtKartAdSoyad);
            this.Controls.Add(this.lblKartNo);
            this.Controls.Add(this.txtKartNo);
            this.Controls.Add(this.lblSKT);
            this.Controls.Add(this.txtSKT);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.lblMesaj);
            this.Name = "OdemeForm";
            this.Text = "Ödeme Ekranı";
            this.Load += new System.EventHandler(this.OdemeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblEvBilgi;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblKartAdSoyad;
        private System.Windows.Forms.TextBox txtKartAdSoyad;
        private System.Windows.Forms.Label lblKartNo;
        private System.Windows.Forms.TextBox txtKartNo;
        private System.Windows.Forms.Label lblSKT;
        private System.Windows.Forms.TextBox txtSKT;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Label lblMesaj;
    }
}
