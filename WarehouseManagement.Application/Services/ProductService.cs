using WarehouseManagement.Application.Dtos;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Services;

public class ProductService: IProductService
{
    private readonly IProductRepository _productRepository;
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
        
    } 
    public ProductDto CreateProduct(CreateProductDto createProductDto)
    {
        if (createProductDto.UnitPrice < 0)
        {
            throw new ArgumentException("Price cannot be negative");
        }

        var product = new Product
        {
            Name = createProductDto.Name,
            UnitPrice = createProductDto.UnitPrice,
            Description = createProductDto.Description,
            SKU = createProductDto.SKU,
            
        };
       var createdProduct =  _productRepository.AddProduct(product);
       return new ProductDto
       {
           Id = createdProduct.Id,
           Name = createdProduct.Name,
           UnitPrice = createdProduct.UnitPrice,
           Description = createdProduct.Description,
           SKU = createdProduct.SKU
       };
    }

    public ProductDto UpdateProduct(UpdateProductDto updateProductDto)
    {
        throw new NotImplementedException();
    }

    public ProductDto DeleteProduct(Guid id)
    {
        throw new NotImplementedException();
    }

    public ProductDto GetProduct(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<ProductDto> GetProducts(List<Guid>? ProductIds)
    {
        throw new NotImplementedException();
    }
}