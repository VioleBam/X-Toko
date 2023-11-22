using System.Collections.Generic;

namespace X_Toko.Data
{
    public partial class Properti
    {
        public long PropertiID { get; set; }
        public string PropertiKode { get; set; }
        public string PropertiNama { get; set; }
        public string PropertiAlamat { get; set; }
        public string PropertiTelepon { get; set; }
        public List<Barang> DaftarBarang { get; private set; } = new List<Barang>();

        public void TambahBarang(Barang barang)
        {
            DaftarBarang.Add(barang);
        }
    }
}
