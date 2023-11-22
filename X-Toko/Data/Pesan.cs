namespace X_Toko.Data
{
    public class Pesan
    {
        private static string _msg;
        public string IsiPesan
        {
            get => _msg;
            set => _msg = value;
        }
    }
}
