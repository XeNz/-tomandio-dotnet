using TomAndIO.Core.BAL.Extensions;
using TomAndIO.Core.DAL;
using TomAndIO.Interfaces.Services;
using TomAndIO.Models.Dto;
using TomAndIO.Models.Entities;
using TomAndIO.Models.Entities.Pagination;
using TomAndIO.Models.Page;

namespace TomAndIO.Core.BAL;

public class ProductService : IProductService
{
    private static readonly int PageSize = 12;

    private readonly ShoppingContext _shoppingContext;

    public ProductService(ShoppingContext shoppingContext)
    {
        _shoppingContext = shoppingContext;
    }

    public ProductOverviewPage GetProductListOfFeaturedProducts(int pageNumber)
    {
        var pagedResult = _shoppingContext.Products.GetPage(pageNumber, PageSize);
        return MapPagedResultToProductOverviewPage(pagedResult);
    }

    public ProductOverviewPage GetProductListForCategory(Category category, int pageNumber)
    {
        var pagedResult = _shoppingContext.Products
            .Where(product => product.Category == category)
            .GetPage(pageNumber, PageSize);
        return MapPagedResultToProductOverviewPage(pagedResult);
    }

    public ProductDetailDto GetProductDetail(Product product)
    {
        return new ProductDetailDto(product.Id, product.Name, product.Price, product.Description, product.ImageUrl);
    }

    public Product AddProduct(ProductCreateDto productDto)
    {
        var product = new Product(productDto.Name, productDto.Price, productDto.Description,
            productDto.Featured, productDto.ImageUrl, productDto.Category);
        
        _shoppingContext.Products.Add(product);
        _shoppingContext.SaveChanges();
        
        return product;
    }

    public ProductOverviewPage GetProductListForSearch(String keyword, int pageNumber)
    {
        var pagedResult = _shoppingContext.Products
            .Where(product => product.Name.Contains(keyword))
            .GetPage(pageNumber, PageSize);
        return MapPagedResultToProductOverviewPage(pagedResult);
    }

    private ProductOverviewPage MapPagedResultToProductOverviewPage(PagedResult<Product> pagedResult)
    {
        var productOverviewDtos = pagedResult.Results
            .Select(product => new ProductOverviewDto(product.Id, product.Name, product.Price, product.ImageUrl))
            .ToList();
        
        return new ProductOverviewPage(pagedResult.CurrentPage, pagedResult.PageCount,
            false, false, productOverviewDtos);
    }
}