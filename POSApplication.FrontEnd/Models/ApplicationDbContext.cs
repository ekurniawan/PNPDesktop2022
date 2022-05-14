using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace POSApplication.FrontEnd.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Barang> Barangs { get; set; } = null!;
        public virtual DbSet<ItemBeli> ItemBelis { get; set; } = null!;
        public virtual DbSet<NotaBeli> NotaBelis { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=POSDb;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Barang>(entity =>
            {
                entity.Property(e => e.KodeBarang).IsFixedLength();

                entity.Property(e => e.TanggalBeli).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ItemBeli>(entity =>
            {
                entity.Property(e => e.KodeBarang).IsFixedLength();

                entity.Property(e => e.NoNotaBeli).IsFixedLength();

                entity.HasOne(d => d.Barang)
                    .WithMany(p => p.ItemBelis)
                    .HasForeignKey(d => d.KodeBarang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemBeli_Barang");

                entity.HasOne(d => d.NotoBeli)
                    .WithMany(p => p.ItemBelis)
                    .HasForeignKey(d => d.NoNotaBeli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemBeli_NotaBeli");
            });

            modelBuilder.Entity<NotaBeli>(entity =>
            {
                entity.Property(e => e.NoNotaBeli).IsFixedLength();

                entity.Property(e => e.TanggalBeli).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.NotaBelis)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaBeli_Supplier");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
