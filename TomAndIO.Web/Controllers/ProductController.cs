using TomAndIO.Interfaces.Services;
using TomAndIO.Models.Dto;
using TomAndIO.Models.Entities;

namespace TomAndIO.Web.Controllers;

public class ProductController
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    // GET
    public void GetProduct(Product product)
    {
        var categoryDto = new CategoryDto(product.Category.Id, product.Category.Name);
        var productDetailDto = _productService.GetProductDetail(product);

        var categoryProductDto = new CategoryProductDto(categoryDto, productDetailDto);
    }

    // POST
    public void AddProduct(ProductCreateDto productDto)
    {
        _productService.AddProduct(productDto);
    }
}