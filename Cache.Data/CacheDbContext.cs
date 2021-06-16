using Cache.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cache.Data
{
    public class CacheDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public CacheDbContext(DbContextOptions<CacheDbContext> options) : base(options) { }
    }
}