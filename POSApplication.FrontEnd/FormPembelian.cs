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
    }
}
