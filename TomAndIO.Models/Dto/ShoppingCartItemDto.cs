namespace TomAndIO.Models.Dto;

public class ShoppingCartItemDto
{
    public ShoppingCartItemDto(long id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
    
    public long Id { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }
}