using Microsoft.EntityFrameworkCore;

namespace PROJEstaj.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // ✅ Veritabanındaki KisilerTablosu tablosunu temsil eder
        public DbSet<KisilerTablosu> KisilerTablosu { get; set; }
    }
}
