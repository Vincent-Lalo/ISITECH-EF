namespace EFCore.Shared;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
    public string? Description { get; set; }
    public byte[]? Picture { get; set; }
    public ICollection<Product> Products { get; set; } = null!;
}