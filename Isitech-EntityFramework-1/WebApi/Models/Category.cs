using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Models;

public partial class Category
  {

    [Key]
    [Column("CategoryID")]
    public int CategoryId { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? CategoryName { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
  }