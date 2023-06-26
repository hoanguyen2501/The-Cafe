using CoffeeBook.Contracts;
using CoffeeBook.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeBook.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            // Add Service DI
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IBillService, BillService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IManagerService, ManagerService>();
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<IProductTypeService, ProductTypeService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IShoppingCartService, ShoppingCartService>();
            services.AddScoped<IShoppingCartProductService, ShoppingCartProductService>();
            services.AddScoped<IStoreService, StoreService>();
            services.AddScoped<ISupplierService, SupplierService>();

            return services;
        }
    }
}