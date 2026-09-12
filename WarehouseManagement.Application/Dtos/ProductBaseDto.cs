namespace WarehouseManagement.Application.Dtos;

public class ProductBaseDto
{
    public required string Name { get; set; }
    
    public string? Description { get; set; }
    
    public required string SKU   { get; set; }
    
    public required double UnitPrice { get; set; }
}