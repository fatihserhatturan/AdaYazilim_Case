using Microsoft.EntityFrameworkCore;

namespace AdaYazilim_Case.Models
{
    public class DbContextCase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Case;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Train> Trains { get; set; }
        public DbSet<Wagon> Wagones { get; set; }

    }
}
