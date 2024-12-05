using System.ComponentModel.DataAnnotations;

namespace Ispit.API.Models;

public class ShoppingItem
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Name { get; set; }

    [Range(0.01, 999999)]
    public decimal Price { get; set; }

    [Required, StringLength(50)]
    public string Manufacturer { get; set; }
}