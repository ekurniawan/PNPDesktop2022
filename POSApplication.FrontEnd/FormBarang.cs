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
    }
}
