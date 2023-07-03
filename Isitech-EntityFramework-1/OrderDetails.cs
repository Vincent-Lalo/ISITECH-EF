namespace EFCore.Shared;

public class OrderDetails
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }
    public Orders? Order { get; set; }
    public Product? Product { get; set; }
}