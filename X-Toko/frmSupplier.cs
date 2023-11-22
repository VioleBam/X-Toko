using System;
using System.Drawing;
using System.Windows.Forms;
using X_Toko.Data;
using System.Collections.Generic;
using System.Linq;

namespace X_Toko
{
    public partial class frmSupplier : Form
    {
        private Files file = new Files();
        private Pesan pesan = new Pesan();
        private Validasi val = new Validasi();
        private Properti properti = new Properti();

        public frmSupplier()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            BtnInput.Image = new Icon(Properties.Resources.Add, 32, 32).ToBitmap();
            btnEdit.Image = new Icon(Properties.Resources.Edit, 32, 32).ToBitmap();
            btnHapus.Image = new Icon(Properties.Resources.Delete, 32, 32).ToBitmap();
            btnSimpan.Image = new Icon(Properties.Resources.Save, 32, 32).ToBitmap();
            btnBatal.Image = new Icon(Properties.Resources.Cancel, 32, 32).ToBitmap();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            LoadData();

            btnSimpan.Enabled = false;
            btnSimpan.Visible = false;
            btnBatal.Enabled = false;
            btnBatal.Visible = false;

            //Inisialisasi Tooltips
            toolTip.SetToolTip(BtnInput, "Tambah data supplier.");
            toolTip.SetToolTip(btnEdit, "Edit data supplier.");
            toolTip.SetToolTip(btnHapus, "Delete data supplier.");
            toolTip.SetToolTip(btnSimpan, "Simpan perubahan data supplier.");
            toolTip.SetToolTip(btnBatal, "Batal mengubah data supplier.");
            toolTip.SetToolTip(CmbSave, "Ekspor data supplier ke file PDF atau Excel.");
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            if (val.ValidasiForm(Tuple.Create(txtNama01.Text, false), Tuple.Create(txtTelp01.Text, true), Tuple.Create(txtAlamat01.Text, false)) == false)
            {
                MessageBox.Show(pesan.IsiPesan, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                properti = new Properti
                {
                    PropertiNama = txtNama01.Text,
                    PropertiAlamat = txtAlamat01.Text,
                    PropertiTelepon = txtTelp01.Text
                };

                if (properti.Input(file.DatabasePath, "tblSupplier"))
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
            btnSimpan.Enabled = true;
            btnSimpan.Visible = true;
            btnBatal.Enabled = true;
            btnBatal.Visible = true;
            btnEdit.Enabled = false;
            btnEdit.Visible = false;
            btnHapus.Enabled = false;
            btnHapus.Visible = false;
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
                DialogResult result = MessageBox.Show("Apakah anda ingin mengupdate data supplier ini...???", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data supplier ini...???", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Error: Gagal menghapus data supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadData()
        {
            properti = new Properti();
            List<Properti> dataGV = properti.Read(file.DatabasePath);

            gvSupplier.DataSource = dataGV.Select(x => new
            {
                ID = x.PropertiID, // Menambahkan IDBarang ke dalam data yang ditampilkan di DataGridView
                Kode = x.PropertiKode,
                Nama = x.PropertiNama,
                Alamat = x.PropertiAlamat,
                Telepon = x.PropertiTelepon
            }).ToList();

            gvSupplier.Columns["ID"].Visible = false;

            if (gvSupplier.Columns.Contains("Nama"))
            {
                gvSupplier.Columns["Nama"].HeaderText = "Nama Supplier";
            }

            if (gvSupplier.Columns.Contains("Alamat"))
            {
                gvSupplier.Columns["Alamat"].HeaderText = "Alamat Supplier";
            }

            gvSupplier.Columns["ID"].Width = 10;
            gvSupplier.Columns["Kode"].Width = 75;
            gvSupplier.Columns["Kode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvSupplier.Columns["Nama"].Width = 150;
            gvSupplier.Columns["Telepon"].Width = 100;
            gvSupplier.Columns["Telepon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void GvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvSupplier.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvSupplier.CurrentRow;

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

            txtNama02.Text = "";
            txtAlamat02.Text = "";
            txtTelp02.Text = "";

            txtNama02.Enabled = false;
            txtTelp02.Enabled = false;
            txtAlamat02.Enabled = false;
            btnSimpan.Enabled = false;
            btnSimpan.Visible = false;
            btnBatal.Enabled = false;
            btnBatal.Visible = false;
            btnEdit.Enabled = true;
            btnEdit.Visible = true;
            btnHapus.Enabled = true;
            btnHapus.Visible = true;

            gvSupplier.ClearSelection();
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            gvSupplier.DataSource = null;

            properti = new Properti();
            List<Properti> searchResult = properti.Search(file.DatabasePath, txtCari.Text);

            // Periksa apakah ada hasil pencarian
            if (searchResult.Count > 0)
            {
                // Jika ada, set data source DataGridView
                gvSupplier.DataSource = searchResult;
            }
        }

        private void CmbSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            Excel xls = new Excel();
            Files file = new Files();
            switch (CmbSave.SelectedIndex)
            {
                case 0:
                    if (pdf.SavePDF("Supplier"))
                    {
                        MessageBox.Show(pesan.IsiPesan, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 1:
                    if (xls.SaveExcel("Supplier"))
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
