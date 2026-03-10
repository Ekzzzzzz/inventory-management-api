using InventoryManagement.Core.Entities;

namespace InventoryManagement.Core.Interfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllAsync();
    Task AddAsync(Category category);
}