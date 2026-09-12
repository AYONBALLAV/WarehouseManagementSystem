using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Interfaces;

public interface IProductRepository
{
    Product AddProduct(Product product);
    
    Product  UpdateProduct(Product product);
    
    Product DeleteProduct(Product product);
    
    Product GetProduct(Guid id);
    
    List<Product> GetProducts(List<Guid>? ProductIds);
}