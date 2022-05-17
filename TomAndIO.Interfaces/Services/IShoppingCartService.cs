using TomAndIO.Models;
using TomAndIO.Models.Dto;
using TomAndIO.Models.Entities;

namespace TomAndIO.Interfaces.Services;

public interface IShoppingCartService
{
    ShoppingCart CreateShoppingCart();

    void AddProductToShoppingCart(ShoppingCart? shoppingCart, Product? product);

    List<ShoppingCartItemDto> GetShoppingCartItems(ShoppingCart? shoppingCart);

    void RemoveProductFromShoppingCart(ShoppingCart? shoppingCart, long itemId);
}