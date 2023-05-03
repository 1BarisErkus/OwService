using ConsoleApp2.Entities.Models.UsDatabase;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Repositories.Concretes.Context
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
