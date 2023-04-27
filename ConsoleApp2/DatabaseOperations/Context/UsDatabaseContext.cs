using Microsoft.EntityFrameworkCore;
using VardabitService.Models.UsDatabase;

namespace VardabitService.DatabaseOperations.Context
{
    public class UsDatabaseContext : DbContext
    {
        public DbSet<VStok> VStoklar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=UsDatabase; uid=sa; pwd=123; TrustServerCertificate=True");
        }
    }
}
