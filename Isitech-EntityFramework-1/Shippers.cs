namespace EFCore.Shared;

public class Shippers
{
    public int ShipperId { get; set; }
    public string CompanyName { get; set; } = null!;
    public string? Phone { get; set; }
}