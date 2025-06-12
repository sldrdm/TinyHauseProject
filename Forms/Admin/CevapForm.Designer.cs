namespace TinyHauseProject.Forms.EvSahibi
{
    partial class CevapForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Button btnTamam;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.lblCevap = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(15, 15);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(90, 16);
            this.lblCevap.TabIndex = 0;
            this.lblCevap.Text = "Cevabınızı yazın:";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(18, 35);
            this.txtCevap.Multiline = true;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(300, 80);
            this.txtCevap.TabIndex = 1;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(18, 130);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(90, 30);
            this.btnTamam.TabIndex = 2;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // CevapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 180);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.lblCevap);
            this.Name = "CevapForm";
            this.Text = "Yoruma Cevap Yaz";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
