using Microsoft.EntityFrameworkCore;
using POSApplication.FrontEnd.Models;
using POSApplication.FrontEnd.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.FrontEnd.DAL
{
    public class ItemBeliDAL
    {
        private ApplicationDbContext _dbContext;
        public ItemBeliDAL()
        {
            _dbContext = new ApplicationDbContext();
        }

        public IEnumerable<ViewModelPembelian> GetAll(string noNotaBeli)
        {
            List<ViewModelPembelian> lstViemPembelian = new List<ViewModelPembelian>();
            var results = _dbContext.ItemBelis.Include(i=>i.Barang)
                .Where(i=> i.NoNotaBeli == noNotaBeli).OrderBy(i=>i.ItemBeliId);

            foreach(var item in results)
            {
                lstViemPembelian.Add(new ViewModelPembelian
                {
                    ItemBeliId = item.ItemBeliId,
                    NoNotaBeli = item.NoNotaBeli,
                    KodeBarang = item.KodeBarang,
                    NamaBarang = item.Barang.NamaBarang,
                    HargaBeli = item.HargaBeli,
                    Jumlah = item.Jumlah,
                    Subtotal = item.HargaBeli*item.Jumlah
                });
            }

            return lstViemPembelian;
        }

        public void TambahItemBeli(ItemBeli itemBeli)
        {
            //menambahkan itembeli
            try
            {
                _dbContext.ItemBelis.Add(itemBeli);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }
    }
}
