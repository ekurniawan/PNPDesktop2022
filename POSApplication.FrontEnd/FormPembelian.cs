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



        public FormPembelian()
        {
            InitializeComponent();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSupplier.Instance().Show();

        }
    }
}
