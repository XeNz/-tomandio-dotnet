namespace TomAndIO.Models.Entities;

public class Product
{
    public Product(string name, double price, string description,
        bool featured, string imageUrl, Category category)
    {
        Name = name;
        Price = price;
        Description = description;
        Featured = featured;
        ImageUrl = imageUrl;
        Category = category;
    }

    public long Id { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }

    public string Description { get; set; }

    public bool Featured { get; set; }

    public string ImageUrl { get; set; }

    public Category Category { get; set; }
}