namespace AdvertBoard.Domain;

/// <summary>
/// Товар
/// </summary>
public class Product
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Описание.
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Цена.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Идентификатор категории.
    /// </summary>
    public Guid CategoryId { get; set; }

    /// <summary>
    /// Категория.
    /// </summary>
    public Category Category { get; set; }

    /// <summary>
    /// Изображения.
    /// </summary>
    public string? Picture { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateTimeCreated { get; set; }
    
    /// <summary>
    /// Коллекция элементов корзины.
    /// </summary>
    public ICollection<ShoppingCart> ShoppingCarts { get; set; }
}