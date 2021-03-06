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

        public void DeleteItemBeli(string kodeBarang,string nonotaBeli)
        {
            try
            {
                var deleteItem = _dbContext.ItemBelis.Where(i=>i.KodeBarang==kodeBarang && i.NoNotaBeli==nonotaBeli).FirstOrDefault();
                if(deleteItem!=null)
                {
                    _dbContext.ItemBelis.Remove(deleteItem);
                    _dbContext.SaveChanges();
                }    
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public void UpdateItemBeli(ItemBeli itemBeli)
        {
            try
            {
                var updateItem = _dbContext.ItemBelis.Where(i => i.NoNotaBeli == itemBeli.NoNotaBeli && i.KodeBarang == itemBeli.KodeBarang).FirstOrDefault();
                if(updateItem!=null)
                {
                    updateItem.Jumlah = itemBeli.Jumlah;
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public void TambahItemBeli(ItemBeli itemBeli)
        {
            //cek apakah item barang sudah ada?
            var cekItem = _dbContext.ItemBelis.Where(
                i=>i.NoNotaBeli==itemBeli.NoNotaBeli && i.KodeBarang==itemBeli.KodeBarang).FirstOrDefault();
            if (cekItem != null) 
            {
                try
                {
                    //ada barang yang sama sudah ditambahkan, maka update quantity nya
                    cekItem.Jumlah += itemBeli.Jumlah;
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error: {ex.Message}");
                }
            }
            else
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
}
