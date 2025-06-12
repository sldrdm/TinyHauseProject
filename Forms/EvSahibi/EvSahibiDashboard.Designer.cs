namespace TinyHauseProject.Forms.EvSahibi
{
    partial class EvSahibiDashboard
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
            this.btnEvlerim = new System.Windows.Forms.Button();
            this.btnRezervasyonlar = new System.Windows.Forms.Button();
            this.btnYorumlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvlerim
            // 
            this.btnEvlerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvlerim.Location = new System.Drawing.Point(89, 73);
            this.btnEvlerim.Name = "btnEvlerim";
            this.btnEvlerim.Size = new System.Drawing.Size(629, 69);
            this.btnEvlerim.TabIndex = 0;
            this.btnEvlerim.Text = "Evlerim";
            this.btnEvlerim.UseVisualStyleBackColor = true;
            this.btnEvlerim.Click += new System.EventHandler(this.BtnEvlerim_Click);
            // 
            // btnRezervasyonlar
            // 
            this.btnRezervasyonlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonlar.Location = new System.Drawing.Point(89, 148);
            this.btnRezervasyonlar.Name = "btnRezervasyonlar";
            this.btnRezervasyonlar.Size = new System.Drawing.Size(629, 69);
            this.btnRezervasyonlar.TabIndex = 1;
            this.btnRezervasyonlar.Text = "Rezervasyonlarım";
            this.btnRezervasyonlar.UseVisualStyleBackColor = true;
            this.btnRezervasyonlar.Click += new System.EventHandler(this.BtnRezervasyonlar_Click);
            // 
            // btnYorumlar
            // 
            this.btnYorumlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYorumlar.Location = new System.Drawing.Point(86, 223);
            this.btnYorumlar.Name = "btnYorumlar";
            this.btnYorumlar.Size = new System.Drawing.Size(629, 69);
            this.btnYorumlar.TabIndex = 2;
            this.btnYorumlar.Text = "Yorumlar";
            this.btnYorumlar.UseVisualStyleBackColor = true;
            this.btnYorumlar.Click += new System.EventHandler(this.BtnYorumlar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(89, 298);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(629, 69);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // EvSahibiDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYorumlar);
            this.Controls.Add(this.btnRezervasyonlar);
            this.Controls.Add(this.btnEvlerim);
            this.Name = "EvSahibiDashboard";
            this.Text = "EvSahibiDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvlerim;
        private System.Windows.Forms.Button btnRezervasyonlar;
        private System.Windows.Forms.Button btnYorumlar;
        private System.Windows.Forms.Button btnCikis;
    }
}
