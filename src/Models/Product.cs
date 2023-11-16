using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Product
{
    [Key] public int Id { get; set; }

    [Required(ErrorMessage = "Informe o título")]
    [MinLength(3, ErrorMessage = "O categoria deve ter pelo menos 3 caracteres")]
    [MaxLength(120, ErrorMessage = "O categoria deve no máximo 120 caracteres")]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }
    
    [Required(ErrorMessage = "Informe o preço do produto")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}