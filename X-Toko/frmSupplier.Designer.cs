namespace X_Toko
{
    partial class frmSupplier
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
            this.gvSupplier = new System.Windows.Forms.DataGridView();
            this.grpSupplier = new System.Windows.Forms.GroupBox();
            this.BtnInput = new System.Windows.Forms.Button();
            this.txtNama01 = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtTelp01 = new System.Windows.Forms.TextBox();
            this.lblTelp = new System.Windows.Forms.Label();
            this.txtAlamat01 = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtNama02 = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelp02 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlamat02 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.CmbSave = new System.Windows.Forms.ComboBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            this.grpSupplier.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvSupplier
            // 
            this.gvSupplier.AllowUserToAddRows = false;
            this.gvSupplier.AllowUserToDeleteRows = false;
            this.gvSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSupplier.Location = new System.Drawing.Point(12, 182);
            this.gvSupplier.Name = "gvSupplier";
            this.gvSupplier.ReadOnly = true;
            this.gvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSupplier.Size = new System.Drawing.Size(748, 207);
            this.gvSupplier.TabIndex = 0;
            this.gvSupplier.TabStop = false;
            this.gvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvSupplier_CellClick);
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
            this.grpSupplier.TabIndex = 1;
            this.grpSupplier.TabStop = false;
            this.grpSupplier.Text = "Input Data Supplier";
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
            this.BtnInput.TabIndex = 3;
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
            this.lblAlamat.Size = new System.Drawing.Size(80, 13);
            this.lblAlamat.TabIndex = 0;
            this.lblAlamat.Text = "Alamat Supplier";
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
            this.lblNama.Size = new System.Drawing.Size(76, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Supplier";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.DimGray;
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnHapus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnHapus.Location = new System.Drawing.Point(203, 105);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(80, 40);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.txtNama02);
            this.groupBox2.Controls.Add(this.btnHapus);
            this.groupBox2.Controls.Add(this.btnSimpan);
            this.groupBox2.Controls.Add(this.btnBatal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTelp02);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAlamat02);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(384, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 156);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit atau Hapus Data Supplier";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEdit.Location = new System.Drawing.Point(117, 105);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 40);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // txtNama02
            // 
            this.txtNama02.Enabled = false;
            this.txtNama02.Location = new System.Drawing.Point(6, 40);
            this.txtNama02.Name = "txtNama02";
            this.txtNama02.Size = new System.Drawing.Size(229, 20);
            this.txtNama02.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DimGray;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSimpan.Location = new System.Drawing.Point(117, 105);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(80, 40);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.DimGray;
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBatal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBatal.Location = new System.Drawing.Point(203, 105);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(80, 40);
            this.btnBatal.TabIndex = 10;
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alamat Supplier";
            // 
            // txtTelp02
            // 
            this.txtTelp02.Enabled = false;
            this.txtTelp02.Location = new System.Drawing.Point(241, 40);
            this.txtTelp02.MaxLength = 15;
            this.txtTelp02.Name = "txtTelp02";
            this.txtTelp02.Size = new System.Drawing.Size(129, 20);
            this.txtTelp02.TabIndex = 5;
            this.txtTelp02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 19);
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
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nama Supplier";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(12, 148);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(260, 20);
            this.txtCari.TabIndex = 5;
            this.txtCari.TextChanged += new System.EventHandler(this.TxtCari_TextChanged);
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(12, 132);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(97, 13);
            this.lblCari.TabIndex = 6;
            this.lblCari.Text = "Cari Nama Supplier";
            // 
            // CmbSave
            // 
            this.CmbSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSave.FormattingEnabled = true;
            this.CmbSave.Items.AddRange(new object[] {
            "PDF",
            "XLSX"});
            this.CmbSave.Location = new System.Drawing.Point(278, 148);
            this.CmbSave.Name = "CmbSave";
            this.CmbSave.Size = new System.Drawing.Size(100, 21);
            this.CmbSave.TabIndex = 8;
            this.CmbSave.SelectedIndexChanged += new System.EventHandler(this.CmbSave_SelectedIndexChanged);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(275, 132);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(46, 13);
            this.lblSave.TabIndex = 10;
            this.lblSave.Text = "Save as";
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 401);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.CmbSave);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.gvSupplier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Data Supplier";
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            this.grpSupplier.ResumeLayout(false);
            this.grpSupplier.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSupplier;
        private System.Windows.Forms.GroupBox grpSupplier;
        private System.Windows.Forms.TextBox txtNama01;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtTelp01;
        private System.Windows.Forms.Label lblTelp;
        private System.Windows.Forms.TextBox txtAlamat01;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Button BtnInput;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNama02;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelp02;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlamat02;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.ComboBox CmbSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.ToolTip toolTip;
    }
}