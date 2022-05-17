namespace TomAndIO.Models.Dto;

public class ProductDetailDto
{
    public ProductDetailDto(long id, string name, double price, string description, string imageUrl)
    {
        Id = id;
        Name = name;
        Price = price;
        Description = description;
        ImageUrl = imageUrl;
    }
    
    public long Id { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }
}