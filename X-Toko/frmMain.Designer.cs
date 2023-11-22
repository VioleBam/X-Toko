namespace X_Toko
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.grpLaporan = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLabaRugi = new System.Windows.Forms.Button();
            this.grpMaster = new System.Windows.Forms.GroupBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.sysTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPembelian = new System.Windows.Forms.TabPage();
            this.tcTransaksi = new System.Windows.Forms.TabControl();
            this.tabPenjualan = new System.Windows.Forms.TabPage();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblKode = new System.Windows.Forms.Label();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btnCariBarang = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblBeli = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtTotalHarga = new System.Windows.Forms.TextBox();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.lblTotalJual = new System.Windows.Forms.Label();
            this.lblRp = new System.Windows.Forms.Label();
            this.gvTransaksi = new System.Windows.Forms.DataGridView();
            this.printDlg = new System.Windows.Forms.PrintDialog();
            this.prntPrvDlg = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTop.SuspendLayout();
            this.grpLaporan.SuspendLayout();
            this.grpMaster.SuspendLayout();
            this.tcTransaksi.SuspendLayout();
            this.tabPenjualan.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransaksi)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.DimGray;
            this.pnlTop.Controls.Add(this.lblDeskripsi);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.btnSetting);
            this.pnlTop.Controls.Add(this.grpLaporan);
            this.pnlTop.Controls.Add(this.grpMaster);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(830, 95);
            this.pnlTop.TabIndex = 0;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskripsi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeskripsi.Location = new System.Drawing.Point(10, 53);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(210, 32);
            this.lblDeskripsi.TabIndex = 12;
            this.lblDeskripsi.Text = "POINT OF SALES";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(24, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 65);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "X-Toko";
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Location = new System.Drawing.Point(662, 15);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 70);
            this.btnSetting.TabIndex = 10;
            this.btnSetting.TabStop = false;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // grpLaporan
            // 
            this.grpLaporan.Controls.Add(this.button1);
            this.grpLaporan.Controls.Add(this.btnLabaRugi);
            this.grpLaporan.ForeColor = System.Drawing.SystemColors.Window;
            this.grpLaporan.Location = new System.Drawing.Point(486, 10);
            this.grpLaporan.Name = "grpLaporan";
            this.grpLaporan.Size = new System.Drawing.Size(170, 75);
            this.grpLaporan.TabIndex = 9;
            this.grpLaporan.TabStop = false;
            this.grpLaporan.Text = "Laporan";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(87, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "Transaksi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLabaRugi
            // 
            this.btnLabaRugi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLabaRugi.Location = new System.Drawing.Point(6, 19);
            this.btnLabaRugi.Name = "btnLabaRugi";
            this.btnLabaRugi.Size = new System.Drawing.Size(75, 50);
            this.btnLabaRugi.TabIndex = 5;
            this.btnLabaRugi.TabStop = false;
            this.btnLabaRugi.Text = "Transaksi";
            this.btnLabaRugi.UseVisualStyleBackColor = true;
            // 
            // grpMaster
            // 
            this.grpMaster.BackColor = System.Drawing.Color.DimGray;
            this.grpMaster.Controls.Add(this.btnCustomer);
            this.grpMaster.Controls.Add(this.btnBarang);
            this.grpMaster.Controls.Add(this.btnSupplier);
            this.grpMaster.ForeColor = System.Drawing.SystemColors.Window;
            this.grpMaster.Location = new System.Drawing.Point(230, 10);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(250, 75);
            this.grpMaster.TabIndex = 8;
            this.grpMaster.TabStop = false;
            this.grpMaster.Text = "Master Data";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCustomer.Location = new System.Drawing.Point(87, 19);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 50);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.TabStop = false;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // btnBarang
            // 
            this.btnBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBarang.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBarang.Location = new System.Drawing.Point(168, 19);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(75, 50);
            this.btnBarang.TabIndex = 4;
            this.btnBarang.TabStop = false;
            this.btnBarang.Text = "Barang";
            this.btnBarang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBarang.UseVisualStyleBackColor = true;
            this.btnBarang.Click += new System.EventHandler(this.BtnBarang_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSupplier.Location = new System.Drawing.Point(6, 19);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(75, 50);
            this.btnSupplier.TabIndex = 5;
            this.btnSupplier.TabStop = false;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.BtnSupplier_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(743, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 70);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Keluar";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnTransaksi.Location = new System.Drawing.Point(389, 324);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(75, 56);
            this.btnTransaksi.TabIndex = 6;
            this.btnTransaksi.TabStop = false;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.BtnTransaksi_Click);
            // 
            // sysTray
            // 
            this.sysTray.Icon = ((System.Drawing.Icon)(resources.GetObject("sysTray.Icon")));
            this.sysTray.Text = "X-Toko POS Application";
            this.sysTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Systray_MouseDoubleClick);
            // 
            // tabPembelian
            // 
            this.tabPembelian.Location = new System.Drawing.Point(4, 22);
            this.tabPembelian.Name = "tabPembelian";
            this.tabPembelian.Padding = new System.Windows.Forms.Padding(3);
            this.tabPembelian.Size = new System.Drawing.Size(798, 392);
            this.tabPembelian.TabIndex = 1;
            this.tabPembelian.Text = "Pembelian";
            this.tabPembelian.UseVisualStyleBackColor = true;
            // 
            // tcTransaksi
            // 
            this.tcTransaksi.Controls.Add(this.tabPenjualan);
            this.tcTransaksi.Controls.Add(this.tabPembelian);
            this.tcTransaksi.Location = new System.Drawing.Point(12, 101);
            this.tcTransaksi.Name = "tcTransaksi";
            this.tcTransaksi.SelectedIndex = 0;
            this.tcTransaksi.Size = new System.Drawing.Size(806, 418);
            this.tcTransaksi.TabIndex = 11;
            // 
            // tabPenjualan
            // 
            this.tabPenjualan.BackColor = System.Drawing.Color.White;
            this.tabPenjualan.Controls.Add(this.btnTransaksi);
            this.tabPenjualan.Controls.Add(this.grpInput);
            this.tabPenjualan.Controls.Add(this.groupBox1);
            this.tabPenjualan.Controls.Add(this.grpTotal);
            this.tabPenjualan.Controls.Add(this.gvTransaksi);
            this.tabPenjualan.Location = new System.Drawing.Point(4, 22);
            this.tabPenjualan.Name = "tabPenjualan";
            this.tabPenjualan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPenjualan.Size = new System.Drawing.Size(798, 392);
            this.tabPenjualan.TabIndex = 0;
            this.tabPenjualan.Text = "Penjualan";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.lblKode);
            this.grpInput.Controls.Add(this.txtKodeBarang);
            this.grpInput.Controls.Add(this.lblTanggal);
            this.grpInput.Controls.Add(this.dateTime);
            this.grpInput.Controls.Add(this.btnCariBarang);
            this.grpInput.Controls.Add(this.btnAdd);
            this.grpInput.Controls.Add(this.lblTotal);
            this.grpInput.Controls.Add(this.lblNama);
            this.grpInput.Controls.Add(this.lblBeli);
            this.grpInput.Controls.Add(this.txtNamaBarang);
            this.grpInput.Controls.Add(this.lblQty);
            this.grpInput.Controls.Add(this.txtTotalHarga);
            this.grpInput.Controls.Add(this.lblTotalHarga);
            this.grpInput.Controls.Add(this.txtHarga);
            this.grpInput.Controls.Add(this.txtQty);
            this.grpInput.Location = new System.Drawing.Point(7, 6);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(785, 64);
            this.grpInput.TabIndex = 15;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input Transaksi";
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(112, 16);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(69, 13);
            this.lblKode.TabIndex = 9;
            this.lblKode.Text = "Kode Barang";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Enabled = false;
            this.txtKodeBarang.Location = new System.Drawing.Point(115, 31);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(109, 20);
            this.txtKodeBarang.TabIndex = 10;
            this.txtKodeBarang.TabStop = false;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(9, 15);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(46, 13);
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "Tanggal";
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(12, 31);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(97, 20);
            this.dateTime.TabIndex = 0;
            // 
            // btnCariBarang
            // 
            this.btnCariBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariBarang.Location = new System.Drawing.Point(386, 30);
            this.btnCariBarang.Name = "btnCariBarang";
            this.btnCariBarang.Size = new System.Drawing.Size(50, 22);
            this.btnCariBarang.TabIndex = 1;
            this.btnCariBarang.Text = "Cari";
            this.btnCariBarang.UseVisualStyleBackColor = true;
            this.btnCariBarang.Click += new System.EventHandler(this.BtnCariBarang_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(701, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(594, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(227, 15);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(72, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Barang";
            // 
            // lblBeli
            // 
            this.lblBeli.AutoSize = true;
            this.lblBeli.Location = new System.Drawing.Point(486, 15);
            this.lblBeli.Name = "lblBeli";
            this.lblBeli.Size = new System.Drawing.Size(36, 13);
            this.lblBeli.TabIndex = 0;
            this.lblBeli.Text = "Harga";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Enabled = false;
            this.txtNamaBarang.Location = new System.Drawing.Point(230, 31);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(150, 20);
            this.txtNamaBarang.TabIndex = 0;
            this.txtNamaBarang.TabStop = false;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(440, 15);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "Qty";
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Enabled = false;
            this.txtTotalHarga.Location = new System.Drawing.Point(595, 31);
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.Size = new System.Drawing.Size(100, 20);
            this.txtTotalHarga.TabIndex = 0;
            this.txtTotalHarga.TabStop = false;
            this.txtTotalHarga.Text = "Rp. 0,-";
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.Location = new System.Drawing.Point(511, 16);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(0, 13);
            this.lblTotalHarga.TabIndex = 8;
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Location = new System.Drawing.Point(489, 31);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 0;
            this.txtHarga.TabStop = false;
            this.txtHarga.Text = "Rp. 0,-";
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(442, 31);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(41, 20);
            this.txtQty.TabIndex = 2;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.TxtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQty_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Location = new System.Drawing.Point(6, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 76);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Database";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(6, 16);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(98, 54);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            //this.btnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.lblTotalJual);
            this.grpTotal.Controls.Add(this.lblRp);
            this.grpTotal.Location = new System.Drawing.Point(470, 310);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(322, 76);
            this.grpTotal.TabIndex = 12;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "TOTAL HARGA";
            // 
            // lblTotalJual
            // 
            this.lblTotalJual.AutoSize = true;
            this.lblTotalJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalJual.Location = new System.Drawing.Point(83, 22);
            this.lblTotalJual.Name = "lblTotalJual";
            this.lblTotalJual.Size = new System.Drawing.Size(61, 42);
            this.lblTotalJual.TabIndex = 1;
            this.lblTotalJual.Text = "0,-";
            // 
            // lblRp
            // 
            this.lblRp.AutoSize = true;
            this.lblRp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRp.Location = new System.Drawing.Point(15, 22);
            this.lblRp.Name = "lblRp";
            this.lblRp.Size = new System.Drawing.Size(76, 42);
            this.lblRp.TabIndex = 0;
            this.lblRp.Text = "Rp.";
            // 
            // gvTransaksi
            // 
            this.gvTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTransaksi.Location = new System.Drawing.Point(6, 76);
            this.gvTransaksi.Name = "gvTransaksi";
            this.gvTransaksi.Size = new System.Drawing.Size(786, 228);
            this.gvTransaksi.TabIndex = 0;
            this.gvTransaksi.TabStop = false;
            // 
            // printDlg
            // 
            this.printDlg.UseEXDialog = true;
            // 
            // prntPrvDlg
            // 
            this.prntPrvDlg.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prntPrvDlg.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prntPrvDlg.ClientSize = new System.Drawing.Size(400, 300);
            this.prntPrvDlg.Enabled = true;
            this.prntPrvDlg.Icon = ((System.Drawing.Icon)(resources.GetObject("prntPrvDlg.Icon")));
            this.prntPrvDlg.Name = "prntPrvDlg";
            this.prntPrvDlg.Visible = false;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 534);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(830, 22);
            this.StatusStrip.TabIndex = 12;
            this.StatusStrip.Click += new System.EventHandler(this.StatusStrip_Click);
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(152, 17);
            this.StatusStripLabel.Text = "Cek File Konfigurasi dan DB";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 556);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.tcTransaksi);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X-Toko - Aplikasi Point Of Sale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpLaporan.ResumeLayout(false);
            this.grpMaster.ResumeLayout(false);
            this.tcTransaksi.ResumeLayout(false);
            this.tabPenjualan.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransaksi)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.GroupBox grpMaster;
        private System.Windows.Forms.GroupBox grpLaporan;
        private System.Windows.Forms.Button btnLabaRugi;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TabPage tabPembelian;
        private System.Windows.Forms.TabControl tcTransaksi;
        private System.Windows.Forms.TabPage tabPenjualan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Label lblTotalJual;
        private System.Windows.Forms.Label lblRp;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBeli;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.TextBox txtTotalHarga;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.DataGridView gvTransaksi;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button btnCariBarang;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PrintDialog printDlg;
        private System.Windows.Forms.PrintPreviewDialog prntPrvDlg;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NotifyIcon sysTray;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripLabel;
    }
}

