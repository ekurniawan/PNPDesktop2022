using Microsoft.EntityFrameworkCore;
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
                          orderby b.NamaBarang ascending
                          select b;

            return results;
        }

        public void Insert(Barang barang)
        {
            try
            {
                _dbContext.Barangs.Add(barang);
                _dbContext.SaveChanges();
            }
            catch(DbUpdateException dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }
    }
}
