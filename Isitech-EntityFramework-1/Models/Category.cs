using System.ComponentModel.DataAnnotations;

namespace EFCore.Shared;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
    
    [MaxLength(15)]
    public string? Description { get; set; }
    public byte[]? Picture { get; set; }
    public virtual ICollection<Product> Products { get; set; } = null!;
}