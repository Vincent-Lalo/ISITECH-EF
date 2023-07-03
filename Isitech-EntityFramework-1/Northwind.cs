using Microsoft.EntityFrameworkCore;
using static System.Console;
namespace EFCore.Shared;
public class Northwind : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        String path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        
        String connection = $"Filename={path}";
        
        ConsoleColor color = Console.ForegroundColor;
        ForegroundColor = ConsoleColor.DarkCyan;
        WriteLine($"Connection string: {connection}");
        ForegroundColor = color;

        optionsBuilder.UseSqlite(connection);
    }
}