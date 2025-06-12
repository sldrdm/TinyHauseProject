using System;
using System.Windows.Forms;

namespace TinyHauseProject.Forms.EvSahibi
{
    public partial class CevapForm : Form
    {
        public string CevapMetni => txtCevap.Text;

        public CevapForm()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCevap.Text))
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Cevap boş olamaz.");
        }
    }
}
