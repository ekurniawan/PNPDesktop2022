using POSApplication.FrontEnd.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApplication.FrontEnd
{
    public partial class FormPembelian : Form
    {

        #region Singleton

        private static FormPembelian _instance;
        public static FormPembelian Instance()
        {
            if (_instance == null)
                _instance = new FormPembelian();
            return _instance;
        }

        #endregion


        public TextBox TxtKodeSupplier
        {
            get { return txtKodeSupplier; }
            set { txtKodeSupplier = value;  }
        }

        public TextBox TxtNamaSupplier
        {
            get { return txtNamaSupplier; }
            set { txtNamaSupplier = value; }
        }

        public TextBox TxtAlamatSupplier
        {
            get { return txtAlamatSupplier; }
            set { txtAlamatSupplier = value; }
        }

        public TextBox TxtTelponSupplier
        {
            get { return txtTelpSupplier; }
            set { txtTelpSupplier = value; }
        }

        public DateTimePicker DtTanggalNotaBeli
        {
            get { return dtTanggalNotaBeli; }
            set { dtTanggalNotaBeli = value; }
        }

        public TextBox TxtNotaPembelian
        {
            get { return txtNoNotaBeli; }
            set { txtNoNotaBeli = value; }
        }

        public TextBox TxtKodeBarang
        {
            get { return txtKode; }
            set { txtKode = value; }
        }

        public TextBox TxtNamaBarang
        {
            get { return txtNamaBarang; }
            set { txtNamaBarang = value; }
        }

        public TextBox TxtQty
        {
            get { return txtQty; }
            set { txtQty = value; }
        }

        public TextBox TxtHargaBeli
        {
            get { return txtHargaBeli; }
            set { txtHargaBeli = value; }
        }

        private PembelianDAL _pembelianDAL;
        public FormPembelian()
        {
            InitializeComponent();
            _pembelianDAL = new PembelianDAL();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSupplier.Instance().Show();
        }

        private void FormPembelian_Load(object sender, EventArgs e)
        {
            dtTanggalNotaBeli.Value = DateTime.Now;
            txtNoNotaBeli.Text = _pembelianDAL.GenerateNoNotaBeli(dtTanggalNotaBeli.Value, 1);
        }

        private void txtKode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                FormBarang.Instance().Show();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                double subtotal = Convert.ToDouble(txtQty.Text) * Convert.ToDouble(TxtHargaBeli.Text);
                txtSubtotal.Text = subtotal.ToString("N0");
            }
        }
    }
}
