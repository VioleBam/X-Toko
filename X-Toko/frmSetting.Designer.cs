namespace X_Toko
{
    partial class FrmSetting
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
            this.grpDB = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtLokasi = new System.Windows.Forms.TextBox();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openDB = new System.Windows.Forms.OpenFileDialog();
            this.grpToko = new System.Windows.Forms.GroupBox();
            this.btnEditToko = new System.Windows.Forms.Button();
            this.btnSaveToko = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.chkCust = new System.Windows.Forms.CheckBox();
            this.lblCust = new System.Windows.Forms.Label();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.lblPrint = new System.Windows.Forms.Label();
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.saveBU = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpDB.SuspendLayout();
            this.grpToko.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDB
            // 
            this.grpDB.Controls.Add(this.btnOpen);
            this.grpDB.Controls.Add(this.btnCreate);
            this.grpDB.Controls.Add(this.txtLokasi);
            this.grpDB.Controls.Add(this.lblLokasi);
            this.grpDB.Location = new System.Drawing.Point(12, 156);
            this.grpDB.Name = "grpDB";
            this.grpDB.Size = new System.Drawing.Size(260, 133);
            this.grpDB.TabIndex = 0;
            this.grpDB.TabStop = false;
            this.grpDB.Text = "Database";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(53, 58);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 70);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open DB";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(134, 58);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 70);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create DB";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // txtLokasi
            // 
            this.txtLokasi.Enabled = false;
            this.txtLokasi.Location = new System.Drawing.Point(9, 32);
            this.txtLokasi.Name = "txtLokasi";
            this.txtLokasi.Size = new System.Drawing.Size(245, 20);
            this.txtLokasi.TabIndex = 2;
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Location = new System.Drawing.Point(6, 16);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(87, 13);
            this.lblLokasi.TabIndex = 1;
            this.lblLokasi.Text = "Lokasi Database";
            // 
            // openDB
            // 
            this.openDB.FileName = "openDB";
            // 
            // grpToko
            // 
            this.grpToko.Controls.Add(this.btnEditToko);
            this.grpToko.Controls.Add(this.btnSaveToko);
            this.grpToko.Controls.Add(this.txtAlamat);
            this.grpToko.Controls.Add(this.lblAlamat);
            this.grpToko.Controls.Add(this.txtTelepon);
            this.grpToko.Controls.Add(this.lblTelepon);
            this.grpToko.Controls.Add(this.txtNama);
            this.grpToko.Controls.Add(this.lblNama);
            this.grpToko.Location = new System.Drawing.Point(12, 12);
            this.grpToko.Name = "grpToko";
            this.grpToko.Size = new System.Drawing.Size(260, 138);
            this.grpToko.TabIndex = 1;
            this.grpToko.TabStop = false;
            this.grpToko.Text = "Data Toko";
            // 
            // btnEditToko
            // 
            this.btnEditToko.Location = new System.Drawing.Point(6, 100);
            this.btnEditToko.Name = "btnEditToko";
            this.btnEditToko.Size = new System.Drawing.Size(100, 30);
            this.btnEditToko.TabIndex = 2;
            this.btnEditToko.Text = "Edit";
            this.btnEditToko.UseVisualStyleBackColor = true;
            this.btnEditToko.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnSaveToko
            // 
            this.btnSaveToko.Location = new System.Drawing.Point(154, 100);
            this.btnSaveToko.Name = "btnSaveToko";
            this.btnSaveToko.Size = new System.Drawing.Size(100, 30);
            this.btnSaveToko.TabIndex = 7;
            this.btnSaveToko.Text = "Simpan";
            this.btnSaveToko.UseVisualStyleBackColor = true;
            this.btnSaveToko.Click += new System.EventHandler(this.BtnSimpanToko_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(9, 74);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(245, 20);
            this.txtAlamat.TabIndex = 5;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(6, 58);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(39, 13);
            this.lblAlamat.TabIndex = 6;
            this.lblAlamat.Text = "Alamat";
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(166, 36);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(88, 20);
            this.txtTelepon.TabIndex = 3;
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Location = new System.Drawing.Point(163, 20);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(46, 13);
            this.lblTelepon.TabIndex = 4;
            this.lblTelepon.Text = "Telepon";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(9, 36);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(151, 20);
            this.txtNama.TabIndex = 2;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(6, 20);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(63, 13);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama Toko";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.btnSetting);
            this.grpGeneral.Controls.Add(this.chkPreview);
            this.grpGeneral.Controls.Add(this.lblPreview);
            this.grpGeneral.Controls.Add(this.chkCust);
            this.grpGeneral.Controls.Add(this.lblCust);
            this.grpGeneral.Controls.Add(this.chkPrint);
            this.grpGeneral.Controls.Add(this.lblPrint);
            this.grpGeneral.Location = new System.Drawing.Point(278, 12);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(259, 171);
            this.grpGeneral.TabIndex = 2;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "Setting Umum";
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(178, 95);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 70);
            this.btnSetting.TabIndex = 24;
            this.btnSetting.Text = "Simpan";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.BtnSimpanSetting_Click);
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Checked = true;
            this.chkPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreview.Location = new System.Drawing.Point(10, 38);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(15, 14);
            this.chkPreview.TabIndex = 23;
            this.chkPreview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkPreview.UseVisualStyleBackColor = true;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(27, 39);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(121, 13);
            this.lblPreview.TabIndex = 22;
            this.lblPreview.Text = "Tampilkan Print Preview";
            // 
            // chkCust
            // 
            this.chkCust.AutoSize = true;
            this.chkCust.Checked = true;
            this.chkCust.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCust.Location = new System.Drawing.Point(10, 57);
            this.chkCust.Name = "chkCust";
            this.chkCust.Size = new System.Drawing.Size(15, 14);
            this.chkCust.TabIndex = 21;
            this.chkCust.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkCust.UseVisualStyleBackColor = true;
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(27, 58);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(155, 13);
            this.lblCust.TabIndex = 20;
            this.lblCust.Text = "Cetak & Simpan Data Customer";
            this.lblCust.UseMnemonic = false;
            // 
            // chkPrint
            // 
            this.chkPrint.AutoSize = true;
            this.chkPrint.Checked = true;
            this.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrint.Location = new System.Drawing.Point(10, 20);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(15, 14);
            this.chkPrint.TabIndex = 19;
            this.chkPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkPrint.UseVisualStyleBackColor = true;
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(27, 20);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(77, 13);
            this.lblPrint.TabIndex = 18;
            this.lblPrint.Text = "Print Transaksi";
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.btnCustomer);
            this.grpBackup.Controls.Add(this.btnSupplier);
            this.grpBackup.Location = new System.Drawing.Point(278, 189);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(259, 100);
            this.grpBackup.TabIndex = 3;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "Ganti data DB dengan data dari Excel";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(134, 19);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 70);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(53, 19);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(75, 70);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.BtnSupplier_Click);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 298);
            this.Controls.Add(this.grpBackup);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.grpToko);
            this.Controls.Add(this.grpDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.grpDB.ResumeLayout(false);
            this.grpDB.PerformLayout();
            this.grpToko.ResumeLayout(false);
            this.grpToko.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpBackup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDB;
        private System.Windows.Forms.TextBox txtLokasi;
        private System.Windows.Forms.Label lblLokasi;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openDB;
        private System.Windows.Forms.GroupBox grpToko;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Button btnSaveToko;
        private System.Windows.Forms.Button btnEditToko;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.CheckBox chkCust;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.SaveFileDialog saveBU;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.ToolTip toolTip;
    }
}