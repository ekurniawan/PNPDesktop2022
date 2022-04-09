using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace POSApplication.FrontEnd.Models
{
    [Table("Barang")]
    public partial class Barang
    {
        [Key]
        [StringLength(5)]
        public string KodeBarang { get; set; } = null!;
        [StringLength(50)]
        public string? NamaBarang { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal HargaBeli { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal HargaJual { get; set; }
        public int Stok { get; set; }
        [Column(TypeName = "date")]
        public DateTime TanggalBeli { get; set; }
        public string? Keterangan { get; set; }
    }
}
