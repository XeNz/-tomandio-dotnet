using Microsoft.AspNetCore.Mvc;
using TomAndIO.Interfaces.Services;
using TomAndIO.Models.Dto;
using TomAndIO.Models.Entities;

namespace TomAndIO.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public ActionResult<string> GetProduct(Product product)
    {
        var categoryDto = new CategoryDto(product.Category.Id, product.Category.Name);
        var productDetailDto = _productService.GetProductDetail(product);

        var categoryProductDto = new CategoryProductDto(categoryDto, productDetailDto);
        return Ok(categoryProductDto);
    }

    [HttpPost]
    public ActionResult<string> AddProduct(ProductCreateDto productDto)
    {
        _productService.AddProduct(productDto);

        return Ok();
    }
}