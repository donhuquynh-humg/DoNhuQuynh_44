using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoNhuQuynh_44.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDb")
        {
        }

        public virtual DbSet<TinhThanh> TinhThanhs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TinhThanh>()
                .Property(e => e.MaTinhThanh)
                .IsUnicode(false);
            modelBuilder.Entity<TinhThanh>()
                .Property(e => e.TenTinhThanh)
                .IsUnicode(false);

        }

        public System.Data.Entity.DbSet<DoNhuQuynh_44.Models.NhanVien> NhanViens { get; set; }
    }
}
