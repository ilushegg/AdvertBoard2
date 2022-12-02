namespace AdvertBoard.Contracts;

/// <summary>
/// Товар
/// </summary>
public class AddProductModel
{   
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
    /// Категория.
    /// </summary>
    public Guid CategoryId { get; set; }

    /// <summary>
    /// Изображения.
    /// </summary>
    public Guid[]? Images { get; set; }

    /// <summary>
    /// Страна.
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Город.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Улица.
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// Номер.
    /// </summary>
    public string? Number { get; set; }
}