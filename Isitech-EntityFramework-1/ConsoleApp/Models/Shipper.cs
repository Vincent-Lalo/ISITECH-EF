using System.ComponentModel.DataAnnotations;

namespace EFCore.Shared;

public class Shipper
{
    [Key]
    public int ShipperId { get; set; }
    public string CompanyName { get; set; } = null!;
    public string? Phone { get; set; }
}