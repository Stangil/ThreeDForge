
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

        public async Task<List<Item>> GetAllAsync()
        {
            var items = await _context.Items.ToListAsync();
            return items;
        }

        public async Task<Item?> GetByIdAsync(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(e=>e.Id==id); 
            return item;
        }

        public async Task UpdateAsync(Item item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
