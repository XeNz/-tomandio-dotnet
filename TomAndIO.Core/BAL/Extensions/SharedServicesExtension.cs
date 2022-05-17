using Microsoft.Extensions.DependencyInjection;
using TomAndIO.Interfaces.Services;

namespace TomAndIO.Core.BAL.Extensions;

public static class SharedServicesExtension
{
    public static IServiceCollection AddSharedServices(this IServiceCollection services)
    {
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IShoppingCartService, ShoppingCartService>();

        return services;
    }
}