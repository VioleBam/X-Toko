namespace X_Toko
{
    partial class frmCariBarang
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
            this.gvBarang = new System.Windows.Forms.DataGridView();
            this.btnCariNama = new System.Windows.Forms.Button();
            this.lblKode = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnCariKode = new System.Windows.Forms.Button();
            this.grpKode = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvBarang)).BeginInit();
            this.grpKode.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvBarang
            // 
            this.gvBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBarang.Location = new System.Drawing.Point(7, 90);
            this.gvBarang.Name = "gvBarang";
            this.gvBarang.ReadOnly = true;
            this.gvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBarang.Size = new System.Drawing.Size(606, 189);
            this.gvBarang.TabIndex = 0;
            this.gvBarang.TabStop = false;
            this.gvBarang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBarang_CellDoubleClick);
            // 
            // btnCariNama
            // 
            this.btnCariNama.Location = new System.Drawing.Point(219, 30);
            this.btnCariNama.Name = "btnCariNama";
            this.btnCariNama.Size = new System.Drawing.Size(70, 30);
            this.btnCariNama.TabIndex = 3;
            this.btnCariNama.Text = "Cari";
            this.btnCariNama.UseVisualStyleBackColor = true;
            this.btnCariNama.Click += new System.EventHandler(this.btnCariNama_Click);
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(15, 20);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(69, 13);
            this.lblKode.TabIndex = 2;
            this.lblKode.Text = "Kode Barang";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(15, 36);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(200, 20);
            this.txtKode.TabIndex = 1;
            this.txtKode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKode_KeyPress);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(13, 20);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(72, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Barang";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(16, 36);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 20);
            this.txtNama.TabIndex = 2;
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            // 
            // btnCariKode
            // 
            this.btnCariKode.Location = new System.Drawing.Point(221, 30);
            this.btnCariKode.Name = "btnCariKode";
            this.btnCariKode.Size = new System.Drawing.Size(70, 30);
            this.btnCariKode.TabIndex = 4;
            this.btnCariKode.Text = "Cari";
            this.btnCariKode.UseVisualStyleBackColor = true;
            this.btnCariKode.Click += new System.EventHandler(this.btnCariKode_Click);
            // 
            // grpKode
            // 
            this.grpKode.Controls.Add(this.btnCariKode);
            this.grpKode.Controls.Add(this.lblKode);
            this.grpKode.Controls.Add(this.txtKode);
            this.grpKode.Location = new System.Drawing.Point(7, 12);
            this.grpKode.Name = "grpKode";
            this.grpKode.Size = new System.Drawing.Size(300, 72);
            this.grpKode.TabIndex = 5;
            this.grpKode.TabStop = false;
            this.grpKode.Text = "Pencarian Kode Barang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNama);
            this.groupBox2.Controls.Add(this.txtNama);
            this.groupBox2.Controls.Add(this.btnCariNama);
            this.groupBox2.Location = new System.Drawing.Point(313, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 72);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pencarian Nama Barang";
            // 
            // frmCariBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 291);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpKode);
            this.Controls.Add(this.gvBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pencarian Data Barang";
            ((System.ComponentModel.ISupportInitialize)(this.gvBarang)).EndInit();
            this.grpKode.ResumeLayout(false);
            this.grpKode.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBarang;
        private System.Windows.Forms.Button btnCariNama;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnCariKode;
        private System.Windows.Forms.GroupBox grpKode;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}