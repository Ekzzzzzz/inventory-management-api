using InventoryManagement.Core.Entities;

namespace InventoryManagement.Core.Interfaces;

public interface INotificationRepository
{
    Task<IEnumerable<Notification>> GetAllAsync();
    Task AddAsync(Notification notification);
    Task<Notification?> GetByIdAsync(int id);
    Task UpdateAsync(Notification notification);
}