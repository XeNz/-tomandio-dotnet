using TomAndIO.Interfaces.Services;
using TomAndIO.Models.Dto;
using TomAndIO.Models.Entities;

namespace TomAndIO.Web.Controllers;

public class CategoryController
{
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;

    public CategoryController(IProductService productService, ICategoryService categoryService)
    {
        _productService = productService;
        _categoryService = categoryService;
    }

    // GET
    public void GetAllCategories()
    {
        var categoryDtos = _categoryService.GetCategoryList()
            .Select(category => new CategoryDto(category.Id, category.Name))
            .ToList();
    }

    // GET
    public void FeaturedProducts(int pageNumber)
    {
        var featuredProducts = _productService.GetProductListOfFeaturedProducts(pageNumber);
    }

    // GET
    public void GetSearchedProducts(int pageNumber, string search)
    {
        var searchedProducts = _productService.GetProductListForSearch(search, pageNumber);
    }

    // GET
    public void ProductsForCategory(int pageNumber, Category category)
    {
        var categoryProducts = _productService.GetProductListForCategory(category, pageNumber);
        var categoryProductsDto = new CategoryProductsDto(category, categoryProducts);
    }
}