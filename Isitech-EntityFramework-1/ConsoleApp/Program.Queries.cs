using Microsoft.EntityFrameworkCore;

using EFCore.Shared;

partial class ProgramQueries
{
     public static void GetCategories()
    {
        using (Northwind db = new())
        {
            ProgramHelp.SectionTitle("Liste des catégories");
            IQueryable<Category> categories = db.Categories?.Include(c => c.Products);
            
            if((categories is null) || (categories.Count() == 0))
            {
                ProgramHelp.Fail("Aucune catégorie trouvée");
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

     //récupérer la liste des produits dont le prix est supérieur à un montant passé en paramètre
     public static void GetProductsByPriceSuperior(decimal priceEntered)
     {
         using (Northwind db = new())
         {
             List<Product> products = db.Products
                 .Where(product => product.UnitPrice > priceEntered)
                 .ToList();

             if (products.Count == 0)
             {
                 ProgramHelp.Fail("Aucun produit trouvé");
                 return;
             }

             foreach (Product product in products)
             {
                 db.Entry(product).Reference(p => p.Category).Load();
                 Console.WriteLine(product.ProductName + ". Prix: " + product.UnitPrice + "$. Stock: " + product.UnitsInStock);
             }
         }
     }
}