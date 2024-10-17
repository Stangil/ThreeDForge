
using Microsoft.EntityFrameworkCore;
using ThreeDForge.Application.Interfaces;
using ThreeDForge.Domain.Entities;
using ThreeDForge.Infrastructure.Context;

namespace ThreeDForge.Infrastructure.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly ThreeDForgeDbContext _context;
        public StoreRepository(IDbContextFactory<ThreeDForgeDbContext> factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task AddAsync(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
        }
    }
}
