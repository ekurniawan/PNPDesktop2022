using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.FrontEnd.ViewModel
{
    public class ViewModelPembelian
    {
        public int ItemBeliId { get; set; }
        public string NoNotaBeli { get; set; } = null!;
        public string KodeBarang { get; set; } = null!;
        public int Jumlah { get; set; }
        public string? NamaBarang { get; set; }
        public decimal HargaBeli { get; set; }
        public decimal Subtotal { get; set; }
    }
}
