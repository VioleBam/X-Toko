using System;
using System.IO;
using X_Toko.Data;
using System.Drawing;
using X_Toko.Properties;
using System.Windows.Forms;

namespace X_Toko
{
    public partial class FrmSetting : Form
    {
        private Files file = new Files();
        private Files config = null;
        private Pesan pesan = new Pesan();
        private Database db = new Database();
        private Validasi val = new Validasi();
        private Settings set = Settings.Default;

        public FrmSetting()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            btnCustomer.Image = new Icon(Resources.DelUser, 32,32).ToBitmap();
            btnSupplier.Image = new Icon(Resources.DelSupplier, 32, 32).ToBitmap();
            btnOpen.Image = new Icon(Resources.OpenDB, 32, 32).ToBitmap();
            btnCreate.Image = new Icon(Resources.CreateDB, 32, 32).ToBitmap();
            btnSetting.Image = new Icon(Resources.Save, 32, 32).ToBitmap();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            CekConfig();

            //Inisialisasi Tooltips
            toolTip.SetToolTip(btnSupplier, "Menghapus tabel supplier dari DB dan mengganti dengan data dari Excel");
            toolTip.SetToolTip(btnCustomer, "Menghapus tabel customer dari DB dan mengganti dengan data dari Excel");
            toolTip.SetToolTip(btnCreate, "Buat database baru.");
            toolTip.SetToolTip(btnSetting, "Simpan konfigurasi setting.");
        }

        private void CekConfig()
        {
            config = file.LoadConfig();
            if (config != null)
                DisableDataToko();
            else
                EnableDataToko();

            txtLokasi.Text = config?.CheckFiles(true, config.DatabasePath) == true ? config.DatabasePath : string.Empty;
        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EnableDataToko();
        }

        private void BtnSimpanToko_Click(object sender, EventArgs e)
        {
            file.NamaToko = txtNama.Text.ToUpper();
            file.TeleponToko = txtTelepon.Text.ToUpper();
            file.AlamatToko = txtAlamat.Text.ToUpper();
            file.ApplicationPath = Path.GetFullPath(set.AppName);

            if (val.ValidasiForm(Tuple.Create(file.NamaToko, false), Tuple.Create(file.TeleponToko, true), Tuple.Create(file.AlamatToko, false)) == false)
            {
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (file.SaveConfig(file))
                {
                    MessageBox.Show(pesan.IsiPesan, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableDataToko();
                }
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            config = file.LoadConfig();

            if (val.ValidasiForm(Tuple.Create(config.NamaToko, false), Tuple.Create(config.TeleponToko, true), Tuple.Create(config.AlamatToko, false)) == false)
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                saveFD = new SaveFileDialog
                {
                    Filter = "Database File|*.bass",
                    Title = "Simpan File DB"
                };

                if (saveFD.ShowDialog() == DialogResult.OK)
                {
                    file.DatabasePath = saveFD.FileName;
                    file.DeleteFile(file.DatabasePath);

                    if (config != null)
                    {
                        config.DatabasePath = file.DatabasePath;
                        file.SaveConfig(config);

                        if (db.CreateDatabase(config.DatabasePath))
                        {
                            txtLokasi.Text = file.DatabasePath;
                            MessageBox.Show(pesan.IsiPesan, "Sekilas Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (val.ValidasiForm(Tuple.Create(file.NamaToko, false), Tuple.Create(file.TeleponToko, true), Tuple.Create(file.AlamatToko, false)) == false)
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                openDB = new OpenFileDialog
                {
                    Filter = "Database File|*.bass",
                    Title = "Buka File DB"
                };

                if (openDB.ShowDialog() == DialogResult.OK)
                {
                    file.DatabasePath = openDB.FileName;
                    txtLokasi.Text = file.DatabasePath;
                    txtLokasi.Enabled = false;
                }
            }            
        }

        private void BtnSimpanSetting_Click(object sender, EventArgs e)
        {
            file.NamaToko = txtNama.Text.ToUpper();
            file.TeleponToko = txtTelepon.Text.ToUpper();
            file.AlamatToko = txtAlamat.Text.ToUpper();

            if (val.ValidasiForm(Tuple.Create(file.NamaToko, false), Tuple.Create(file.TeleponToko, true), Tuple.Create(file.AlamatToko, false)) == false)
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //ValidasiUmum();
                if (file.SaveConfig(file))
                {
                    MessageBox.Show("Setting berhasil disimpan.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableDataToko();
                }
            }
        }

        /*private void ValidasiUmum()
        {
            if (chkPrint.Checked == true)
                cfg.Print = true;
            else cfg.Print = false;
            if (chkPreview.Checked == true)
                cfg.PrintPreview = true;
            else cfg.PrintPreview = false;
            if (chkCust.Checked == true)
                cfg.Customer = true;
            else cfg.Customer = false;
        }

        private void SetChk()
        {
            if (cfg.Print == true)
                chkPrint.Checked = true;
            else chkPrint.Checked = false;
            if (cfg.PrintPreview == true)
                chkPreview.Checked = true;
            else chkPreview.Checked = false;
            if (cfg.Customer == true)
            {
                chkCust.Checked = true;
                //cust.Cek = true;
            }
            else
            {
                chkCust.Checked = false;
                //cust.Cek = false;
            }
        }*/

        private void SetData()
        {
            txtNama.Text = config.NamaToko;
            txtTelepon.Text = config.TeleponToko;
            txtAlamat.Text = config.AlamatToko;
            //SetChk();
        }

        private void DisableDataToko()
        {
            SetData();
            txtNama.Enabled = false;
            txtTelepon.Enabled = false;
            txtAlamat.Enabled = false;
            btnEditToko.Enabled = true;
            btnSaveToko.Enabled = false;
        }

        private void EnableDataToko()
        {
            SetData();
            txtNama.Enabled = true;
            txtTelepon.Enabled = true;
            txtAlamat.Enabled = true;
            chkPrint.Checked = true;
            chkPreview.Checked = true;
            chkCust.Checked = true;
            btnEditToko.Enabled = false;
            btnSaveToko.Enabled = true;
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {

        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
