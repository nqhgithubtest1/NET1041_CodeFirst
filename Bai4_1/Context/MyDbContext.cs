using Bai4_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai4_1.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<DiaChi> DiaChis { get; set; }
        // them cac dbset day du

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<DongVat>().HasKey(dv => dv.ID);

            // 1-1
            modelBuilder.Entity<DongVat>()
                .HasOne(dv => dv.ChuNhan)
                .WithOne(cn => cn.DongVat)
                .HasForeignKey<ChuNhan>(cn => cn.DongVatID);

            // 1-n
            modelBuilder.Entity<Chuong>()
                .HasMany(c => c.DongVats)
                .WithOne(dv => dv.Chuong)
                .OnDelete(DeleteBehavior.SetNull);

            //modelBuilder.Entity<DongVat>()
            //    .HasOne(dv => dv.Chuong)
            //    .WithMany(c => c.DongVats);

            // n-n 
            modelBuilder.Entity<DongVat>()
                .HasMany(dv => dv.ThucAns)
                .WithMany(ta => ta.DongVats);
        }
    }
}
