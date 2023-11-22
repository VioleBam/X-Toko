namespace X_Toko
{
    partial class frmCustomer02
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
            this.grpCust = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblGaris = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.lblNama01 = new System.Windows.Forms.Label();
            this.txtNama01 = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.lblTelp = new System.Windows.Forms.Label();
            this.txtNama02 = new System.Windows.Forms.TextBox();
            this.lblNama02 = new System.Windows.Forms.Label();
            this.radioPilih = new System.Windows.Forms.RadioButton();
            this.radioInput = new System.Windows.Forms.RadioButton();
            this.grpCust.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCust
            // 
            this.grpCust.Controls.Add(this.btnPrint);
            this.grpCust.Controls.Add(this.lblGaris);
            this.grpCust.Controls.Add(this.btnCari);
            this.grpCust.Controls.Add(this.lblNama01);
            this.grpCust.Controls.Add(this.txtNama01);
            this.grpCust.Controls.Add(this.btnSimpan);
            this.grpCust.Controls.Add(this.txtAlamat);
            this.grpCust.Controls.Add(this.lblAlamat);
            this.grpCust.Controls.Add(this.txtTelp);
            this.grpCust.Controls.Add(this.lblTelp);
            this.grpCust.Controls.Add(this.txtNama02);
            this.grpCust.Controls.Add(this.lblNama02);
            this.grpCust.Location = new System.Drawing.Point(12, 35);
            this.grpCust.Name = "grpCust";
            this.grpCust.Size = new System.Drawing.Size(347, 194);
            this.grpCust.TabIndex = 0;
            this.grpCust.TabStop = false;
            this.grpCust.Text = "Data Customer";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(215, 142);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(127, 33);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblGaris
            // 
            this.lblGaris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGaris.Location = new System.Drawing.Point(6, 76);
            this.lblGaris.Name = "lblGaris";
            this.lblGaris.Size = new System.Drawing.Size(333, 2);
            this.lblGaris.TabIndex = 11;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(264, 36);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 10;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // lblNama01
            // 
            this.lblNama01.AutoSize = true;
            this.lblNama01.Location = new System.Drawing.Point(7, 23);
            this.lblNama01.Name = "lblNama01";
            this.lblNama01.Size = new System.Drawing.Size(38, 13);
            this.lblNama01.TabIndex = 9;
            this.lblNama01.Text = "Nama ";
            // 
            // txtNama01
            // 
            this.txtNama01.Location = new System.Drawing.Point(6, 39);
            this.txtNama01.Name = "txtNama01";
            this.txtNama01.Size = new System.Drawing.Size(254, 20);
            this.txtNama01.TabIndex = 7;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(214, 142);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(127, 33);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(8, 149);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(201, 20);
            this.txtAlamat.TabIndex = 5;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(8, 133);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(39, 13);
            this.lblAlamat.TabIndex = 4;
            this.lblAlamat.Text = "Alamat";
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(214, 110);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(127, 20);
            this.txtTelp.TabIndex = 3;
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(214, 94);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(46, 13);
            this.lblTelp.TabIndex = 2;
            this.lblTelp.Text = "Telepon";
            // 
            // txtNama02
            // 
            this.txtNama02.Location = new System.Drawing.Point(8, 110);
            this.txtNama02.Name = "txtNama02";
            this.txtNama02.Size = new System.Drawing.Size(201, 20);
            this.txtNama02.TabIndex = 1;
            // 
            // lblNama02
            // 
            this.lblNama02.AutoSize = true;
            this.lblNama02.Location = new System.Drawing.Point(8, 94);
            this.lblNama02.Name = "lblNama02";
            this.lblNama02.Size = new System.Drawing.Size(38, 13);
            this.lblNama02.TabIndex = 0;
            this.lblNama02.Text = "Nama ";
            // 
            // radioPilih
            // 
            this.radioPilih.AutoSize = true;
            this.radioPilih.Location = new System.Drawing.Point(18, 12);
            this.radioPilih.Name = "radioPilih";
            this.radioPilih.Size = new System.Drawing.Size(91, 17);
            this.radioPilih.TabIndex = 1;
            this.radioPilih.TabStop = true;
            this.radioPilih.Text = "Pilih Customer";
            this.radioPilih.UseVisualStyleBackColor = true;
            this.radioPilih.CheckedChanged += new System.EventHandler(this.radioPilih_CheckedChanged);
            // 
            // radioInput
            // 
            this.radioInput.AutoSize = true;
            this.radioInput.Location = new System.Drawing.Point(185, 12);
            this.radioInput.Name = "radioInput";
            this.radioInput.Size = new System.Drawing.Size(96, 17);
            this.radioInput.TabIndex = 2;
            this.radioInput.TabStop = true;
            this.radioInput.Text = "Input Customer";
            this.radioInput.UseVisualStyleBackColor = true;
            this.radioInput.CheckedChanged += new System.EventHandler(this.radioInput_CheckedChanged);
            // 
            // frmCustomer02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 244);
            this.Controls.Add(this.radioInput);
            this.Controls.Add(this.radioPilih);
            this.Controls.Add(this.grpCust);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomer02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Data Customer";
            this.Load += new System.EventHandler(this.frmCustomer02_Load);
            this.grpCust.ResumeLayout(false);
            this.grpCust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCust;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.Label lblTelp;
        private System.Windows.Forms.TextBox txtNama02;
        private System.Windows.Forms.Label lblNama02;
        private System.Windows.Forms.RadioButton radioPilih;
        private System.Windows.Forms.RadioButton radioInput;
        private System.Windows.Forms.TextBox txtNama01;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label lblNama01;
        private System.Windows.Forms.Label lblGaris;
        private System.Windows.Forms.Button btnPrint;
    }
}