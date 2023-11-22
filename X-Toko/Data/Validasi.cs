namespace X_Toko.Data
{
    public class Validasi
    {
        private Pesan pesan = new Pesan();

        public bool ValidasiForm(params System.Tuple<string, bool>[] values)
        {
            
            foreach (var value in values)
            {
                string input = value.Item1;
                bool isNumeric = value.Item2;

                if (string.IsNullOrWhiteSpace(input))
                {
                    pesan.IsiPesan = $"Error: Harap semua kolom pada form diisi.";
                    return false;
                }

                if (isNumeric && !IsValidNumber(input))
                {
                    pesan.IsiPesan = $"Error: Tidak bisa diisi dengan {input}, harap ganti dengan angka.";
                    return false;
                }
            }
            return true;
        }

        private bool IsValidNumber(string input)
        {
            return int.TryParse(input, out _) || long.TryParse(input, out _);
        }

        public string FormatMataUang(double nilai)
        {
            // Menggunakan string.Format untuk memformat nilai dalam format mata uang yang diinginkan
            return string.Format("Rp. {0:#,##0},-", nilai);
        }
    }

}
