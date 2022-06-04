using POSApplication.FrontEnd.DAL;
using POSApplication.FrontEnd.Models;
using POSApplication.FrontEnd.ViewModel;
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
    public partial class FormSupplier : Form
    {
        #region Singleton

        private static FormSupplier _instance;
        public static FormSupplier Instance()
        {
            if (_instance == null)
                _instance = new FormSupplier();
            return _instance; 
        }

        #endregion

        private BindingSource bs;
        private SupplierDAL _supplierDAL;
        private PembelianDAL _pembelianDAL;

        public FormSupplier()
        {
            InitializeComponent();
            _supplierDAL = new SupplierDAL();
            _pembelianDAL = new PembelianDAL();
            bs = new BindingSource();
        }

        private List<SupplierViewModel> MappingSupplier(List<Supplier> lstSupplier)
        {
            List<SupplierViewModel> lstsupplierVM =
                    new List<SupplierViewModel>();
            foreach (var sup in lstSupplier)
            {
                lstsupplierVM.Add(new SupplierViewModel
                {
                    SupplierId = sup.SupplierId,
                    Nama = sup.Nama,
                    Alamat = sup.Alamat,
                    Telp = sup.Telp
                });
            }
            return lstsupplierVM;
        }

        //method untuk mengisi data barang
        private void IsiDataSupplier()
        {
            try
            {
                var results = MappingSupplier(_supplierDAL.GetAll());
                bs.DataSource = results;
                dgvSupplier.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}","Kesalahan",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void CariData(string nama)
        {
            try
            {
                bs.Clear();
                var results = MappingSupplier(_supplierDAL.GetByNama(nama));
                bs.DataSource = results;
                dgvSupplier.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            IsiDataSupplier();
            
        }

        private void txtNamaSupplier_TextChanged(object sender, EventArgs e)
        {
            if(txtNamaSupplier.Text.Length >= 3)
            {
                CariData(txtNamaSupplier.Text);
            }
            else if(txtNamaSupplier.Text.Length==0)
            {
                IsiDataSupplier();
            }
        }

        private void dgvSupplier_DoubleClick(object sender, EventArgs e)
        {
            SupplierViewModel currSup = (SupplierViewModel)bs.Current;
            //MessageBox.Show(currSup.SupplierId.ToString());
            FormPembelian.Instance().TxtKodeSupplier.Text = currSup.SupplierId.ToString();
            FormPembelian.Instance().TxtNamaSupplier.Text = currSup.Nama;
            FormPembelian.Instance().TxtAlamatSupplier.Text = currSup.Alamat;
            FormPembelian.Instance().TxtTelponSupplier.Text = currSup.Telp;

            //update data supplier di pembelian
            _pembelianDAL.UpdateNotaBeli(FormPembelian.Instance().TxtNotaPembelian.Text,
                FormPembelian.Instance().DtTanggalNotaBeli.Value,
                currSup.SupplierId);

            this.Hide();
        }
    }
}
