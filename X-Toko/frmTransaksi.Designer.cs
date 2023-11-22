namespace X_Toko
{
    partial class frmTransaksi
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
            this.gvTransaksi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKode = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTanggal = new System.Windows.Forms.Button();
            this.dt03 = new System.Windows.Forms.DateTimePicker();
            this.lblSampai = new System.Windows.Forms.Label();
            this.dt02 = new System.Windows.Forms.DateTimePicker();
            this.radioTgl02 = new System.Windows.Forms.RadioButton();
            this.radioTgl01 = new System.Windows.Forms.RadioButton();
            this.dt01 = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransaksi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvTransaksi
            // 
            this.gvTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTransaksi.Location = new System.Drawing.Point(12, 170);
            this.gvTransaksi.Name = "gvTransaksi";
            this.gvTransaksi.Size = new System.Drawing.Size(502, 200);
            this.gvTransaksi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKode);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kode Transaksi";
            // 
            // btnKode
            // 
            this.btnKode.Location = new System.Drawing.Point(179, 20);
            this.btnKode.Name = "btnKode";
            this.btnKode.Size = new System.Drawing.Size(75, 23);
            this.btnKode.TabIndex = 2;
            this.btnKode.Text = "Cari";
            this.btnKode.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTanggal);
            this.groupBox2.Controls.Add(this.dt03);
            this.groupBox2.Controls.Add(this.lblSampai);
            this.groupBox2.Controls.Add(this.dt02);
            this.groupBox2.Controls.Add(this.radioTgl02);
            this.groupBox2.Controls.Add(this.radioTgl01);
            this.groupBox2.Controls.Add(this.dt01);
            this.groupBox2.Location = new System.Drawing.Point(278, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 149);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tanggal Transaksi";
            // 
            // btnTanggal
            // 
            this.btnTanggal.Location = new System.Drawing.Point(78, 110);
            this.btnTanggal.Name = "btnTanggal";
            this.btnTanggal.Size = new System.Drawing.Size(100, 30);
            this.btnTanggal.TabIndex = 9;
            this.btnTanggal.Text = "Cari";
            this.btnTanggal.UseVisualStyleBackColor = true;
            this.btnTanggal.Click += new System.EventHandler(this.button2_Click);
            // 
            // dt03
            // 
            this.dt03.Location = new System.Drawing.Point(26, 84);
            this.dt03.Name = "dt03";
            this.dt03.Size = new System.Drawing.Size(200, 20);
            this.dt03.TabIndex = 8;
            this.dt03.Enter += new System.EventHandler(this.dt03_Enter);
            // 
            // lblSampai
            // 
            this.lblSampai.AutoSize = true;
            this.lblSampai.Location = new System.Drawing.Point(104, 68);
            this.lblSampai.Name = "lblSampai";
            this.lblSampai.Size = new System.Drawing.Size(42, 13);
            this.lblSampai.TabIndex = 7;
            this.lblSampai.Text = "Sampai";
            // 
            // dt02
            // 
            this.dt02.Location = new System.Drawing.Point(26, 45);
            this.dt02.Name = "dt02";
            this.dt02.Size = new System.Drawing.Size(200, 20);
            this.dt02.TabIndex = 6;
            this.dt02.Enter += new System.EventHandler(this.dt02_Enter);
            // 
            // radioTgl02
            // 
            this.radioTgl02.AutoSize = true;
            this.radioTgl02.Location = new System.Drawing.Point(6, 51);
            this.radioTgl02.Name = "radioTgl02";
            this.radioTgl02.Size = new System.Drawing.Size(14, 13);
            this.radioTgl02.TabIndex = 5;
            this.radioTgl02.TabStop = true;
            this.radioTgl02.UseVisualStyleBackColor = true;
            // 
            // radioTgl01
            // 
            this.radioTgl01.AutoSize = true;
            this.radioTgl01.Location = new System.Drawing.Point(6, 25);
            this.radioTgl01.Name = "radioTgl01";
            this.radioTgl01.Size = new System.Drawing.Size(14, 13);
            this.radioTgl01.TabIndex = 4;
            this.radioTgl01.TabStop = true;
            this.radioTgl01.UseVisualStyleBackColor = true;
            // 
            // dt01
            // 
            this.dt01.Location = new System.Drawing.Point(26, 19);
            this.dt01.Name = "dt01";
            this.dt01.Size = new System.Drawing.Size(200, 20);
            this.dt01.TabIndex = 3;
            this.dt01.Enter += new System.EventHandler(this.dt01_Enter);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 49);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Pencarian";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(20, 57);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(229, 40);
            this.lblSub.TabIndex = 10;
            this.lblSub.Text = "Data Transaksi";
            // 
            // frmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 382);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvTransaksi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pencarian Data Transaksi";
            ((System.ComponentModel.ISupportInitialize)(this.gvTransaksi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTransaksi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dt01;
        private System.Windows.Forms.Button btnTanggal;
        private System.Windows.Forms.DateTimePicker dt03;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.DateTimePicker dt02;
        private System.Windows.Forms.RadioButton radioTgl02;
        private System.Windows.Forms.RadioButton radioTgl01;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
    }
}