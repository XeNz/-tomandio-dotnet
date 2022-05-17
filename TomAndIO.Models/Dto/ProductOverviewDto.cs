namespace TomAndIO.Models.Dto;

public class ProductOverviewDto
{
    public ProductOverviewDto(long id, string name, double price, string imageUrl)
    {
        Id = id;
        Name = name;
        Price = price;
        ImageUrl = imageUrl;
    }

    public long Id { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }

    public string ImageUrl { get; set; }
}