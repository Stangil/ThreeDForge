
using Microsoft.EntityFrameworkCore;
using ThreeDForge.Application.Interfaces;
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
    }
}
