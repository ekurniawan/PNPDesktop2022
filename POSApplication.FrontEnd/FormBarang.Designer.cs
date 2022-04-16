namespace POSApplication.FrontEnd
{
    partial class FormBarang
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
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtHargaBeli = new System.Windows.Forms.TextBox();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTanggalBeli = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Location = new System.Drawing.Point(0, 237);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersWidth = 51;
            this.dgvBarang.RowTemplate.Height = 29;
            this.dgvBarang.Size = new System.Drawing.Size(986, 188);
            this.dgvBarang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Barang :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Barang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga Beli :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Harga Jual :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stok :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Keterangan :";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Location = new System.Drawing.Point(142, 30);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(177, 27);
            this.txtKodeBarang.TabIndex = 8;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(142, 66);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(260, 27);
            this.txtNamaBarang.TabIndex = 10;
            // 
            // txtHargaBeli
            // 
            this.txtHargaBeli.Location = new System.Drawing.Point(142, 103);
            this.txtHargaBeli.Name = "txtHargaBeli";
            this.txtHargaBeli.Size = new System.Drawing.Size(130, 27);
            this.txtHargaBeli.TabIndex = 11;
            this.txtHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Location = new System.Drawing.Point(142, 138);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(130, 27);
            this.txtHargaJual.TabIndex = 12;
            this.txtHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(534, 33);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(82, 27);
            this.txtStok.TabIndex = 13;
            this.txtStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(534, 106);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(256, 62);
            this.txtKeterangan.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tanggal Beli :";
            // 
            // dtpTanggalBeli
            // 
            this.dtpTanggalBeli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalBeli.Location = new System.Drawing.Point(534, 69);
            this.dtpTanggalBeli.Name = "dtpTanggalBeli";
            this.dtpTanggalBeli.Size = new System.Drawing.Size(128, 27);
            this.dtpTanggalBeli.TabIndex = 16;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(59, 186);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(77, 29);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(142, 186);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 29);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 29);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(308, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 29);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 520);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dtpTanggalBeli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtHargaJual);
            this.Controls.Add(this.txtHargaBeli);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBarang);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBarang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtKodeBarang;
        private TextBox txtNamaBarang;
        private TextBox txtHargaBeli;
        private TextBox txtHargaJual;
        private TextBox txtStok;
        private TextBox txtKeterangan;
        private Label label7;
        private DateTimePicker dtpTanggalBeli;
        private Button btnNew;
        private Button btnEdit;
        private Button btnSave;
        private Button btnDelete;
    }
}