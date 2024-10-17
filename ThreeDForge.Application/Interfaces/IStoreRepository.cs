
using ThreeDForge.Domain.Entities;

namespace ThreeDForge.Application.Interfaces
{
    public interface IStoreRepository
    {
        Task AddAsync(Item item);
    }
}
