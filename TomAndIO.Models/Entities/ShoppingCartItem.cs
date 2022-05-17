namespace TomAndIO.Models.Entities;

public class ShoppingCartItem
{
    public ShoppingCartItem(long id)
    {
        Id = id;
    }
    
    public ShoppingCartItem(ShoppingCart shoppingCart, Product product)
    {
        ShoppingCart = shoppingCart;
        Product = product;
    }

    public long Id { get; set; }

    public ShoppingCart? ShoppingCart { get; set; }

    public Product? Product { get; set; }
}