using AeProp.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AeProp.Api.Infrastructure
{
    public class AePropDbContext : DbContext
    {
        public AePropDbContext(DbContextOptions<AePropDbContext> options) : base(options) { }

        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
