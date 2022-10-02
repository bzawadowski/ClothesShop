using ClothesShop.Database.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClothesShop.ServiceConfigurations
{
    /// <summary>
    /// Set database connections
    /// </summary>
    public static class DatabaseConnectionConfiguration
    {
        /// <summary>
        /// Set ClothesShopProductDB connection represented by ProductDB context
        /// </summary>
        /// <param name="service"></param>
        /// <param name="configuration"></param>
        public static void SetProductDBConnection(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ProductDB>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ProductDB")));
        }
    }
}
