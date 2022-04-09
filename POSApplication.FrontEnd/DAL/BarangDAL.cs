using POSApplication.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.FrontEnd.DAL
{
    public class BarangDAL
    {
        private ApplicationDbContext _dbContext;
        public BarangDAL()
        {
            _dbContext = new ApplicationDbContext();
        }

        //ambil semua data barang
        public IEnumerable<Barang> GetAll()
        {
            var results = from b in _dbContext.Barangs
                          select b;

            return results;
        }
    }
}
