using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Collections.Generic;
using X_Toko.Data;

namespace X_Toko
{
    public partial class frmBarang : Form 
    {
        private Files file = new Files();
        private Barang barang = new Barang();
        private Pesan pesan = new Pesan();

        public frmBarang()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            btnInput.Image = new Icon(Properties.Resources.TambahBarang, 32, 32).ToBitmap();
            btnEdit.Image = new Icon(Properties.Resources.Edit, 32, 32).ToBitmap();
            btnDelete.Image = new Icon(Properties.Resources.Delete, 32, 32).ToBitmap();
            btnSimpan.Image = new Icon(Properties.Resources.Save, 32, 32).ToBitmap();
            btnBatal.Image = new Icon(Properties.Resources.Cancel, 32, 32).ToBitmap();
            btnTambah.Image = new Icon(Properties.Resources.Add, 32, 32).ToBitmap();
        }

        private void FrmBarang_Load(object sender, EventArgs e)
        {
            GetSupplier();
            LoadTable();

            btnSimpan.Enabled = false;
            btnSimpan.Visible = false;
            btnBatal.Enabled = false;
            btnBatal.Visible = false;
        }

        private void btnInputBarang_Click(object sender, EventArgs e)
        {
            Validasi val = new Validasi();
            if (!val.ValidasiForm(Tuple.Create(txtNama01.Text, false),Tuple.Create(txtStok01.Text, true),Tuple.Create(txtBeli01.Text, true),Tuple.Create(txtJual01.Text, true)))
            {
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Convert.ToInt32(txtJual01.Text) < Convert.ToInt32(txtBeli01.Text))
                {
                    MessageBox.Show("Harga jual lebih kecil dari harga beli.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmbSupplier.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Dipilih dulu data suppliernya.", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        barang = new Barang(
                            txtNama01.Text,
                            Convert.ToInt32(txtStok01.Text),
                            Convert.ToDouble(txtBeli01.Text),
                            Convert.ToDouble(txtJual01.Text),
                            0,
                            "",
                            Convert.ToInt64(cmbSupplier.SelectedValue));

                        if (barang.Input(file.DatabasePath))
                        {
                            Reset();
                            LoadTable();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtNama02.Enabled = true;
            txtStok02.Enabled = true;
            txtBeli02.Enabled = true;
            txtJual02.Enabled = true;
            btnSimpan.Enabled = true;
            btnSimpan.Visible = true;
            btnBatal.Enabled = true;
            btnBatal.Visible = true;
            btnEdit.Enabled = false;
            btnEdit.Visible = false;
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
        }

        private void btnDeleteBarang_Click(object sender, EventArgs e)
        {
            // Pastikan IDBarang tidak sama dengan 0 (nilai default)
            if (barang.IDBarang == 0)
            {
                MessageBox.Show("Dipilih dulu yang mau dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Memanggil metode DeleteBarang dengan menyertakan IDBarang
                if (barang.Delete(file.DatabasePath, barang.IDBarang))
                {
                    Reset();
                    LoadTable();
                    MessageBox.Show(pesan.IsiPesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: Gagal menghapus data barang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Reset();
            txtNama02.Enabled = false;
            txtStok02.Enabled = false;
            txtBeli02.Enabled = false;
            txtJual02.Enabled = false;
            btnSimpan.Enabled = false;
            btnSimpan.Visible = false;
            btnBatal.Enabled = false;
            btnBatal.Visible = false;
            btnEdit.Enabled = true;
            btnEdit.Visible = true;
            btnDelete.Enabled = true;
            btnDelete.Visible = true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (barang.IDBarang != 0)
            {
                MessageBox.Show("Dipilih dulu data stock yang mau diupdate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(barang.Update(file.DatabasePath, barang.IDBarang, txtUpdate.Text) == true)
                {
                    MessageBox.Show(pesan.IsiPesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTable();
                    Reset();
                }
                else
                    MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (barang.IDBarang != 0)
            {
                MessageBox.Show("Dipilih dulu data stock yang mau diupdate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (barang.Update(file.DatabasePath, barang.IDBarang, txtUpdate.Text) == true)
                {
                    MessageBox.Show(pesan.IsiPesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTable();
                    Reset();
                }
                else
                    MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetSupplier()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + file.DatabasePath + "; Version=3;"))
                {
                    sqlCon.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(@"SELECT supplierID,supplierNama FROM tblSupplier", sqlCon))
                    {
                        SQLiteDataReader dr = cmd.ExecuteReader();
                        dt.Load(dr);
                        DataRow row = dt.NewRow();
                        row["supplierID"] = 0;
                        row["supplierNama"] = "-= PILIH SALAH SATU =-";
                        dt.Rows.InsertAt(row, 0);
                        cmbSupplier.ValueMember = "supplierID";
                        cmbSupplier.DisplayMember = "supplierNama";
                        cmbSupplier.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvBarang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvBarang.CurrentRow;

                // Mengambil nilai dari sel-sel kolom pada baris yang dipilih
                barang.SetID(true, false, Convert.ToInt64(selectedRow.Cells["ID_Barang"].Value)); // Menambahkan IDBarang ke objek barang
                barang.SetKode(true, selectedRow.Cells["Kode_Barang"].Value.ToString().Trim());
                txtNama02.Text = selectedRow.Cells["Nama_Barang"].Value.ToString().Trim();
                txtStok02.Text = selectedRow.Cells["Stok_Barang"].Value.ToString().Trim();
                txtBeli02.Text = selectedRow.Cells["Harga_Beli"].Value.ToString().Trim();
                txtJual02.Text = selectedRow.Cells["Harga_Jual"].Value.ToString().Trim();
            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            barang.SetID(false, true, Convert.ToInt64(cmbSupplier.SelectedValue));
        }

        private void Reset()
        {
            txtNama01.Text = "";
            txtStok01.Text = "";
            txtBeli01.Text = "";
            txtJual01.Text = "";
            txtNama02.Text = "";
            txtStok02.Text = "";
            txtBeli02.Text = "";
            txtJual02.Text = "";
            txtUpdate.Text = "";
            barang.Clear();
            gvBarang.ClearSelection();
            cmbSupplier.SelectedIndex = 0;
        }

        private void LoadTable()
        {
            List<Barang> dataGV = barang.Read(file.DatabasePath);

            gvBarang.DataSource = dataGV.Select(x => new
            {
                ID_Barang = x.IDBarang, // Menambahkan IDBarang ke dalam data yang ditampilkan di DataGridView
                Kode_Barang = x.KodeBarang,
                Nama_Barang = x.NamaBarang,
                Stok_Barang = x.StokBarang,
                Harga_Beli = x.HargaBeliBarang,
                Harga_Jual = x.HargaJualBarang,
                Nama_Supplier = x.Properti != null ? x.Properti.PropertiNama : string.Empty

            }).ToList();

            gvBarang.Columns["ID_Barang"].Visible = false; // Kolom ini tidak akan terlihat di DataGridView
            gvBarang.Columns["Kode_Barang"].HeaderText = "Kode";
            gvBarang.Columns["Kode_Barang"].Width = 90;
            gvBarang.Columns["Kode_Barang"].DataPropertyName = "Kode_Barang";
            gvBarang.Columns["Kode_Barang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvBarang.Columns["Nama_Barang"].HeaderText = "Nama";
            gvBarang.Columns["Nama_Barang"].Width = 220;
            gvBarang.Columns["Nama_Barang"].DataPropertyName = "Nama_Barang";
            gvBarang.Columns["Stok_Barang"].HeaderText = "Stok";
            gvBarang.Columns["Stok_Barang"].Width = 50;
            gvBarang.Columns["Stok_Barang"].DataPropertyName = "Stok_Barang";
            gvBarang.Columns["Stok_Barang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvBarang.Columns["Harga_Beli"].HeaderText = "Harga Beli";
            gvBarang.Columns["Harga_Beli"].Width = 90;
            gvBarang.Columns["Harga_Beli"].DataPropertyName = "Harga_Beli";
            gvBarang.Columns["Harga_Beli"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvBarang.Columns["Harga_Jual"].HeaderText = "Harga Jual";
            gvBarang.Columns["Harga_Jual"].Width = 90;
            gvBarang.Columns["Harga_Jual"].DataPropertyName = "Harga_Jual";
            gvBarang.Columns["Harga_Jual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvBarang.Columns["Nama_Supplier"].HeaderText = "Nama Supplier";
            gvBarang.Columns["Nama_Supplier"].DataPropertyName = "Nama_Supplier";

            // Mengatur teks header ke tengah
            foreach (DataGridViewColumn column in gvBarang.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Reset();
        }
    }
}
