using Microsoft.EntityFrameworkCore;

namespace WebAppPcto.Data
{
    public class AgenziaDbContext : DbContext
    {
        public AgenziaDbContext() : base() { }

        public AgenziaDbContext(DbContextOptions<AgenziaDbContext> options) : base(options) { }

        public DbSet<Prenotazione> Prenotation { get; set; }
        public DbSet<viaggio> Viagg { get; set; }
    }
}