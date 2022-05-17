using TomAndIO.Models.Entities;
using TomAndIO.Models.Page;

namespace TomAndIO.Models.Dto;

public class CategoryProductsDto
{
    public CategoryProductsDto(Category category, ProductOverviewPage productOverviewPage)
    {
        Category = category;
        ProductOverviewPage = productOverviewPage;
    }
    
    public Category Category { get; set; }

    public ProductOverviewPage ProductOverviewPage { get; set; }
}