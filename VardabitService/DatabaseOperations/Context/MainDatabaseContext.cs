using Microsoft.EntityFrameworkCore;
using VardabitService.Models.MainDatabase;

namespace VardabitService.DatabaseOperations
{
    public class MainDatabaseContext : DbContext
    {
        public DbSet<Stok> Stoklar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=MainDatabase; uid=sa; pwd=123; TrustServerCertificate=True");
        }
    }
}
