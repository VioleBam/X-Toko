using System.IO;
using System.Data.SQLite;

namespace X_Toko.Data
{
    public class Database
    {
        private Pesan pesan = new Pesan();

        public bool CreateDatabase(string path_db)
        {
            if (!File.Exists(path_db))
            {
                SQLiteConnection.CreateFile(path_db);
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + path_db + "; Version=3;"))
                    {
                        conn.Open();
                        CreateTableWithIndexes(conn);
                        pesan.IsiPesan = "Database telah berhasil dibuat.";
                        return true;
                    }
                }
                catch (IOException ex)
                {
                    pesan.IsiPesan = $"IOException during InitializeDatabase: {ex.Message}";
                }
                catch (SQLiteException ex)
                {
                    pesan.IsiPesan = $"SQLiteException during InitializeDatabase: {ex.Message}";
                }
                catch (System.Exception ex)
                {
                    pesan.IsiPesan = $"An unexpected error occurred during InitializeDatabase: {ex.Message}";
                }
            }
            return false;
        }

        private void CreateTableWithIndexes(SQLiteConnection conn)
        {
            SQLiteCommand cmd = conn.CreateCommand();

            // Tabel Supplier
            cmd.CommandText = "CREATE TABLE tblSupplier (" +
                              "supplierID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                              "supplierKode TEXT(15), " +
                              "supplierNama TEXT(100), " +
                              "supplierAlamat TEXT(100), " +
                              "supplierTelepon TEXT(15))";
            cmd.ExecuteNonQuery();

            // Tabel Customer
            cmd.CommandText = "CREATE TABLE tblCustomer (" +
                              "customerID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                              "customerKode TEXT(15), " +
                              "customerNama TEXT(100), " +
                              "customerAlamat TEXT(100), " +
                              "customerTelepon TEXT(15))";
            cmd.ExecuteNonQuery();

            // Tabel Barang
            cmd.CommandText = "CREATE TABLE tblBarang (" +
                              "barangID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                              "barangKode TEXT(15), " +
                              "barangNama TEXT(100), " +
                              "barangStock INTEGER NOT NULL DEFAULT 0 CHECK(barangStock >= 0), " +
                              "barangHargaBeli REAL NOT NULL DEFAULT 0 CHECK(barangHargaBeli >= 0) CHECK(barangHargaBeli <= barangHargaJual), " +
                              "barangHargaJual REAL NOT NULL DEFAULT 0 CHECK(barangHargaJual >= 0) CHECK(barangHargaJual >= barangHargaBeli), " +
                              "supplierID INTEGER, " +
                              "FOREIGN KEY(supplierID) REFERENCES tblSupplier(supplierID))";
            cmd.ExecuteNonQuery();

            // Tabel Transaksi
            cmd.CommandText = "CREATE TABLE tblTransaksi (" +
                              "transaksiID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                              "transaksiKode TEXT(15), " +
                              "transaksiTanggal TEXT, " +
                              "transaksiTotal REAL NOT NULL DEFAULT 0 CHECK(transaksiTotal >= 0), " +
                              "customerID INTEGER, " +
                              "FOREIGN KEY(customerID) REFERENCES tblCustomer (customerID))";
            cmd.ExecuteNonQuery();

            // Tabel TransaksiBarang
            cmd.CommandText = "CREATE TABLE tblTransaksiBarang (" +
                              "transaksibarangID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                              "transaksibarangQty INTEGER NOT NULL DEFAULT 0 CHECK(transaksibarangQty >= 0), " +
                              "transaksibarangTotal REAL NOT NULL DEFAULT 0 CHECK(transaksibarangTotal >= 0), " +
                              "barangID INTEGER, " +
                              "transaksiID INTEGER, " +
                              "FOREIGN KEY(barangID) REFERENCES tblBarang (barangID), " +
                              "FOREIGN KEY(transaksiID) REFERENCES tblTransaksi(transaksiID))";
            cmd.ExecuteNonQuery();

            // Buat indeks untuk mempercepat pencarian
            cmd.CommandText = "CREATE INDEX idx_supplierID ON tblSupplier(supplierID)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE INDEX idx_customerID ON tblCustomer (customerID)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE INDEX idx_barangID ON tblBarang(barangID)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE INDEX idx_transaksiID ON tblTransaksi(transaksiID)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE INDEX idx_transaksibarangID ON tblTransaksiBarang(transaksibarangID)";
            cmd.ExecuteNonQuery();

            // Bersihkan objek pernyataan
            cmd.Dispose();
        }
    }
}
