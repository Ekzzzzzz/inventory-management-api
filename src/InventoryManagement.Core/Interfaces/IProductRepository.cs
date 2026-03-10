using InventoryManagement.Core.Entities;

namespace InventoryManagement.Core.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync(string? name, int? categoryId);
    Task<Product?> GetByIdAsync(int id);
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Product product);
    Task<IEnumerable<Product>> GetLowStockAsync();
}