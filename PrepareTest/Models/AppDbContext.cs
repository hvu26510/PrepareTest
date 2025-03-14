using Microsoft.EntityFrameworkCore;

namespace PrepareTest.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Sukien> Sukiens { get; set; }
        public DbSet<Ve> Ves { get; set; }
        public DbSet<Toanha> Toanhas { get; set; }
        public DbSet<Canho> Canhos { get; set; }
        public DbSet<Nhasx> Nhasxs { get; set; }
        public DbSet<Sanpham> Sanphams { get; set; }
        public DbSet<Danhmucthucdon> Danhmucthucdons { get; set; }
        public DbSet<Monan> Monans { get; set; }
    }
}
