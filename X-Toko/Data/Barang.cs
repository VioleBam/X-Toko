namespace X_Toko.Data
{
    public partial class Barang
    {
        public long IDBarang { get; private set; }
        public string KodeBarang { get; private set; }
        public string NamaBarang { get; private set; }
        public int StokBarang { get; private set; }
        public double HargaBeliBarang { get; private set; }
        public double HargaJualBarang { get; private set; }
        public long IDSupplier { get; private set; }
        public Properti Properti { get; private set; }

        // Konstruktor tanpa parameter
        public Barang() { }

        // Konstruktor dengan parameter
        public Barang(string nama, int stok, double hargaBeli, double hargaJual, long idBarang = 0, string kode = "", long idSupplier = 0)
        {
            IDBarang = idBarang;
            KodeBarang = kode;
            NamaBarang = nama;
            HargaBeliBarang = hargaBeli;
            HargaJualBarang = hargaJual;
            StokBarang = stok;
            IDSupplier = idSupplier;
        }

        public void Clear()
        {
            IDBarang = 0;
            KodeBarang = string.Empty;
            NamaBarang = string.Empty;
            StokBarang = 0;
            HargaBeliBarang = 0.0;
            HargaJualBarang = 0.0;
            IDSupplier = 0;
            Properti = null;
        }

        public void SetID(bool id_barang, bool id_supplier, long nilai)
        {
            if (id_barang == true)
            {
                IDBarang = nilai;
            }

            if(id_supplier == true)
            {
                IDSupplier = nilai;
            }
        }

        public void SetKode(bool kode_barang, string nilai)
        {
            if (kode_barang == true)
            {
                KodeBarang = nilai;
            }
        }

        // Metode untuk validasi data Barang
        private bool IsValidBarang(Barang barang)
        {
            // Lakukan validasi sesuai kebutuhan (misalnya, pastikan harga tidak negatif, stok tidak negatif, dll.)
            return barang.HargaBeliBarang >= 0 && barang.HargaJualBarang >= 0 && barang.StokBarang >= 0;
        }
    }
}
