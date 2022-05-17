using TomAndIO.Interfaces.Services;

namespace TomAndIO.Web.Controllers;

public class ShoppingCartController
{
    private readonly IProductService _productService;
    private readonly IShoppingCartService _shoppingCartService;
    
    public ShoppingCartController(IProductService productService, IShoppingCartService shoppingCartService)
    {
        _productService = productService;
        _shoppingCartService = shoppingCartService;
    }

    // GET
    public void GetShoppingCart()
    {
    }

    // POST
    public void AddProductToShoppingCart()
    {
    }

    // POST
    public void RemoveProductFromShoppingCart()
    {
    }
}