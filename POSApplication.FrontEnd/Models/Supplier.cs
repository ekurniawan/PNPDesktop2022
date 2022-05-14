using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace POSApplication.FrontEnd.Models
{
    [Table("Supplier")]
    public partial class Supplier
    {
        public Supplier()
        {
            NotaBelis = new HashSet<NotaBeli>();
        }

        [Key]
        [Column("SupplierID")]
        public int SupplierId { get; set; }
        [StringLength(50)]
        public string Nama { get; set; } = null!;
        [StringLength(50)]
        public string? Alamat { get; set; }
        [StringLength(50)]
        public string? Telp { get; set; }

        [InverseProperty("Supplier")]
        public virtual ICollection<NotaBeli> NotaBelis { get; set; }
    }
}
