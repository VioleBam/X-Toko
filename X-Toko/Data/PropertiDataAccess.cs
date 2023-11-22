using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace X_Toko.Data
{
    public partial class Properti
    {
        private Pesan pesan = new Pesan();
        private Properti properti = new Properti();
        
        public List<Properti> Read(string pathDB)
        {
            List<Properti> listProperti = new List<Properti>();
            try
            {
                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + pathDB + "; Version=3;"))
                {
                    sqlCon.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM tblSupplier", sqlCon))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            int idOrdinal = reader.GetOrdinal("supplierID");
                            int kodeOrdinal = reader.GetOrdinal("supplierKode");
                            int nameOrdinal = reader.GetOrdinal("supplierNama");
                            int alamatOrdinal = reader.GetOrdinal("supplierAlamat");
                            int teleponOrdinal = reader.GetOrdinal("supplierTelepon");
                            while (reader.Read())
                            {
                                properti = new Properti
                                {
                                    PropertiID = reader.GetInt64(idOrdinal),
                                    PropertiKode = reader.GetString(kodeOrdinal),
                                    PropertiNama = reader.GetString(nameOrdinal),
                                    PropertiAlamat = reader.GetString(alamatOrdinal),
                                    PropertiTelepon = reader.GetString(teleponOrdinal)
                                };
                                listProperti.Add(properti);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                pesan.IsiPesan = $"Error: {ex.Message}";
            }
            return listProperti;
        }

        public bool Input(string pathDB, string nama_tabel)
        {
            try
            {
                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + pathDB + "; Version=3;"))
                {
                    sqlCon.Open();
                    using (SQLiteCommand cmd = sqlCon.CreateCommand())
                    {
                        string insertQuery = "";
                        string updateQuery = "";

                        if (nama_tabel == "tblSupplier")
                        {
                            insertQuery = @"INSERT INTO tblSupplier (supplierNama, supplierAlamat, supplierTelepon) VALUES (@nama, @alamat, @telepon)";
                            updateQuery = @"UPDATE tblSupplier SET supplierKode = @kode WHERE supplierID = @id";
                        }
                        else
                        {
                            insertQuery = @"INSERT INTO tblCustomer (customerNama, customerAlamat, customerTelepon) VALUES (@nama, @alamat, @telepon)";
                            updateQuery = @"UPDATE tblCustomer SET customerKode = @kode WHERE customerID = @id";
                        }

                        // Insert
                        cmd.CommandText = insertQuery;
                        cmd.Parameters.AddWithValue("@nama", properti.PropertiNama.ToUpper());
                        cmd.Parameters.AddWithValue("@alamat", properti.PropertiAlamat.ToUpper().Trim());
                        cmd.Parameters.AddWithValue("@telepon", properti.PropertiTelepon.Trim());
                        cmd.ExecuteNonQuery();

                        // Get last inserted ID
                        cmd.CommandText = @"SELECT last_insert_rowid()";
                        long insertedId = (long)cmd.ExecuteScalar();

                        properti = new Properti
                        {
                            PropertiID = insertedId,
                            PropertiKode = insertedId.ToString().PadLeft(8, '0')
                        };

                        // Update Kode
                        cmd.CommandText = updateQuery;
                        cmd.Parameters.AddWithValue("@id", properti.PropertiID.ToString());
                        cmd.Parameters.AddWithValue("@kode", string.Concat(nama_tabel == "tblSupplier" ? "SUP-" : "CUS-", properti.PropertiKode));
                        cmd.ExecuteNonQuery();
                    }
                }

                        pesan.IsiPesan = $"Sukses: Data {(nama_tabel == "tblSupplier" ? "Supplier" : "Customer")} Berhasil Disimpan.";
                        return true;
            }
            catch (Exception ex)
            {
                pesan.IsiPesan = "Error: " + ex.Message;
                return false;
            }
        }
        public bool Update(string pathDB, Properti person)
        {
            try
            {
                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + pathDB + "; Version=3;"))
                {
                    sqlCon.Open();
                    using (SQLiteCommand cmd = sqlCon.CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE tblSupplier SET supplierKode=@kode, supplierNama=@nama, supplierAlamat=@alamat, supplierTelepon=@telepon WHERE supplierID=@id";
                        cmd.Parameters.AddWithValue("@id", properti.PropertiID);
                        cmd.Parameters.AddWithValue("@kode", properti.PropertiKode.ToUpper());
                        cmd.Parameters.AddWithValue("@nama", properti.PropertiNama.ToUpper());
                        cmd.Parameters.AddWithValue("@alamat", properti.PropertiAlamat.ToUpper());
                        cmd.Parameters.AddWithValue("@telepon", properti.PropertiTelepon.ToUpper());
                        cmd.ExecuteNonQuery();
                    }
                }
                // Menetapkan pesan sukses ke properti Message
                pesan.IsiPesan = "Success: Data Supplier Berhasil Diupdate.";
                return true;
            }
            catch (Exception ex)
            {
                // Menetapkan pesan error ke properti Message
                pesan.IsiPesan = $"Error: {ex.Message}";
                return false;
            }
        }


        public bool Delete(string pathDB, long id_supplier)
        {
            try
            {
                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + pathDB + "; Version=3;"))
                {
                    sqlCon.Open();
                    using (SQLiteCommand cmd = sqlCon.CreateCommand())
                    {
                        cmd.CommandText = @"DELETE FROM tblSupplier WHERE supplierID = @id_supplier";
                        cmd.Parameters.AddWithValue("@id_supplier", id_supplier);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Menetapkan pesan error ke properti Message
                pesan.IsiPesan = "Success: Data Supplier Berhasil Dihapus.";
                return true;
            }
            catch (System.Exception ex)
            {
                // Menetapkan pesan error ke properti Message
                pesan.IsiPesan = $"Error: {ex.Message}";
                return false;
            }
        }

        public List<Properti> Search(string pathDB, string nama_supplier)
        {
            try
            {
                List<Properti> result = new List<Properti>();

                using (SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=" + pathDB + "; Version=3;"))
                {
                    sqlCon.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlCon))
                    {
                        cmd.CommandText = @"SELECT * FROM tblSupplier WHERE supplierNama LIKE @nama";
                        cmd.Parameters.AddWithValue("@nama", $"%{nama_supplier.ToUpper()}%");

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            int ID_Ordinal = reader.GetOrdinal("supplierID");
                            int Kode_Ordinal = reader.GetOrdinal("supplierKode");
                            int Nama_Ordinal = reader.GetOrdinal("supplierNama");
                            int Alamat_Ordinal = reader.GetOrdinal("supplierAlamat");
                            int Telepon_Ordinal = reader.GetOrdinal("supplierTelepon");

                            while (reader.Read())
                            {
                                properti = new Properti
                                {
                                    PropertiID = reader.GetInt64(ID_Ordinal),
                                    PropertiKode = reader.GetString(Kode_Ordinal),
                                    PropertiNama = reader.GetString(Nama_Ordinal),
                                    PropertiAlamat = reader.GetString(Alamat_Ordinal),
                                    PropertiTelepon = reader.GetString(Telepon_Ordinal)
                                };

                                result.Add(properti);
                            }
                        }
                    }
                }

                return result;
            }
            catch (System.Exception ex)
            {
                pesan.IsiPesan = ex.Message;
                return new List<Properti>();
            }
        }
    }
}
