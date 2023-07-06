using Northwind.Models;
using Microsoft.AspNetCore.Mvc;
using Northwind.DBContext;

namespace app.Controllers;

[ApiController]
[Route("[controller]")]
public class NorthwindController : ControllerBase
{

  [HttpGet("products")]
  public IEnumerable<Product> Get()
  {
    using (var db = new NorthwindContext())
    {
      return db.Products.ToList();
    }
  }

  [HttpGet("products/{id}")]
  public Product Get(int id)
  {
    using (var db = new NorthwindContext())
    {
      return db.Products.Find(id);
    }
  }

  [HttpPost("products")]
  public Product Post([FromBody] Product product)
  {
    using (var db = new NorthwindContext())
    {
      db.Products.Add(product);
      db.SaveChanges();
      return product;
    }
  }

  [HttpGet("products/{id}/category")]
  public IEnumerable<Product> GetCategory(int id)
  {
    using (var db = new NorthwindContext())
    {
      return db.Products.Where(p => p.CategoryId == id).ToList();
    }
  }
}
