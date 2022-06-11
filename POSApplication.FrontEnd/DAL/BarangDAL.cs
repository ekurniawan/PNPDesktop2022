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
            /*var results = from b in _dbContext.Barangs
                          orderby b.NamaBarang ascending
                          select b;*/
            var results = _dbContext.Barangs.OrderBy(b => b.NamaBarang).ToList();
            return results;
        }

        public int Insert(Barang barang)
        {
            try
            {
                _dbContext.Barangs.Add(barang);
                return _dbContext.SaveChanges();
            }
            catch(DbUpdateConcurrencyException dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }

        public Barang GetByKode(string kodeBarang)
        {
            var result = _dbContext.Barangs.Where(b=>b.KodeBarang==kodeBarang).FirstOrDefault();
            if (result == null)
                throw new Exception($"Barang dengan kode {kodeBarang} tidak ditemukan");
            return result;
        }

        public int Update(Barang barang)
        {
            try
            {
                var updateBarang = GetByKode(barang.KodeBarang);

                updateBarang.NamaBarang = barang.NamaBarang;
                updateBarang.HargaBeli = barang.HargaBeli;
                updateBarang.HargaJual = barang.HargaJual;
                updateBarang.Stok = barang.Stok;
                updateBarang.Keterangan = barang.Keterangan;

                var result = _dbContext.SaveChanges();
                return result;
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }

        public int Delete(string kodeBarang)
        {
            try
            {
                var deleteBarang = GetByKode(kodeBarang);
                _dbContext.Barangs.Remove(deleteBarang);
                var result = _dbContext.SaveChanges();
                return result;
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }

        public List<Barang> GetByNama(string nama)
        {
            var results = _dbContext.Barangs.Where(b => b.NamaBarang.ToLower().Contains(nama.ToLower()))
                .OrderBy(b=>b.NamaBarang).ToList();
            return results;
        }
    }
}
