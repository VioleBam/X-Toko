using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using X_Toko.Properties;
using System.Data.SQLite;
using X_Toko.Data;

namespace X_Toko
{
    public partial class frmMain : Form
    {
        private Files file = new Files();
        private Pesan pesan = new Pesan();
        private Barang barang = new Barang();
        private Transaksi trans = new Transaksi();
        private TransaksiBarang tb = new TransaksiBarang();
        private List<PrintTransaksi> pt = new List<PrintTransaksi>();
        private PrintHandler ph = new PrintHandler();
        private readonly Timer blinkTimer;
        private FrmSetting frmSetting;

        public frmMain()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            btnSupplier.Image = new Icon(Resources.Supplier, 32, 32).ToBitmap();
            btnCustomer.Image = new Icon(Resources.User, 32, 32).ToBitmap();
            btnBarang.Image = new Icon(Resources.Item, 32, 32).ToBitmap();
            btnSetting.Image = new Icon(Resources.Setting, 32, 32).ToBitmap();
            btnExit.Image = new Icon(Resources.Exit, 32, 32).ToBitmap();
            btnAdd.Image = new Icon(Resources.Add, 32, 32).ToBitmap();

            // Cek File DLL yang dibutuhkan
            Files file = new Files();
            if (file.CheckRequirementDLL() == false)
            {
                DialogResult result = MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                    Close();
            }

            blinkTimer = new Timer
            {
                Interval = 500
            };
            blinkTimer.Tick += BlinkTimer_Tick;
            blinkTimer.Start();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtQty.MaxLength = 4;

            // Set up DataGridView columns
            gvTransaksi.ColumnCount = 6;
            gvTransaksi.Columns[0].Name = "Kode Barang";
            gvTransaksi.Columns[0].Width = 95;
            gvTransaksi.Columns[1].Name = "Tanggal";
            gvTransaksi.Columns[1].Width = 75;
            gvTransaksi.Columns[2].Name = "Nama Barang";
            gvTransaksi.Columns[3].Name = "Qty";
            gvTransaksi.Columns[3].Width = 50;
            gvTransaksi.Columns[4].Name = "Harga Satuan";
            gvTransaksi.Columns[5].Name = "Total Harga";

            // Initialize Tooltips
            toolTip.SetToolTip(btnSupplier, "Tambah, edit atau delete data supplier.");
            toolTip.SetToolTip(btnCustomer, "Tambah, edit atau delete data customer.");
            toolTip.SetToolTip(btnBarang, "Tambah, edit atau delete data barang.");
            toolTip.SetToolTip(btnSetting, "Konfigurasi dari aplikasi.");
            toolTip.SetToolTip(btnExit, "Keluar dari aplikasi.");

            // Check and set up configuration
            CekConfig();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                sysTray.Visible = true;
            }
        }

        private void Systray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            sysTray.Visible = false;
        }

        private void StatusStrip_Click(object sender, EventArgs e)
        {
            Form setting = new FrmSetting();
            setting.ShowDialog();
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            if (file.CheckFiles(true, file.DatabasePath) == true)
            {
                Form supplier = new frmSupplier();
                supplier.ShowDialog();
            }
            else
            {
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBarang_Click(object sender, EventArgs e)
        {
            if (file.CheckFiles(true, file.DatabasePath) == true)
            {
                Form barang = new frmBarang();
                barang.ShowDialog();
            }
            else
            {
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            if (file.CheckFiles(true, file.DatabasePath) == true)
            {
                Form customer = new FrmCustomer01();
                customer.ShowDialog();
            }
            else
            {
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTransaksi_Click(object sender, EventArgs e)
        {
            Form transaksi = new frmTransaksi();
            transaksi.ShowDialog();
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            Form setting = new FrmSetting();
            setting.FormClosed += Setting_FormClosed;
            setting.ShowDialog();
        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            CekConfig();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCariBarang_Click(object sender, EventArgs e)
        {
            Form cariBrg = new frmCariBarang();
            cariBrg.FormClosed += CariBrg_FormClosed;
            cariBrg.ShowDialog();
        }

        private void CariBrg_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtKodeBarang.Text = barang.KodeBarang.ToString();
            txtNamaBarang.Text = barang.NamaBarang.ToString();
            txtHarga.Text = barang.HargaJualBarang.ToString();
            txtQty.Enabled = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(Validasi() == false)
            {
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else 
            {
                trans.TotalTransaksi = 0;
                trans.TanggalTransaksi = dateTime.Value.ToString("dd/MM/yyyy");
                string[] baris = new string[] { barang.KodeBarang.ToString(), trans.TanggalTransaksi,barang.NamaBarang.ToString(), tb.QtyTB.ToString(), barang.HargaJualBarang.ToString(), tb.TotalTB.ToString() };
                gvTransaksi.Rows.Add(baris);
                foreach (DataGridViewRow row in gvTransaksi.Rows)
                {
                    trans.TotalTransaksi += Convert.ToInt32(row.Cells["Total Harga"].Value);
                }
                lblTotalJual.Text = trans.TotalTransaksi.ToString();
                pt.Add(new PrintTransaksi { NamaBarang = barang.NamaBarang.ToString(), QtyBarang = tb.QtyTB, HargaBarang = barang.HargaJualBarang, TotalHarga = tb.TotalTB, JumlahTotal = trans.TotalTransaksi });

                // Reset
                txtKodeBarang.Text = "";
                txtNamaBarang.Text = "";
                txtQty.Text = "0";
                txtQty.Enabled = false;
                txtHarga.Text = "Rp. 0,-";
                txtTotalHarga.Text = "Rp. 0,-";
            }
        }

        private void TxtQty_TextChanged(object sender, EventArgs e)
        {
            bool res = int.TryParse(txtQty.Text, out int val);
            if (!res) { return; }
            tb.QtyTB = val;
            txtTotalHarga.Text = tb.TotalTB.ToString();
        }

        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            /*if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        /*private void BtnSimpan_Click(object sender, EventArgs e)
        {
            ph.PT = pt;
            if (gvTransaksi.Rows.Count - 1 < 1)
            {
                MessageBox.Show("Data transaksi tidak ada. Gagal menyimpan di database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (cfg.Customer == true)
                {
                    Form cust = new frmCustomer02();
                    cust.ShowDialog();
                }

                if(cfg.Print == true)
                {
                    PrintDocument prntDoc = new PrintDocument();
                    prntDoc.PrintPage += new PrintPageEventHandler(ph.prntTransaksi_PrintPage);

                    prntPrvDlg.Document = prntDoc;
                    prntPrvDlg.ShowDialog();

                    printDlg.Document = prntDoc;

                    if (printDlg.ShowDialog() == DialogResult.OK)
                        prntDoc.Print();
                }              
                SimpanDB();
            }
        }*/

        private bool Validasi()
        {
            if (txtKodeBarang.Text == "" || txtNamaBarang.Text == "")
            {
                 pesan.IsiPesan = "Harap data-datanya diisi terlebih dahulu";
                return false;
            }

            if (string.IsNullOrEmpty(txtQty.Text) || string.IsNullOrWhiteSpace(txtQty.Text) || txtQty.Text == "0")
            {
                 pesan.IsiPesan = "Harap kolom quantity tidak dikosongkan.";
                return false;
            }

            if (tb.QtyTB > Convert.ToInt32(barang.StokBarang))
            {
                pesan.IsiPesan = "Quantity melebihi stok barang";
                return false;
            };
            return true;
        }

        private void Reset() 
        {
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtQty.Text = "0";
            txtQty.Enabled = false;
            txtHarga.Text = "Rp. 0,-";
            txtTotalHarga.Text = "Rp. 0,-";
            lblTotalJual.Text = "0,-";
            gvTransaksi.Rows.Clear();
            tb.Reset();
            trans.Reset();
        }

        private void SimpanDB() 
        {
            string kode;
            try
            {
                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + file.DatabasePath + "; Version=3;"))
                {
                    sqlCon.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlCon))
                    {
                        cmd.CommandText = @"INSERT INTO tblTransaksi (transaksiTanggal,transaksiTotal) VALUES (@tgl,@total)";
                        cmd.Parameters.AddWithValue("@tgl", trans.TanggalTransaksi);
                        cmd.Parameters.AddWithValue("@total", trans.TotalTransaksi);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = @"SELECT last_insert_rowid()";
                        long idTransaksi = (long)cmd.ExecuteScalar();
                        kode = idTransaksi.ToString().PadLeft(8, '0');
                        trans.KodeTransaksi = string.Concat("TRA-", kode);
                        cmd.CommandText = @"UPDATE tblTransaksi SET (transaksiKode) = (@kode) WHERE transaksiID=(@id)";
                        cmd.Parameters.AddWithValue("@id", idTransaksi.ToString());
                        cmd.Parameters.AddWithValue("@kode", trans.KodeTransaksi);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = @"INSERT INTO tblTransaksiBarang (tbQty,tbTotal,KodeBarang,KodeTransaksi) VALUES (@qty,@total,@kb,@kt)";
                        for (int i = 0; i < gvTransaksi.RowCount - 1; i++)
                        {
                            cmd.Parameters.AddWithValue("@qty", gvTransaksi.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("@total", gvTransaksi.Rows[i].Cells[5].Value);
                            cmd.Parameters.AddWithValue("@kb", gvTransaksi.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@kt", trans.KodeTransaksi);
                            cmd.ExecuteNonQuery();
                        }
                        cmd.CommandText = @"UPDATE tblBarang SET (barangStock) = (barangStock) - (@qty) WHERE barangKode=(@kode)";
                        for (int i = 0; i < gvTransaksi.RowCount - 1; i++)
                        {
                            cmd.Parameters.AddWithValue("@qty", gvTransaksi.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("@kode", gvTransaksi.Rows[i].Cells[0].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                Reset();
                MessageBox.Show("Transaksi berhasil disimpan kedalam database.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CekConfig()
        {
            try
            {
                if (file.LoadConfig() == null)
                {
                    ShowBlinkingText(" File konfigurasi aplikasi tidak ditemukan.", Color.Red);
                    MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (string.IsNullOrEmpty(file.DatabasePath) ||
                        string.IsNullOrWhiteSpace(file.DatabasePath) ||
                        file.CheckFiles(false, file.DatabasePath) == false)
                    {
                        ShowBlinkingText(" Database tidak terhubung.", Color.Red);
                    }
                    else
                    {
                        StatusStripLabel.Text = " Database telah terhubung";
                        StatusStripLabel.ForeColor = Color.Blue;
                    }
                }
            }
            catch (Exception ex)
            {
                StatusStripLabel.Text = $"Error: Error during configuration check: {ex.Message}";
                StatusStripLabel.ForeColor = Color.Red;
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            DialogResult result = MessageBox.Show("Yakin mau menutup aplikasi ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    //sysTray.Dispose();
                    //Application.Exit();
                    break;
            }
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            // Toggle the visibility of the statusStripLabel
            StatusStripLabel.Visible = !StatusStripLabel.Visible;
        }

        private void ShowBlinkingText(string pesan, Color color)
        {
            // Set the initial text
            StatusStripLabel.Text = pesan;

            // Set the initial color
            StatusStripLabel.ForeColor = color;

            // Set the initial visibility
            StatusStripLabel.Visible = true;
        }
    }
}
