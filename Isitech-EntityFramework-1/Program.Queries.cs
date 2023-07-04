using Microsoft.EntityFrameworkCore;

using EFCore.Shared;

partial class Program_Queries
{
     public static void GetCategories()
    {
        using (Northwind db = new())
        {
            Program_Help.SectionTitle("Liste des catégories");
            IQueryable<Category> categories = db.Categories?.Include(c => c.Products);
            
            if((categories is null) || (categories.Count() == 0))
            {
                Program_Help.Fail("Aucune catégorie trouvée");
                return;
            }
            
            foreach (Category c in categories)
            {
                Console.WriteLine($"{c.CategoryId} a {c.CategoryName} produits");
                foreach (Product p in c.Products)
                {
                    Console.WriteLine($"\t{p.ProductName}");
                }
            }
        }
    }
}