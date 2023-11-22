using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace X_Toko.Data
{
    public partial class Files
    {
        private Pesan pesan = new Pesan();
        private static readonly string ConfigFilePath = "Config.json";

        public bool CheckFiles(bool tampilkanPesan = true, params string[] fileNames)
        {
            try
            {
                foreach (var fileName in fileNames)
                {
                    if (!File.Exists(fileName))
                    {
                        if (IsDatabaseFile(fileName))
                        {
                            pesan.IsiPesan = $"File database tidak ditemukan.";
                        }
                        else
                        {
                            pesan.IsiPesan = $"File {fileName} tidak ditemukan.";
                        }
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                pesan.IsiPesan = $"Error ketika menjalankan CheckFiles: {ex.Message}";
                return false;
            }
        }

        public bool SaveConfig(Files file_config)
        {
            try
            {
                string json = JsonConvert.SerializeObject(file_config);
                File.WriteAllText(ConfigFilePath, json);
                pesan.IsiPesan = "Data konfigurasi toko berhasil disimpan.";
                return true;
            }
            catch (IOException ex)
            {
                pesan.IsiPesan = $"IOException ketika menjalankan SaveConfig: {ex.Message}";
                return false;
            }
            catch (JsonException ex)
            {
                pesan.IsiPesan = $"JsonException ketika menjalankan SaveConfig: {ex.Message}";
                return false;
            }
            catch (Exception ex)
            {
                pesan.IsiPesan = $"An unexpected error occurred during SaveConfig: {ex.Message}";
                return false;
            }
        }

        public Files LoadConfig()
        {
            try
            {
                if (CheckFiles(false, ConfigFilePath))
                {
                    string json = File.ReadAllText(ConfigFilePath);
                    return JsonConvert.DeserializeObject<Files>(json);
                }
                else
                {
                    pesan.IsiPesan = "Tidak dapat membaca file konfigurasi. Silahkan isi data toko pada bagian Setting.";
                    return null; // Mengembalikan null jika file konfigurasi tidak ditemukan
                }
            }
            catch (IOException ex)
            {
                pesan.IsiPesan = $"IOException during LoadConfig: {ex.Message}";
                return null;
            }
            catch (JsonException ex)
            {
                pesan.IsiPesan = $"JsonException during LoadConfig: {ex.Message}";
                return null;
            }
            catch (Exception ex)
            {
                pesan.IsiPesan = $"An unexpected error occurred during LoadConfig: {ex.Message}";
                return null;
            }
        }

        public bool CheckRequirementDLL()
        {
            string[] requiredFiles = { "System.Data.SQLite.dll", "UglyToad.PdfPig.Core.dll", "UglyToad.PdfPig.dll", "UglyToad.PdfPig.Fonts.dll", "UglyToad.PdfPig.Tokenization.dll", "UglyToad.PdfPig.Tokens.dll" };
            foreach (string file in requiredFiles)
            {
                if (!CheckFiles(true, file))
                {
                    pesan.IsiPesan = $"File {file} tidak ditemukan.";
                    return false;
                }
            }
            return true;
        }

        public void WriteAllBytes(string namaFile, byte[] document)
        {
            DeleteFile(namaFile);
            File.WriteAllBytes(SaveToRoot(namaFile), document);
        }

        public string[] ReadFile(string namaFile)
        {
            string[] baris = File.ReadAllLines(namaFile);
            return baris;
        }

        public bool DeleteFile(string nama_file)
        {
            if (CheckFiles(false ,nama_file))
            {
                File.Delete(nama_file);
                return true;
            }
            else
                return false;
        }

        private bool IsDatabaseFile(string fileName)
        {
            // Tentukan kriteria untuk mengidentifikasi file database, misalnya dengan ekstensi tertentu
            string[] databaseExtensions = { /*".db", ".mdb", ".accdb",*/".bass" };

            return databaseExtensions.Any(ext => fileName.EndsWith(ext, StringComparison.OrdinalIgnoreCase));
        }

        public string SaveToRoot(string namaFile)
        {
            return Path.GetFullPath(namaFile);
        }
    }
}
