using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_kobzeva.Models;

/// <summary>
/// Модель объекта недвижимости (Агентство недвижимости).
/// </summary>
public class Property
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Адрес обязателен")]
    [StringLength(200, ErrorMessage = "Адрес не должен превышать 200 символов")]
    public string Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "Тип обязателен")]
    public string Type { get; set; } = string.Empty;   // Квартира, Дом, Офис, Замок

    [Range(0.01, 1_000_000_000, ErrorMessage = "Цена должна быть от 0.01 до 1 млрд")]
    public decimal Price { get; set; }

    [Range(0.1, 100000, ErrorMessage = "Площадь должна быть от 0.1 до 100000")]
    public double Area { get; set; }

    [Range(1, 1000, ErrorMessage = "Количество комнат от 1 до 1000")]
    public int Rooms { get; set; }

    public bool IsAvailable { get; set; }
}