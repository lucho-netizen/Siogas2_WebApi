using Microsoft.EntityFrameworkCore;
using Siogas2_webapi.Models;

namespace Siogas2_WebApi.Context
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

