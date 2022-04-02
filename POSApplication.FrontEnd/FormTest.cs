using POSApplication.FrontEnd.Data;
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
    public partial class FormTest : Form
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public FormTest()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            var result = (from b in dbContext.Barangs
                          select b).FirstOrDefault();
            MessageBox.Show($"Kode: {result.KodeBarang} Nama: {result.NamaBarang}");
        }
    }
}
