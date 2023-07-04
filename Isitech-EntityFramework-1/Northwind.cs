namespace EFCore.Shared;
using Microsoft.EntityFrameworkCore;
using static System.Console;

public class Northwind : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        String path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        
        Console.WriteLine(path);
        String connection = $"Filename={path}";
        
        ConsoleColor color = Console.ForegroundColor;
        ForegroundColor = ConsoleColor.DarkCyan;
        WriteLine($"Connection string: {connection}");
        ForegroundColor = color;

        optionsBuilder.UseSqlite(connection);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Avec Fluent API on peut définir des règles de validation
        modelBuilder.Entity<Category>()
            .Property(c => c.CategoryName)
            .IsRequired()
            .HasMaxLength(15);
        
        if(Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite") 
        {
            //Règles de validations spécifiques à SQLite
            modelBuilder.Entity<Product>()
                .Property(p => p.UnitPrice)
                .HasConversion<double>();
        }
    }
    
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Product>? Products { get; set; }
}