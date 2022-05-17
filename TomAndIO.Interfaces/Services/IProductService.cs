using TomAndIO.Models;
using TomAndIO.Models.Dto;
using TomAndIO.Models.Entities;
using TomAndIO.Models.Page;

namespace TomAndIO.Interfaces.Services;

public interface IProductService
{
    ProductOverviewPage GetProductListOfFeaturedProducts(int pageNumber);

    ProductOverviewPage GetProductListForCategory(Category category, int pageNumber);

    ProductDetailDto GetProductDetail(Product product);

    Product AddProduct(ProductCreateDto productDto);

    ProductOverviewPage GetProductListForSearch(String keyword, int pageNumber);
}