using System;
using X_Toko.Data;
using System.Drawing;
using System.Windows.Forms;

namespace X_Toko
{
    public partial class frmCustomer02 : Form
    {
        private Pesan pesan = new Pesan();
        private Validasi val = new Validasi();
        private Properti properti = new Properti();

        public frmCustomer02()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void frmCustomer02_Load(object sender, EventArgs e)
        {
            radioPilih.Checked = true;
            radioPilih_CheckedChanged(sender, e);
        }

        private void radioPilih_CheckedChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = true;
            btnPrint.Visible = true;
            btnSimpan.Enabled = false;
            btnSimpan.Visible = false;
            txtNama01.Enabled = true;
            btnCari.Enabled = true;
            txtNama02.Enabled = false;
            txtTelp.Enabled = false;
            txtAlamat.Enabled = false;
        }

        private void radioInput_CheckedChanged(object sender, EventArgs e)
        {
            btnSimpan.Enabled = true;
            btnSimpan.Visible = true;
            btnPrint.Enabled = false;
            btnPrint.Visible = false;
            txtNama01.Enabled = false;
            btnCari.Enabled = false;
            txtNama02.Enabled = true;
            txtTelp.Enabled = true;
            txtAlamat.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!val.ValidasiForm(Tuple.Create(txtNama01.Text, false),Tuple.Create(txtAlamat.Text, false),Tuple.Create(txtTelp.Text, true)))
                MessageBox.Show(pesan.IsiPesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                properti.PropertiNama       = txtNama02.Text;
                properti.PropertiTelepon    = txtTelp.Text;
                properti.PropertiAlamat     = txtAlamat.Text;
                Close();
            }
        }
    }
}
