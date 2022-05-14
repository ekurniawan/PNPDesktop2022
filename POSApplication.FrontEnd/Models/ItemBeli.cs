using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace POSApplication.FrontEnd.Models
{
    [Table("ItemBeli")]
    public partial class ItemBeli
    {
        [Key]
        [Column("ItemBeliID")]
        public int ItemBeliId { get; set; }
        [StringLength(10)]
        public string NoNotaBeli { get; set; } = null!;
        [StringLength(5)]
        public string KodeBarang { get; set; } = null!;
        public int Jumlah { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal HargaBeli { get; set; }

        [ForeignKey("KodeBarang")]
        [InverseProperty("ItemBelis")]
        public virtual Barang Barang { get; set; } = null!;
        [ForeignKey("NoNotaBeli")]
        [InverseProperty("ItemBelis")]
        public virtual NotaBeli NotoBeli { get; set; } = null!;
    }
}
