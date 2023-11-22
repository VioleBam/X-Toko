using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace X_Toko
{
    public partial class frmTransaksi : Form
    {
        public frmTransaksi()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void dt01_Enter(object sender, EventArgs e)
        {
            radioTgl01.Checked = true;
        }

         private void dt02_Enter(object sender, EventArgs e)
        {
            radioTgl02.Checked = true;
        }

        private void dt03_Enter(object sender, EventArgs e)
        {
            radioTgl02.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
