namespace X_Toko
{
    partial class frmBarang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvBarang = new System.Windows.Forms.DataGridView();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama01 = new System.Windows.Forms.TextBox();
            this.txtJual01 = new System.Windows.Forms.TextBox();
            this.lblJual = new System.Windows.Forms.Label();
            this.txtBeli01 = new System.Windows.Forms.TextBox();
            this.lblBeli = new System.Windows.Forms.Label();
            this.txtStok01 = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpEditHapus = new System.Windows.Forms.GroupBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtNama02 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStok02 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBeli02 = new System.Windows.Forms.TextBox();
            this.txtJual02 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvBarang)).BeginInit();
            this.grpInput.SuspendLayout();
            this.grpStock.SuspendLayout();
            this.grpEditHapus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvBarang
            // 
            this.gvBarang.AllowUserToAddRows = false;
            this.gvBarang.AllowUserToDeleteRows = false;
            this.gvBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBarang.Location = new System.Drawing.Point(15, 181);
            this.gvBarang.MultiSelect = false;
            this.gvBarang.Name = "gvBarang";
            this.gvBarang.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBarang.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBarang.Size = new System.Drawing.Size(807, 245);
            this.gvBarang.TabIndex = 99;
            this.gvBarang.TabStop = false;
            this.gvBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBarang_CellClick);
            //this.gvBarang.SelectionChanged += new System.EventHandler(this.gvBarang_SelectionChanged);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(9, 116);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(225, 21);
            this.cmbSupplier.TabIndex = 3;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(6, 24);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(72, 13);
            this.lblNama.TabIndex = 6;
            this.lblNama.Text = "Nama Barang";
            // 
            // txtNama01
            // 
            this.txtNama01.Location = new System.Drawing.Point(9, 40);
            this.txtNama01.Name = "txtNama01";
            this.txtNama01.Size = new System.Drawing.Size(237, 20);
            this.txtNama01.TabIndex = 7;
            // 
            // txtJual01
            // 
            this.txtJual01.Location = new System.Drawing.Point(126, 79);
            this.txtJual01.Name = "txtJual01";
            this.txtJual01.Size = new System.Drawing.Size(110, 20);
            this.txtJual01.TabIndex = 9;
            // 
            // lblJual
            // 
            this.lblJual.AutoSize = true;
            this.lblJual.Location = new System.Drawing.Point(123, 63);
            this.lblJual.Name = "lblJual";
            this.lblJual.Size = new System.Drawing.Size(58, 13);
            this.lblJual.TabIndex = 8;
            this.lblJual.Text = "Harga Jual";
            // 
            // txtBeli01
            // 
            this.txtBeli01.Location = new System.Drawing.Point(9, 79);
            this.txtBeli01.Name = "txtBeli01";
            this.txtBeli01.Size = new System.Drawing.Size(110, 20);
            this.txtBeli01.TabIndex = 11;
            // 
            // lblBeli
            // 
            this.lblBeli.AutoSize = true;
            this.lblBeli.Location = new System.Drawing.Point(6, 63);
            this.lblBeli.Name = "lblBeli";
            this.lblBeli.Size = new System.Drawing.Size(56, 13);
            this.lblBeli.TabIndex = 10;
            this.lblBeli.Text = "Harga Beli";
            // 
            // txtStok01
            // 
            this.txtStok01.Location = new System.Drawing.Point(252, 40);
            this.txtStok01.Name = "txtStok01";
            this.txtStok01.Size = new System.Drawing.Size(63, 20);
            this.txtStok01.TabIndex = 13;
            this.txtStok01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(249, 24);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(66, 13);
            this.lblStok.TabIndex = 12;
            this.lblStok.Text = "Stok Barang";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(240, 77);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 70);
            this.btnInput.TabIndex = 14;
            this.btnInput.Text = "Input Data";
            this.btnInput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInputBarang_Click);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.lblNama);
            this.grpInput.Controls.Add(this.txtNama01);
            this.grpInput.Controls.Add(this.lblBeli);
            this.grpInput.Controls.Add(this.btnInput);
            this.grpInput.Controls.Add(this.lblSupplier);
            this.grpInput.Controls.Add(this.cmbSupplier);
            this.grpInput.Controls.Add(this.txtStok01);
            this.grpInput.Controls.Add(this.lblStok);
            this.grpInput.Controls.Add(this.lblJual);
            this.grpInput.Controls.Add(this.txtBeli01);
            this.grpInput.Controls.Add(this.txtJual01);
            this.grpInput.Location = new System.Drawing.Point(15, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(324, 163);
            this.grpInput.TabIndex = 16;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input Data Barang";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(6, 102);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Supplier";
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.btnKurang);
            this.grpStock.Controls.Add(this.btnTambah);
            this.grpStock.Controls.Add(this.txtUpdate);
            this.grpStock.Location = new System.Drawing.Point(712, 12);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(110, 163);
            this.grpStock.TabIndex = 17;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Update Stock";
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(30, 102);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(50, 50);
            this.btnKurang.TabIndex = 2;
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(30, 44);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(50, 50);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(9, 19);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(92, 20);
            this.txtUpdate.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(273, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 70);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteBarang_Click);
            // 
            // grpEditHapus
            // 
            this.grpEditHapus.Controls.Add(this.btnBatal);
            this.grpEditHapus.Controls.Add(this.btnSimpan);
            this.grpEditHapus.Controls.Add(this.btnDelete);
            this.grpEditHapus.Controls.Add(this.label1);
            this.grpEditHapus.Controls.Add(this.btnEdit);
            this.grpEditHapus.Controls.Add(this.txtNama02);
            this.grpEditHapus.Controls.Add(this.label2);
            this.grpEditHapus.Controls.Add(this.txtStok02);
            this.grpEditHapus.Controls.Add(this.label4);
            this.grpEditHapus.Controls.Add(this.label5);
            this.grpEditHapus.Controls.Add(this.txtBeli02);
            this.grpEditHapus.Controls.Add(this.txtJual02);
            this.grpEditHapus.Location = new System.Drawing.Point(345, 12);
            this.grpEditHapus.Name = "grpEditHapus";
            this.grpEditHapus.Size = new System.Drawing.Size(361, 163);
            this.grpEditHapus.TabIndex = 100;
            this.grpEditHapus.TabStop = false;
            this.grpEditHapus.Text = "Edit atau Hapus Data Barang";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(273, 79);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 70);
            this.btnBatal.TabIndex = 17;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(192, 79);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 70);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan ";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nama Barang";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(192, 79);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 70);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtNama02
            // 
            this.txtNama02.Enabled = false;
            this.txtNama02.Location = new System.Drawing.Point(9, 40);
            this.txtNama02.Name = "txtNama02";
            this.txtNama02.Size = new System.Drawing.Size(251, 20);
            this.txtNama02.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Harga Beli";
            // 
            // txtStok02
            // 
            this.txtStok02.Enabled = false;
            this.txtStok02.Location = new System.Drawing.Point(266, 40);
            this.txtStok02.Name = "txtStok02";
            this.txtStok02.Size = new System.Drawing.Size(82, 20);
            this.txtStok02.TabIndex = 13;
            this.txtStok02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stok Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harga Jual";
            // 
            // txtBeli02
            // 
            this.txtBeli02.Enabled = false;
            this.txtBeli02.Location = new System.Drawing.Point(9, 79);
            this.txtBeli02.Name = "txtBeli02";
            this.txtBeli02.Size = new System.Drawing.Size(177, 20);
            this.txtBeli02.TabIndex = 11;
            // 
            // txtJual02
            // 
            this.txtJual02.Enabled = false;
            this.txtJual02.Location = new System.Drawing.Point(9, 118);
            this.txtJual02.Name = "txtJual02";
            this.txtJual02.Size = new System.Drawing.Size(179, 20);
            this.txtJual02.TabIndex = 9;
            // 
            // frmBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 438);
            this.Controls.Add(this.grpEditHapus);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.gvBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Data Barang";
            this.Load += new System.EventHandler(this.FrmBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBarang)).EndInit();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            this.grpEditHapus.ResumeLayout(false);
            this.grpEditHapus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBarang;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama01;
        private System.Windows.Forms.TextBox txtJual01;
        private System.Windows.Forms.Label lblJual;
        private System.Windows.Forms.TextBox txtBeli01;
        private System.Windows.Forms.Label lblBeli;
        private System.Windows.Forms.TextBox txtStok01;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.GroupBox grpEditHapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtStok02;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBeli02;
        private System.Windows.Forms.TextBox txtJual02;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
    }
}