using System;
using System.Drawing;
using X_Toko.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace X_Toko
{
    public partial class frmCariBarang : Form
    {
        private Files file = new Files();
        Barang brg = new Barang();

        public frmCariBarang()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            gvBarang.ColumnCount = 6;
            gvBarang.Columns[0].Name = "Kode Barang";
            gvBarang.Columns[1].Name = "Nama Barang";
            gvBarang.Columns[2].Name = "Stock";
            gvBarang.Columns[3].Name = "HargaBeli";
            gvBarang.Columns[4].Name = "HargaJual";
            gvBarang.Columns[5].Name = "Nama Supplier";
        }

        private void btnCariKode_Click(object sender, EventArgs e)
        {
            gvBarang.Rows.Clear();
            if (string.IsNullOrEmpty(txtKode.Text.ToUpper()) || string.IsNullOrWhiteSpace(txtKode.Text.ToUpper()))
            {
                MessageBox.Show("Kolom kode barang harap diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + file.DatabasePath + "; Version=3;"))
                    {
                        sqlCon.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(sqlCon))
                        {
                            cmd.CommandText = @"SELECT * FROM tblBarang INNER JOIN tblSupplier ON tblBarang.KodeSupplier=tblSupplier.supplierKode WHERE (barangKode LIKE @kode)";
                            cmd.Parameters.AddWithValue("@kode", string.Concat("%", txtKode.Text.ToUpper(), "%"));
                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    gvBarang.Rows.Add(new object[]{
                                        reader.GetValue(reader.GetOrdinal("barangKode")),
                                        reader.GetValue(reader.GetOrdinal("barangNama")),
                                        reader.GetValue(reader.GetOrdinal("barangStock")),
                                        reader.GetValue(reader.GetOrdinal("barangHargaBeli")),
                                        reader.GetValue(reader.GetOrdinal("barangHargaJual")),
                                        reader.GetValue(reader.GetOrdinal("supplierNama"))
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCariNama_Click(object sender, EventArgs e)
        {
            gvBarang.Rows.Clear();
            if (string.IsNullOrEmpty(txtNama.Text.ToUpper()) || string.IsNullOrWhiteSpace(txtNama.Text.ToUpper()))
            {
                MessageBox.Show("Kolom nama barang harap diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else 
            {
                try
                {
                    using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + file + "; Version=3;"))
                    {
                        sqlCon.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(sqlCon))
                        {
                            cmd.CommandText = @"SELECT * FROM tblBarang INNER JOIN tblSupplier ON tblBarang.KodeSupplier=tblSupplier.supplierKode WHERE (barangNama LIKE @nama)";
                            cmd.Parameters.AddWithValue("@nama", string.Concat("%", txtNama.Text.ToUpper(), "%"));
                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    gvBarang.Rows.Add(new object[]{
                                        reader.GetValue(reader.GetOrdinal("barangKode")),
                                        reader.GetValue(reader.GetOrdinal("barangNama")),
                                        reader.GetValue(reader.GetOrdinal("barangStock")),
                                        reader.GetValue(reader.GetOrdinal("barangHargaBeli")),
                                        reader.GetValue(reader.GetOrdinal("barangHargaJual")),
                                        reader.GetValue(reader.GetOrdinal("supplierNama"))
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private void gvBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int RowIndex = e.RowIndex;
            /*brg.KodeBarang = gvBarang.Rows[RowIndex].Cells[0].Value.ToString();
            brg.NamaBarang = gvBarang.Rows[RowIndex].Cells[1].Value.ToString();
            brg.StockBarang = Convert.ToInt32(gvBarang.Rows[RowIndex].Cells[2].Value.ToString());
            brg.HargaBeliBarang = Convert.ToInt32(gvBarang.Rows[RowIndex].Cells[3].Value.ToString());
            brg.HargaJualBarang = Convert.ToInt32(gvBarang.Rows[RowIndex].Cells[4].Value.ToString());
            brg.NamaSupplier = gvBarang.Rows[RowIndex].Cells[5].Value.ToString();*/
            Close();
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
