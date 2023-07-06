using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Northwind.Models;

public partial class Product
{
  [Key]
  [Column("ProductID")]
  public int ProductId { get; set; }

  [StringLength(50)]
  [Unicode(false)]
  public string? ProductName { get; set; }

  [Column("SupplierID")]
  public int? SupplierId { get; set; }

  [Column("CategoryID")]
  public int? CategoryId { get; set; }

  [StringLength(25)]
  [Unicode(false)]
  public string? UnitsInStock { get; set; }

  [Column(TypeName = "numeric(18, 0)")]
  public decimal? UnitPrice { get; set; }

  [NotMapped]
  [ForeignKey("CategoryId")]
  [InverseProperty("Products")]
  public virtual Category? Category { get; set; }
}