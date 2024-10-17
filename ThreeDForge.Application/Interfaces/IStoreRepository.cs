
using ThreeDForge.Domain.Entities;

namespace ThreeDForge.Application.Interfaces
{
    public interface IStoreRepository
    {
        Task AddAsync(Item item);
        Task<List<Item>> GetAllAsync();
        Task<Item?> GetByIdAsync(int id);
        Task UpdateAsync(Item item);
    }
}
