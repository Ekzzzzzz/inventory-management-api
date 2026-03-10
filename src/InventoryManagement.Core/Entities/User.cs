using InventoryManagement.Core.Entities;

namespace InventoryManagement.Core.Entities;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = "Employee"; // "Admin" o "Employee"
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navegación
    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}