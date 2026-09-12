using WarehouseManagement.Application.Dtos;

namespace WarehouseManagement.Application.Interfaces;

public interface IProductService
{
    ProductDto CreateProduct(CreateProductDto createProductDto);
    ProductDto UpdateProduct(UpdateProductDto updateProductDto);
    ProductDto DeleteProduct(Guid id);
    ProductDto GetProduct(Guid id);
    List<ProductDto> GetProducts(List<Guid>? ProductIds);
}