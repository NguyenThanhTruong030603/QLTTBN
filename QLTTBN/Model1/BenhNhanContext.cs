using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTTBN.Model1
{
    public partial class BenhNhanContext : DbContext
    {
        public BenhNhanContext()
            : base("name=BenhNhanContext")
        {
        }

        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<TinhTrang> TinhTrangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TinhTrang>()
                .HasMany(e => e.BenhNhans)
                .WithRequired(e => e.TinhTrang)
                .WillCascadeOnDelete(false);
        }
    }
}
