using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TinyHauseProject.Config;

namespace TinyHauseProject.Forms.Admin
{
    public partial class OdemeRaporForm : Form
    {
        public OdemeRaporForm()
        {
            InitializeComponent();
            KolonlariOlustur();
            dgvOdemeler.AutoGenerateColumns = false;
        }
        private void KolonlariOlustur()
        {
            dgvOdemeler.Columns.Clear();

            dgvOdemeler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OdemeID",
                HeaderText = "Ödeme No",
                DataPropertyName = "OdemeID",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvOdemeler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RezervasyonID",
                HeaderText = "Rezervasyon No",
                DataPropertyName = "RezervasyonID",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvOdemeler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tutar",
                HeaderText = "Tutar (₺)",
                DataPropertyName = "Tutar",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvOdemeler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OdemeTarihi",
                HeaderText = "Ödeme Tarihi",
                DataPropertyName = "OdemeTarihi",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvOdemeler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OdemeDurumu",
                HeaderText = "Ödeme Durumu",
                DataPropertyName = "OdemeDurumu",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvOdemeler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Aktif",
                HeaderText = "Aktif",
                DataPropertyName = "Aktif",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }


    
        private void OdemeRaporForm_Load(object sender, EventArgs e)
        {
            cmbOdemeDurumu.Items.Clear();
            cmbOdemeDurumu.Items.Add("Tümü");
            cmbOdemeDurumu.Items.Add("Bekliyor");
            cmbOdemeDurumu.Items.Add("Ödendi");
            cmbOdemeDurumu.Items.Add("İptal");
            cmbOdemeDurumu.SelectedIndex = 0; // "Tümü" varsayılan
            OdemeleriYukle();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {

            short? OdemeDurumu = null;
            switch (cmbOdemeDurumu.SelectedIndex)
            {
                case 1:
                    OdemeDurumu = 0;  // Bekliyor
                    break;
                case 2:
                    OdemeDurumu = 1;  // Ödendi
                    break;
                case 3:
                    OdemeDurumu = 2;  // İptal
                    break;
                default:
                    OdemeDurumu = null;
                    break;
            }



            OdemeleriYukle(OdemeDurumu);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            cmbOdemeDurumu.SelectedIndex = 0;
            OdemeleriYukle();
        }

        private void OdemeleriYukle(short? OdemeDurumu = null)
        {
            try
            {
                var parametreler = new Dictionary<string, object>();
                if (OdemeDurumu.HasValue)
                    parametreler.Add("@OdemeDurumu", OdemeDurumu.Value);
                else
                    parametreler.Add("@OdemeDurumu", DBNull.Value);

                DataTable dt = Veritabani.SP_Calistir("dbo.SP_OdemeleriGetir1", parametreler);
                dgvOdemeler.DataSource = dt;


                dgvOdemeler.AutoGenerateColumns = false;
            }


            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
