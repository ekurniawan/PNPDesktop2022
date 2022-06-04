using POSApplication.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.FrontEnd.DAL
{
    public class PembelianDAL
    {
        private readonly ApplicationDbContext _dbContext;
        public PembelianDAL()
        {
            _dbContext = new ApplicationDbContext();
        }

        public void UpdateNotaBeli(string noNota,DateTime tanggalBeli, int supplierId)
        {
            //cari nonotabeli yang akan diupdate

        }

        public string GenerateNoNotaBeli(DateTime tanggalBeli, int supplierId)
        {
            var lastNota = _dbContext.NotaBelis.OrderBy(n => n.NoNotaBeli).FirstOrDefault();
            int nomor = 1;
            string nonota = string.Empty;
            if (lastNota == null)
            {
                //pertama kali, belum ada nota
                nonota = "NB0001";
            }
            else
            {
                nomor = Convert.ToInt32(lastNota.NoNotaBeli.Substring(2, 4));
                nomor++;
                nonota = $"NB{nomor.ToString().PadLeft(4, '0')}";
            }

            try
            {
                var newNota = new NotaBeli
                {
                    NoNotaBeli = nonota,
                    TanggalBeli = tanggalBeli,
                    SupplierId = supplierId
                };
                _dbContext.NotaBelis.Add(newNota);
                _dbContext.SaveChanges();
                return nonota;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }
    }
}
