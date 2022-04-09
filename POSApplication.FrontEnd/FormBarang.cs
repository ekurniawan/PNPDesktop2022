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
    public partial class FormBarang : Form
    {
        private BarangDAL barangDAL;

        public FormBarang()
        {
            InitializeComponent();
            barangDAL = new BarangDAL();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            var results = barangDAL.GetAll();
            dgvBarang.DataSource = results.ToList();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Barang newBarang = new Barang
            {
                KodeBarang = "MN003",
                NamaBarang = "Monitor AOC 21",
                HargaBeli = 1500000,
                HargaJual = 1600000,
                Stok = 10,
                Keterangan = "Best Monitor Low End 2021"
            };
            try
            {
                barangDAL.Insert(newBarang);
                MessageBox.Show($"Tambah Data Barang dengan kode {newBarang.KodeBarang} berhasil ",
                    "Keterangan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kesalahan: {ex.Message}","Kesalahan",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
