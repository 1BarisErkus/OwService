using ConsoleApp2.Entities.Models.MainDatabase;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Repositories.Concretes.Context
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
