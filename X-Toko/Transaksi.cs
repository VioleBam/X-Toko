using X_Toko.Data;

namespace X_Toko
{
    public class Transaksi 
    {
        private static string kode,tgl;
        private static double total;

        public string KodeTransaksi
        {
            get { return kode; }
            set { kode = value; }
        }

        public string TanggalTransaksi
        {
            get { return tgl; }
            set { tgl = value; }
        }

        public double TotalTransaksi
        {
            get { return total; }
            set { total = value; }
        }

        public void Reset()
        {
            KodeTransaksi = null;
            TanggalTransaksi = null;
            TotalTransaksi = 0;
        }
    }

    public class TransaksiBarang
    {
        private static int qty;
        private static double total;
        Barang brg = new Barang();
        Transaksi tr = new Transaksi();

        public int QtyTB
        {
            get { return qty; }
            set { qty = value; }
        }

        public double TotalTB
        {
            get { return QtyTB * brg.HargaJualBarang; }
            set { total = value; }
        }

        public string KodeBarangTB
        {
            get { return brg.KodeBarang.ToString(); }
        }

        public string KodeTransaksiTB
        {
            get { return tr.KodeTransaksi; }
        }

        public void Reset()
        {
            QtyTB = 0;
            TotalTB = 0;
        }
    }

    public class PrintTransaksi
    {
        public string NamaBarang { get; set; }
        public int QtyBarang { get; set; }
        public double HargaBarang { get; set; }
        public double TotalHarga { get; set; }
        public double JumlahTotal { get; set; }

        public PrintTransaksi()
        {
        }

        public PrintTransaksi (string namaBarang, int qty, int harga, int total, int jumlah) 
        {
            NamaBarang = namaBarang;
            QtyBarang = qty;
            HargaBarang = harga;
            TotalHarga = total;
            JumlahTotal = jumlah;
        }

        /*public String KodeTransaksi
        {
            get { return kd_tr; }
            set { kd_tr = value; }
        }*/
    }
}
