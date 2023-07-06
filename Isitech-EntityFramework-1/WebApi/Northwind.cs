using Microsoft.EntityFrameworkCore;
using Northwind.Models;

namespace Northwind.DBContext;


public partial class NorthwindContext : DbContext
{

  public virtual DbSet<Category> Categories { get; set; }

  public virtual DbSet<Product> Products { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    String path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        
    String connection = $"Filename={path};";

    optionsBuilder.UseSqlite(connection);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Category>(entity =>
    {
      entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2BE645C41D");
    });

    modelBuilder.Entity<Product>(entity =>
    {
      entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6ED7C0422F9");

      entity.HasOne(d => d.Category).WithMany(p => p.Products).HasConstraintName("FK__Products__Catego__2E1BDC42");
    });

    OnModelCreatingPartial(modelBuilder);
  }

  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}