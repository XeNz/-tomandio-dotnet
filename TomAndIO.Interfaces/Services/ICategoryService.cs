using TomAndIO.Models.Entities;

namespace TomAndIO.Interfaces.Services;

public interface ICategoryService
{
    List<Category> GetCategoryList();
}