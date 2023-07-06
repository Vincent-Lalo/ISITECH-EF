using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Shared;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    
    [Required]
    [MaxLength(40)]
    public string ProductName { get; set; } = null!;
    public int? SupplierId { get; set; }
    public int? CategoryId { get; set; }
    public string? QuantityPerUnit { get; set; }
    
    [Column(TypeName = "money")]
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }
    public short? UnitsOnOrder { get; set; }
    public short? ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
    public virtual Category? Category { get; set; } = null!;
    public Supplier? Supplier { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
}