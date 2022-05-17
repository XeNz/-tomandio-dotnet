using TomAndIO.Core.BAL.Extensions;
using TomAndIO.Core.DAL;
using TomAndIO.Interfaces.Services;
using TomAndIO.Models.Dto;
using TomAndIO.Models.Entities;

namespace TomAndIO.Core.BAL;

public class ShoppingCartService : IShoppingCartService
{
    private readonly ShoppingContext _shoppingContext;

    public ShoppingCartService(ShoppingContext shoppingContext)
    {
        _shoppingContext = shoppingContext;
    }

    public ShoppingCart CreateShoppingCart()
    {
        var shoppingCart = new ShoppingCart();

        _shoppingContext.ShoppingCarts.Add(shoppingCart);
        _shoppingContext.SaveChanges();

        return shoppingCart;
    }

    public void AddProductToShoppingCart(ShoppingCart? shoppingCart, Product? product)
    {
        if (product == null || shoppingCart == null) return;

        var shoppingCartItem = new ShoppingCartItem(shoppingCart, product);

        _shoppingContext.ShoppingCartItems.Add(shoppingCartItem);
        _shoppingContext.SaveChanges();
    }

    public List<ShoppingCartItemDto> GetShoppingCartItems(ShoppingCart? shoppingCart)
    {
        if (shoppingCart == null) return new List<ShoppingCartItemDto>();

        return _shoppingContext.ShoppingCartItems
            .Where(item => item.ShoppingCart == shoppingCart)
            .Select(item => new ShoppingCartItemDto(item.Id, item.Product.Name, item.Product.Price))
            .ToList();
    }

    public void RemoveProductFromShoppingCart(ShoppingCart? shoppingCart, long itemId)
    {
        if (shoppingCart == null) return;

        var item = new ShoppingCartItem(itemId);
        _shoppingContext.ShoppingCartItems.Attach(item);
        _shoppingContext.ShoppingCartItems.Remove(item);
        _shoppingContext.SaveChanges();
    }
}