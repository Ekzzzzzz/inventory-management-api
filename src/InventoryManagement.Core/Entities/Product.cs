namespace InventoryManagement.Core.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relación con Category
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    // Navegación
    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    // ✅ Lógica de negocio pura (recuerdas Clean Architecture?)
    public bool IsLowStock() => Stock < 5;
}