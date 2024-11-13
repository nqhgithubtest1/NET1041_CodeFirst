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
    }
}
