using Microsoft.EntityFrameworkCore;
using Models;

namespace Siogas2.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Gasoducto> Gasoducto { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

