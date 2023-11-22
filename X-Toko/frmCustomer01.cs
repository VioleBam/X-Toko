using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using X_Toko.Data;
using System.Collections.Generic;
using System.Linq;

namespace X_Toko
{
    public partial class FrmCustomer01 : Form
    {
        private Files file = new Files();
        private Pesan pesan = new Pesan();
        private Validasi val = new Validasi();
        private Properti properti = new Properti();

        public FrmCustomer01()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            BtnInput.Image = new Icon(Properties.Resources.Add, 32, 32).ToBitmap();
            BtnEdit.Image = new Icon(Properties.Resources.Edit, 32, 32).ToBitmap();
            BtnHapus.Image = new Icon(Properties.Resources.Delete, 32, 32).ToBitmap();
            BtnSimpan.Image = new Icon(Properties.Resources.Save, 32, 32).ToBitmap();
            BtnBatal.Image = new Icon(Properties.Resources.Cancel, 32, 32).ToBitmap();
        }

        private void FrmCustomer01_Load(object sender, EventArgs e)
        {
            LoadData(); 

            BtnSimpan.Enabled = false;
            BtnSimpan.Visible = false;
            BtnBatal.Enabled = false;
            BtnBatal.Visible = false;

            //Inisialisasi Tooltips
            toolTip.SetToolTip(BtnInput, "Tambah data customer.");
            toolTip.SetToolTip(BtnEdit, "Edit data customer.");
            toolTip.SetToolTip(BtnHapus, "Delete data customer.");
            toolTip.SetToolTip(BtnSimpan, "Simpan perubahan data customer.");
            toolTip.SetToolTip(BtnBatal, "Batal mengubah data customer.");
            toolTip.SetToolTip(cmbSave, "Ekspor data customer ke file PDF atau Excel.");
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            if (!val.ValidasiForm(
                Tuple.Create(txtNama01.Text, false),
                Tuple.Create(txtAlamat01.Text, false),
                Tuple.Create(txtTelp01.Text, true)))
            {
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                properti = new Properti
                {
                    PropertiNama = txtNama01.Text,
                    PropertiAlamat = txtAlamat01.Text,
                    PropertiTelepon = txtTelp01.Text
                };

                if (properti.Input(file.DatabasePath, "tblCustomer"))
                {
                    Reset();
                    LoadData();
                    MessageBox.Show(pesan.IsiPesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtNama02.Enabled = true;
            txtTelp02.Enabled = true;
            txtAlamat02.Enabled = true;
            BtnSimpan.Enabled = true;
            BtnSimpan.Visible = true;
            BtnBatal.Enabled = true;
            BtnBatal.Visible = true;
            BtnEdit.Enabled = false;
            BtnEdit.Visible = false;
            BtnHapus.Enabled = false;
            BtnHapus.Visible = false;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            // Pastikan IDSupplier tidak sama dengan 0 (nilai default)
            if (properti.PropertiID == 0)
            {
                MessageBox.Show("Silahkan Dipilih Data Yang Mau Diupdate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Apakah anda ingin mengupdate data customer ini...???", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (val.ValidasiForm(Tuple.Create(txtNama02.Text, false), Tuple.Create(txtTelp02.Text, true), Tuple.Create(txtAlamat02.Text, false)) == false)
                    {
                        MessageBox.Show(pesan.IsiPesan, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (properti.Update(file.DatabasePath, properti))
                        {
                            Reset();
                            LoadData();
                            MessageBox.Show(pesan.IsiPesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            // Pastikan IDSupplier tidak sama dengan 0 (nilai default)
            if (properti.PropertiID == 0)
            {
                MessageBox.Show("Silahkan Dipilih Data Yang Mau Dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data customer ini...???", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Memanggil metode DeleteBarang dengan menyertakan IDBarang
                    if (properti.Delete(file.DatabasePath, properti.PropertiID))
                    {
                        Reset();
                        LoadData();
                        MessageBox.Show(pesan.IsiPesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error: Gagal menghapus data customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadData()
        {
            properti = new Properti();
            List<Properti> dataGV = properti.Read(file.DatabasePath);

            gvCustomer.DataSource = dataGV.Select(x => new
            {
                ID = x.PropertiID, // Menambahkan IDBarang ke dalam data yang ditampilkan di DataGridView
                Kode = x.PropertiKode,
                Nama = x.PropertiNama,
                Alamat = x.PropertiAlamat,
                Telepon = x.PropertiTelepon
            }).ToList();

            gvCustomer.Columns["ID"].Visible = false;

            if (gvCustomer.Columns.Contains("Nama"))
            {
                gvCustomer.Columns["Nama"].HeaderText = "Nama Customer";
            }

            if (gvCustomer.Columns.Contains("Alamat"))
            {
                gvCustomer.Columns["Alamat"].HeaderText = "Alamat Customer";
            }

            gvCustomer.Columns["ID"].Width = 10;
            gvCustomer.Columns["Kode"].Width = 75;
            gvCustomer.Columns["Kode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvCustomer.Columns["Nama"].Width = 150;
            gvCustomer.Columns["Telepon"].Width = 100;
            gvCustomer.Columns["Telepon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void GvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvCustomer.CurrentRow;

                // Gunakan objek supplier yang sudah ada
                properti.PropertiID = Convert.ToInt64(selectedRow.Cells["ID"].Value);
                properti.PropertiKode = selectedRow.Cells["Kode"].Value.ToString().Trim();
                properti.PropertiNama = selectedRow.Cells["Nama"].Value.ToString().Trim();
                properti.PropertiAlamat = selectedRow.Cells["Alamat"].Value.ToString().Trim();
                properti.PropertiTelepon = selectedRow.Cells["Telepon"].Value.ToString().Trim();

                txtNama02.Text = properti.PropertiNama;
                txtAlamat02.Text = properti.PropertiAlamat;
                txtTelp02.Text = properti.PropertiTelepon;
            }
        }

        private void Reset()
        {
            txtNama01.Text = "";
            txtAlamat01.Text = "";
            txtTelp01.Text = "";

            txtNama02.Enabled = false;
            txtTelp02.Enabled = false;
            txtAlamat02.Enabled = false;
            BtnSimpan.Enabled = false;
            BtnSimpan.Visible = false;
            BtnBatal.Enabled = false;
            BtnBatal.Visible = false;
            BtnEdit.Enabled = true;
            BtnEdit.Visible = true;
            BtnHapus.Enabled = true;
            BtnHapus.Visible = true;
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            gvCustomer.DataSource = null;

            properti = new Properti();
            List<Properti> searchResult = properti.Search(file.DatabasePath, txtCari.Text);

            // Periksa apakah ada hasil pencarian
            if (searchResult.Count > 0)
            {
                // Jika ada, set data source DataGridView
                gvCustomer.DataSource = searchResult;
            }
        }

        private void CmbSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            Excel xls = new Excel();
            switch (cmbSave.SelectedIndex)
            {
                case 0:
                    if (pdf.SavePDF("Customer"))
                    {
                        MessageBox.Show(pesan.IsiPesan, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 1:
                    if (xls.SaveExcel("Customer") == true)
                    {
                        MessageBox.Show(pesan.IsiPesan, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
