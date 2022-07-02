using POSApplication.FrontEnd.DAL;
using POSApplication.FrontEnd.Models;
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


        #region Binding Data Barang

        private void TambahBinding()
        {
            txtKode.DataBindings.Add("Text", bs, "KodeBarang");
            txtNamaBarang.DataBindings.Add("Text", bs, "NamaBarang");
            txtHargaBeli.DataBindings.Add("Text", bs, "HargaBeli");
            txtHargaBeli.DataBindings[0].FormattingEnabled = true;
            txtHargaBeli.DataBindings[0].FormatString = "N0";
            txtQty.DataBindings.Add("Text", bs, "Jumlah");
            txtSubtotal.DataBindings.Add("Text", bs, "Subtotal");
            txtSubtotal.DataBindings[0].FormattingEnabled = true;
            txtSubtotal.DataBindings[0].FormatString = "N0";
        }

        private void HapusBinding()
        {
            txtKode.DataBindings.Clear();
            txtNamaBarang.DataBindings.Clear();
            txtHargaBeli.DataBindings.Clear();
            txtQty.DataBindings.Clear();
            txtSubtotal.DataBindings.Clear();
        }

        private void IsiDataBarang()
        {
            bs.DataSource = _itemBeliDAL.GetAll(txtNoNotaBeli.Text);
            dgvBarang.DataSource = bs;
        }

        #endregion


        private PembelianDAL _pembelianDAL;
        private ItemBeliDAL _itemBeliDAL;
        private BindingSource bs;

        public FormPembelian()
        {
            InitializeComponent();
            _pembelianDAL = new PembelianDAL();
            _itemBeliDAL = new ItemBeliDAL();
            bs = new BindingSource();
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
                HapusBinding();
                FormBarang.Instance().Show();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                double subtotal = Convert.ToDouble(txtQty.Text) * Convert.ToDouble(TxtHargaBeli.Text);
                txtSubtotal.Text = String.Empty;
                txtSubtotal.Text = subtotal.ToString("N0");
                txtSubtotal.Focus();
            }
        }

        private void txtSubtotal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                HapusBinding();
                var newItemBeli = new ItemBeli
                {
                    NoNotaBeli = txtNoNotaBeli.Text,
                    KodeBarang = txtKode.Text,
                    HargaBeli = Convert.ToDecimal(txtHargaBeli.Text),
                    Jumlah = Convert.ToInt32(txtQty.Text)
                };
                try
                {
                    _itemBeliDAL.TambahItemBeli(newItemBeli);
                    IsiDataBarang();
                    TambahBinding();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error");
                }
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            HapusBinding();
        }
    }
}
