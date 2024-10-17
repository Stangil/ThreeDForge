using Microsoft.EntityFrameworkCore;
using ThreeDForge.Domain.Entities;

namespace ThreeDForge.Infrastructure.Context
{
    public class ThreeDForgeDbContext : DbContext
    {
        public ThreeDForgeDbContext(DbContextOptions<ThreeDForgeDbContext> options) : base(options)
        {
            
        }
        public DbSet<Item> Items { get; set; }
    }
}
