using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace X_Toko.Data
{
    public partial class Barang
    {
        private Pesan pesan = new Pesan();

        public List<Barang> Read(string pathDB)
        {
            try
            {
                List<Barang> daftarBarang = new List<Barang>();

                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + pathDB + "; Version=3;"))
                {
                    sqlCon.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(@"SELECT * FROM tblBarang INNER JOIN tblSupplier ON tblBarang.supplierID=tblSupplier.supplierID", sqlCon))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            int idOrdinal = reader.GetOrdinal("barangID");
                            int kodeOrdinal = reader.GetOrdinal("barangKode");
                            int nameOrdinal = reader.GetOrdinal("barangNama");
                            int stokOrdinal = reader.GetOrdinal("barangStock");
                            int beliOrdinal = reader.GetOrdinal("barangHargaBeli");
                            int jualOrdinal = reader.GetOrdinal("barangHargaJual");
                            int idsupOrdinal = reader.GetOrdinal("supplierID");
                            int kodesupOrdinal = reader.GetOrdinal("supplierKode");
                            int namasupOrdinal = reader.GetOrdinal("supplierNama");
                            int alamatsupOrdinal = reader.GetOrdinal("supplierAlamat");
                            int teleponsupOrdinal = reader.GetOrdinal("supplierTelepon");

                            while (reader.Read())
                            {
                                Barang brg = new Barang
                                {
                                    IDBarang = reader.GetInt64(idOrdinal),
                                    KodeBarang = reader.GetString(kodeOrdinal),
                                    NamaBarang = reader.GetString(nameOrdinal),
                                    StokBarang = reader.GetInt32(stokOrdinal),
                                    HargaBeliBarang = reader.GetDouble(beliOrdinal),
                                    HargaJualBarang = reader.GetDouble(jualOrdinal),
                                    IDSupplier = reader.GetInt64(idsupOrdinal),
                                    Properti = new Properti
                                    {
                                        PropertiID = reader.GetInt64(idOrdinal),
                                        PropertiKode = reader.GetString(kodeOrdinal),
                                        PropertiNama = reader.GetString(nameOrdinal),
                                        PropertiAlamat = reader.GetString(alamatsupOrdinal),
                                        PropertiTelepon = reader.GetString(teleponsupOrdinal)
                                    }
                                };

                                // Validasi data sebelum menambahkannya ke daftar
                                if (IsValidBarang(brg))
                                {
                                    daftarBarang.Add(brg);
                                    Properti.TambahBarang(brg);
                                }
                            }
                        }
                    }
                }

                return daftarBarang;
            }
            catch (Exception ex)
            {
                pesan.IsiPesan = $"Error: {ex.Message}";

                return new List<Barang>(); // Atau kembalikan null atau empty list, sesuai kebutuhan
            }
        }

        public bool Input(string pathDB)
        {
            try
            {
                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + pathDB + "; Version=3;"))
                {
                    sqlCon.Open();
                    using (SQLiteCommand cmd = sqlCon.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO tblBarang (barangNama,barangStock,barangHargaBeli,barangHargaJual,supplierID) VALUES (@nama,@stock,@beli,@jual,@id_supplier)";
                        cmd.Parameters.AddWithValue("@nama", NamaBarang.ToUpper());
                        cmd.Parameters.AddWithValue("@stock", StokBarang);
                        cmd.Parameters.AddWithValue("@beli", HargaBeliBarang);
                        cmd.Parameters.AddWithValue("@jual", HargaJualBarang);
                        cmd.Parameters.AddWithValue("@id_supplier", IDSupplier);
                        cmd.ExecuteNonQuery();

                        // Mendapatkan IDBarang yang baru saja di-generate oleh database
                        cmd.CommandText = @"SELECT last_insert_rowid()";
                        IDBarang = (long)cmd.ExecuteScalar();

                        // Mengupdate KodeBarang dengan menggunakan IDBarang yang sudah diambil
                        cmd.CommandText = @"UPDATE tblBarang SET barangKode = @kode WHERE barangID = @id";
                        cmd.Parameters.AddWithValue("@id", IDBarang);
                        cmd.Parameters.AddWithValue("@kode", string.Concat("BRG-", IDBarang.ToString().PadLeft(8, '0')));
                        cmd.ExecuteNonQuery();
                    }
                }

                // Menetapkan pesan sukses ke properti Message
                pesan.IsiPesan = "Success: Data Barang Berhasil Disimpan.";

                return true;
            }
            catch (System.Exception ex)
            {
                // Menetapkan pesan error ke properti Message
                pesan.IsiPesan = $"Error: {ex.Message}";
                return false;
            }
        }

        public bool Update(string pathDB, long id_barang, string update_stock)
        {
            try
            {
                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + pathDB + "; Version=3;"))
                {
                    sqlCon.Open();
                    using (SQLiteCommand cmd = sqlCon.CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE tblBarang SET (barangStock) = (barangStock) + (@stock) WHERE barangKode=(@id_barang)";
                        cmd.Parameters.AddWithValue("@id_barang", id_barang);
                        cmd.Parameters.AddWithValue("@stock", update_stock);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Menetapkan pesan sukses ke properti Message
                pesan.IsiPesan = "Success: Data Barang Berhasil Diupdate.";

                return true;
            }
            catch (System.Exception ex)
            {
                // Menetapkan pesan error ke properti Message
                pesan.IsiPesan = $"Error: {ex.Message}";

                return false;
            }
        }

        public bool Update(string pathDB, int id_barang, string kode_barang, string nama_barang, string stock, string harga_beli, string harga_jual, int kode_supplier)
        {
            try
            {
                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + pathDB + "; Version=3;"))
                {
                    sqlCon.Open();
                    using (SQLiteCommand cmd = sqlCon.CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE tblBarang SET barangKode=@kode,barangNama=@nama,barangStock=@stock,barangHargaBeli=@hargabeli,barangHargaJual=@hargajual,supplierID=@id_supplier WHERE barangID=@id_barang";
                        cmd.Parameters.AddWithValue("@id_barang", id_barang);
                        cmd.Parameters.AddWithValue("@kode", kode_barang.Trim());
                        cmd.Parameters.AddWithValue("@nama", nama_barang.ToUpper().Trim());
                        cmd.Parameters.AddWithValue("@stock", stock.Trim());
                        cmd.Parameters.AddWithValue("@hargabeli", harga_beli.Trim());
                        cmd.Parameters.AddWithValue("@hargajual", harga_jual.Trim());
                        cmd.Parameters.AddWithValue("@id_supplier", IDSupplier);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Menetapkan pesan sukses ke properti Message
                pesan.IsiPesan = "Success: Data Barang Berhasil Diupdate.";
                return true;
            }
            catch (System.Exception ex)
            {
                // Menetapkan pesan error ke properti Message
                pesan.IsiPesan = $"Error: {ex.Message}";
                return false;
            }
        }

        public bool Delete(string pathDB, long barangID)
        {
            try
            {
                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + pathDB + "; Version=3;"))
                {
                    sqlCon.Open();
                    using (SQLiteCommand cmd = sqlCon.CreateCommand())
                    {
                        cmd.CommandText = @"DELETE FROM tblBarang WHERE barangID = @id";
                        cmd.Parameters.AddWithValue("@id", barangID);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Menetapkan pesan error ke properti Message
                pesan.IsiPesan = "Success: Data Barang Berhasil Dihapus.";
                return true;
            }
            catch (System.Exception ex)
            {
                // Menetapkan pesan error ke properti Message
                pesan.IsiPesan = $"Error: {ex.Message}";

                return false;
            }
        }
    }
}
