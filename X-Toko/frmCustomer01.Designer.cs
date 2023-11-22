namespace X_Toko
{
    partial class FrmCustomer01
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
            this.gvCustomer = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNama02 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelp02 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlamat02 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpSupplier = new System.Windows.Forms.GroupBox();
            this.BtnInput = new System.Windows.Forms.Button();
            this.txtNama01 = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtTelp01 = new System.Windows.Forms.TextBox();
            this.lblTelp = new System.Windows.Forms.Label();
            this.txtAlamat01 = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.cmbSave = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvCustomer
            // 
            this.gvCustomer.AllowUserToAddRows = false;
            this.gvCustomer.AllowUserToDeleteRows = false;
            this.gvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomer.Location = new System.Drawing.Point(12, 181);
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.ReadOnly = true;
            this.gvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCustomer.Size = new System.Drawing.Size(748, 207);
            this.gvCustomer.TabIndex = 5;
            this.gvCustomer.TabStop = false;
            this.gvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvCustomer_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnHapus);
            this.groupBox2.Controls.Add(this.BtnSimpan);
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Controls.Add(this.BtnBatal);
            this.groupBox2.Controls.Add(this.txtNama02);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTelp02);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAlamat02);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(384, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 155);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit atau Hapus Data Customer";
            // 
            // txtNama02
            // 
            this.txtNama02.Enabled = false;
            this.txtNama02.Location = new System.Drawing.Point(9, 40);
            this.txtNama02.Name = "txtNama02";
            this.txtNama02.Size = new System.Drawing.Size(222, 20);
            this.txtNama02.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alamat Customer";
            // 
            // txtTelp02
            // 
            this.txtTelp02.Enabled = false;
            this.txtTelp02.Location = new System.Drawing.Point(237, 40);
            this.txtTelp02.MaxLength = 15;
            this.txtTelp02.Name = "txtTelp02";
            this.txtTelp02.Size = new System.Drawing.Size(133, 20);
            this.txtTelp02.TabIndex = 5;
            this.txtTelp02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telepon";
            // 
            // txtAlamat02
            // 
            this.txtAlamat02.Enabled = false;
            this.txtAlamat02.Location = new System.Drawing.Point(9, 79);
            this.txtAlamat02.Name = "txtAlamat02";
            this.txtAlamat02.Size = new System.Drawing.Size(361, 20);
            this.txtAlamat02.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nama Customer";
            // 
            // grpSupplier
            // 
            this.grpSupplier.Controls.Add(this.BtnInput);
            this.grpSupplier.Controls.Add(this.txtNama01);
            this.grpSupplier.Controls.Add(this.lblAlamat);
            this.grpSupplier.Controls.Add(this.txtTelp01);
            this.grpSupplier.Controls.Add(this.lblTelp);
            this.grpSupplier.Controls.Add(this.txtAlamat01);
            this.grpSupplier.Controls.Add(this.lblNama);
            this.grpSupplier.Location = new System.Drawing.Point(12, 12);
            this.grpSupplier.Name = "grpSupplier";
            this.grpSupplier.Size = new System.Drawing.Size(366, 114);
            this.grpSupplier.TabIndex = 6;
            this.grpSupplier.TabStop = false;
            this.grpSupplier.Text = "Input Data Customer";
            // 
            // BtnInput
            // 
            this.BtnInput.BackColor = System.Drawing.Color.DimGray;
            this.BtnInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInput.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnInput.Location = new System.Drawing.Point(277, 33);
            this.BtnInput.Name = "BtnInput";
            this.BtnInput.Size = new System.Drawing.Size(75, 70);
            this.BtnInput.TabIndex = 4;
            this.BtnInput.UseVisualStyleBackColor = true;
            this.BtnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // txtNama01
            // 
            this.txtNama01.Location = new System.Drawing.Point(9, 40);
            this.txtNama01.Name = "txtNama01";
            this.txtNama01.Size = new System.Drawing.Size(148, 20);
            this.txtNama01.TabIndex = 0;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(6, 63);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(86, 13);
            this.lblAlamat.TabIndex = 0;
            this.lblAlamat.Text = "Alamat Customer";
            // 
            // txtTelp01
            // 
            this.txtTelp01.Location = new System.Drawing.Point(163, 40);
            this.txtTelp01.MaxLength = 15;
            this.txtTelp01.Name = "txtTelp01";
            this.txtTelp01.Size = new System.Drawing.Size(100, 20);
            this.txtTelp01.TabIndex = 1;
            this.txtTelp01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(160, 24);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(46, 13);
            this.lblTelp.TabIndex = 0;
            this.lblTelp.Text = "Telepon";
            // 
            // txtAlamat01
            // 
            this.txtAlamat01.Location = new System.Drawing.Point(9, 79);
            this.txtAlamat01.Name = "txtAlamat01";
            this.txtAlamat01.Size = new System.Drawing.Size(254, 20);
            this.txtAlamat01.TabIndex = 2;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(6, 24);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(82, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cari Nama Customer";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(12, 147);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(260, 20);
            this.txtCari.TabIndex = 8;
            this.txtCari.TextChanged += new System.EventHandler(this.TxtCari_TextChanged);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(275, 131);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(46, 13);
            this.lblSave.TabIndex = 12;
            this.lblSave.Text = "Save as";
            // 
            // cmbSave
            // 
            this.cmbSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSave.FormattingEnabled = true;
            this.cmbSave.Items.AddRange(new object[] {
            "PDF",
            "XLSX"});
            this.cmbSave.Location = new System.Drawing.Point(278, 146);
            this.cmbSave.Name = "cmbSave";
            this.cmbSave.Size = new System.Drawing.Size(100, 21);
            this.cmbSave.TabIndex = 11;
            this.cmbSave.SelectedIndexChanged += new System.EventHandler(this.CmbSave_SelectedIndexChanged);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.DimGray;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnEdit.Location = new System.Drawing.Point(117, 105);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(80, 40);
            this.BtnEdit.TabIndex = 11;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.BackColor = System.Drawing.Color.DimGray;
            this.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHapus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnHapus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnHapus.Location = new System.Drawing.Point(203, 105);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(80, 40);
            this.BtnHapus.TabIndex = 12;
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.DimGray;
            this.BtnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnSimpan.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnSimpan.Location = new System.Drawing.Point(117, 105);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(80, 40);
            this.BtnSimpan.TabIndex = 13;
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnBatal
            // 
            this.BtnBatal.BackColor = System.Drawing.Color.DimGray;
            this.BtnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBatal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnBatal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnBatal.Location = new System.Drawing.Point(203, 105);
            this.BtnBatal.Name = "BtnBatal";
            this.BtnBatal.Size = new System.Drawing.Size(80, 40);
            this.BtnBatal.TabIndex = 14;
            this.BtnBatal.UseVisualStyleBackColor = true;
            this.BtnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            // 
            // FrmCustomer01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 401);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.cmbSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.gvCustomer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomer01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Data Customer";
            this.Load += new System.EventHandler(this.FrmCustomer01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpSupplier.ResumeLayout(false);
            this.grpSupplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNama02;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelp02;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlamat02;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpSupplier;
        private System.Windows.Forms.TextBox txtNama01;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtTelp01;
        private System.Windows.Forms.Label lblTelp;
        private System.Windows.Forms.TextBox txtAlamat01;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.ComboBox cmbSave;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button BtnInput;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnBatal;
    }
}