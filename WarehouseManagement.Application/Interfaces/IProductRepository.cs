using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Interfaces;

public interface IProductRepository
{
    product AddProduct(Product product);
    
    Product  UpdateProduct(Product product);
    
    Product DeleteProduct(Product product);
    
    Product GetProduct(Guid id);
    
    List<Product> GetProducts();
}