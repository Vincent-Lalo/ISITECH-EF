using Northwind.DBContext;
using Northwind.Models;

namespace EFCore;

class ProgramQueries {
  public static void Query1() {
    using NorthwindContext db = new();
    Console.WriteLine("Entrez un prix :");
    String s = Console.ReadLine();
    List<Product> p = db.Products.Where(p => p.UnitPrice > decimal.Parse(s)).ToList();
    foreach (Product p1 in p) {
      db.Entry(p1).Reference(p => p.Category).Load();
      Console.WriteLine(p1.ProductName + " - (" + p1.UnitPrice + ") " + p1.UnitsInStock + " - " + p1.Category.CategoryName);
    }
  }
}