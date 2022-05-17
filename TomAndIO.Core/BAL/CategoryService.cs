using TomAndIO.Core.DAL;
using TomAndIO.Interfaces.Services;
using TomAndIO.Models.Entities;

namespace TomAndIO.Core.BAL;

public class CategoryService : ICategoryService
{
    private readonly ShoppingContext _shoppingContext;

    public CategoryService(ShoppingContext shoppingContext)
    {
        _shoppingContext = shoppingContext;
    }
    
    public List<Category> GetCategoryList()
    {
        return _shoppingContext.Categories.ToList();
    }
}