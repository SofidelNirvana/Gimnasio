using Gimnasio.Models;
using Microsoft.EntityFrameworkCore;

namespace Gimnasio.Data
{
    public class GimnasioContext : DbContext
    {
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Membresia> Membresias { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=DB_Gimnasio;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}