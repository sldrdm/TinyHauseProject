namespace TinyHauseProject.Forms.Kiraci
{
    partial class YorumEkleForm
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
            this.lblSeciliEv = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.nudPuan = new System.Windows.Forms.NumericUpDown();
            this.lblYorum = new System.Windows.Forms.Label();
            this.txtYorum = new System.Windows.Forms.TextBox();
            this.btnYorumGonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(20, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(240, 32);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ev Yorum ve Puanla";
            // 
            // lblSeciliEv
            // 
            this.lblSeciliEv.AutoSize = true;
            this.lblSeciliEv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSeciliEv.Location = new System.Drawing.Point(20, 60);
            this.lblSeciliEv.Name = "lblSeciliEv";
            this.lblSeciliEv.Size = new System.Drawing.Size(80, 23);
            this.lblSeciliEv.TabIndex = 1;
            this.lblSeciliEv.Text = "Ev: (yükleniyor)";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(20, 100);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(70, 16);
            this.lblPuan.TabIndex = 2;
            this.lblPuan.Text = "Puan (1-5):";
            // 
            // nudPuan
            // 
            this.nudPuan.Location = new System.Drawing.Point(120, 98);
            this.nudPuan.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudPuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudPuan.Name = "nudPuan";
            this.nudPuan.Size = new System.Drawing.Size(50, 22);
            this.nudPuan.TabIndex = 3;
            this.nudPuan.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblYorum
            // 
            this.lblYorum.AutoSize = true;
            this.lblYorum.Location = new System.Drawing.Point(20, 135);
            this.lblYorum.Name = "lblYorum";
            this.lblYorum.Size = new System.Drawing.Size(76, 16);
            this.lblYorum.TabIndex = 4;
            this.lblYorum.Text = "Yorumunuz:";
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(20, 155);
            this.txtYorum.Multiline = true;
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(320, 80);
            this.txtYorum.TabIndex = 5;
            // 
            // btnYorumGonder
            // 
            this.btnYorumGonder.Location = new System.Drawing.Point(20, 250);
            this.btnYorumGonder.Name = "btnYorumGonder";
            this.btnYorumGonder.Size = new System.Drawing.Size(150, 30);
            this.btnYorumGonder.TabIndex = 6;
            this.btnYorumGonder.Text = "Yorumu Gönder";
            this.btnYorumGonder.UseVisualStyleBackColor = true;
            this.btnYorumGonder.Click += new System.EventHandler(this.btnYorumGonder_Click);
            // 
            // YorumEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 300);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblSeciliEv);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.nudPuan);
            this.Controls.Add(this.lblYorum);
            this.Controls.Add(this.txtYorum);
            this.Controls.Add(this.btnYorumGonder);
            this.Name = "YorumEkleForm";
            this.Text = "Yorum Yap";
            this.Load += new System.EventHandler(this.YorumEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblSeciliEv;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.NumericUpDown nudPuan;
        private System.Windows.Forms.Label lblYorum;
        private System.Windows.Forms.TextBox txtYorum;
        private System.Windows.Forms.Button btnYorumGonder;
    }
}
