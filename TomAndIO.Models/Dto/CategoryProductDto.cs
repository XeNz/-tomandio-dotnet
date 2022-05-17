namespace TomAndIO.Models.Dto;

public class CategoryProductDto
{
    public CategoryProductDto(CategoryDto categoryDto, ProductDetailDto productDetailDto)
    {
        Category = categoryDto;
        ProductDetail = productDetailDto;
    }

    public CategoryDto Category { get; set; }

    public ProductDetailDto ProductDetail { get; set; }
}