namespace POSApplication.FrontEnd
{
    partial class FormPembelian
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
            this.txtKodeSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlamatSupplier = new System.Windows.Forms.TextBox();
            this.txtTelpSupplier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoNotaBeli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTanggalNotaBeli = new System.Windows.Forms.DateTimePicker();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.nonotabeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itembeliid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtHargaBeli = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalHarga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKodeSupplier
            // 
            this.txtKodeSupplier.Location = new System.Drawing.Point(136, 57);
            this.txtKodeSupplier.Name = "txtKodeSupplier";
            this.txtKodeSupplier.ReadOnly = true;
            this.txtKodeSupplier.Size = new System.Drawing.Size(135, 27);
            this.txtKodeSupplier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Supplier :";
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(277, 56);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(70, 29);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "Cari";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama :";
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Location = new System.Drawing.Point(136, 100);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.ReadOnly = true;
            this.txtNamaSupplier.Size = new System.Drawing.Size(211, 27);
            this.txtNamaSupplier.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alamat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telpon :";
            // 
            // txtAlamatSupplier
            // 
            this.txtAlamatSupplier.Location = new System.Drawing.Point(466, 98);
            this.txtAlamatSupplier.Name = "txtAlamatSupplier";
            this.txtAlamatSupplier.ReadOnly = true;
            this.txtAlamatSupplier.Size = new System.Drawing.Size(211, 27);
            this.txtAlamatSupplier.TabIndex = 7;
            // 
            // txtTelpSupplier
            // 
            this.txtTelpSupplier.Location = new System.Drawing.Point(472, 100);
            this.txtTelpSupplier.Name = "txtTelpSupplier";
            this.txtTelpSupplier.ReadOnly = true;
            this.txtTelpSupplier.Size = new System.Drawing.Size(211, 27);
            this.txtTelpSupplier.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "No Nota :";
            // 
            // txtNoNotaBeli
            // 
            this.txtNoNotaBeli.Location = new System.Drawing.Point(91, 6);
            this.txtNoNotaBeli.Name = "txtNoNotaBeli";
            this.txtNoNotaBeli.ReadOnly = true;
            this.txtNoNotaBeli.Size = new System.Drawing.Size(122, 27);
            this.txtNoNotaBeli.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tanggal :";
            // 
            // dtTanggalNotaBeli
            // 
            this.dtTanggalNotaBeli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTanggalNotaBeli.Location = new System.Drawing.Point(606, 9);
            this.dtTanggalNotaBeli.Name = "dtTanggalNotaBeli";
            this.dtTanggalNotaBeli.Size = new System.Drawing.Size(145, 27);
            this.dtTanggalNotaBeli.TabIndex = 12;
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nonotabeli,
            this.itembeliid,
            this.kodeBarang,
            this.Nama,
            this.qty,
            this.hargaBeli,
            this.subtotal});
            this.dgvBarang.Location = new System.Drawing.Point(-1, 213);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersWidth = 51;
            this.dgvBarang.RowTemplate.Height = 29;
            this.dgvBarang.Size = new System.Drawing.Size(809, 237);
            this.dgvBarang.TabIndex = 13;
            this.dgvBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBarang_KeyDown);
            // 
            // nonotabeli
            // 
            this.nonotabeli.DataPropertyName = "NoNotaBeli";
            this.nonotabeli.HeaderText = "NoNotaBeli";
            this.nonotabeli.MinimumWidth = 6;
            this.nonotabeli.Name = "nonotabeli";
            this.nonotabeli.Visible = false;
            this.nonotabeli.Width = 125;
            // 
            // itembeliid
            // 
            this.itembeliid.DataPropertyName = "ItemBeliId";
            this.itembeliid.HeaderText = "ItemBeliId";
            this.itembeliid.MinimumWidth = 6;
            this.itembeliid.Name = "itembeliid";
            this.itembeliid.Visible = false;
            this.itembeliid.Width = 125;
            // 
            // kodeBarang
            // 
            this.kodeBarang.DataPropertyName = "KodeBarang";
            this.kodeBarang.HeaderText = "Kode";
            this.kodeBarang.MinimumWidth = 6;
            this.kodeBarang.Name = "kodeBarang";
            this.kodeBarang.Width = 125;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "NamaBarang";
            this.Nama.HeaderText = "Nama Barang";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 250;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "Jumlah";
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.Width = 125;
            // 
            // hargaBeli
            // 
            this.hargaBeli.DataPropertyName = "HargaBeli";
            this.hargaBeli.HeaderText = "Harga Beli";
            this.hargaBeli.MinimumWidth = 6;
            this.hargaBeli.Name = "hargaBeli";
            this.hargaBeli.Width = 125;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "Subtotal";
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.Width = 125;
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(20, 180);
            this.txtKode.Name = "txtKode";
            this.txtKode.ReadOnly = true;
            this.txtKode.Size = new System.Drawing.Size(89, 27);
            this.txtKode.TabIndex = 14;
            this.txtKode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKode_KeyDown);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(115, 180);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.ReadOnly = true;
            this.txtNamaBarang.Size = new System.Drawing.Size(254, 27);
            this.txtNamaBarang.TabIndex = 15;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(375, 180);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(99, 27);
            this.txtQty.TabIndex = 16;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // txtHargaBeli
            // 
            this.txtHargaBeli.Location = new System.Drawing.Point(478, 180);
            this.txtHargaBeli.Name = "txtHargaBeli";
            this.txtHargaBeli.ReadOnly = true;
            this.txtHargaBeli.Size = new System.Drawing.Size(133, 27);
            this.txtHargaBeli.TabIndex = 17;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(618, 180);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(133, 27);
            this.txtSubtotal.TabIndex = 18;
            this.txtSubtotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubtotal_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kode :";
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Location = new System.Drawing.Point(618, 454);
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.Size = new System.Drawing.Size(133, 27);
            this.txtTotalHarga.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total Harga :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nama :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Qty :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(478, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Harga :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(618, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Subtotal";
            // 
            // FormPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 493);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalHarga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtHargaBeli);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.dtTanggalNotaBeli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoNotaBeli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelpSupplier);
            this.Controls.Add(this.txtAlamatSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamaSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKodeSupplier);
            this.Name = "FormPembelian";
            this.Text = "FormPembelian";
            this.Load += new System.EventHandler(this.FormPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtKodeSupplier;
        private Label label1;
        private Button btnSupplier;
        private Label label2;
        private TextBox txtNamaSupplier;
        private Label label3;
        private Label label4;
        private TextBox txtAlamatSupplier;
        private TextBox txtTelpSupplier;
        private Label label5;
        private TextBox txtNoNotaBeli;
        private Label label6;
        private DateTimePicker dtTanggalNotaBeli;
        private DataGridView dgvBarang;
        private TextBox txtKode;
        private TextBox txtNamaBarang;
        private TextBox txtQty;
        private TextBox txtHargaBeli;
        private TextBox txtSubtotal;
        private Label label7;
        private TextBox txtTotalHarga;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridViewTextBoxColumn nonotabeli;
        private DataGridViewTextBoxColumn itembeliid;
        private DataGridViewTextBoxColumn kodeBarang;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn hargaBeli;
        private DataGridViewTextBoxColumn subtotal;
    }
}