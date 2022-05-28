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
            this.SuspendLayout();
            // 
            // txtKodeSupplier
            // 
            this.txtKodeSupplier.Location = new System.Drawing.Point(161, 21);
            this.txtKodeSupplier.Name = "txtKodeSupplier";
            this.txtKodeSupplier.Size = new System.Drawing.Size(135, 27);
            this.txtKodeSupplier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Supplier :";
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(302, 20);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(70, 29);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "Cari";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // FormPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKodeSupplier);
            this.Name = "FormPembelian";
            this.Text = "FormPembelian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtKodeSupplier;
        private Label label1;
        private Button btnSupplier;
    }
}