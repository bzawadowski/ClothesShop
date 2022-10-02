using ClothesShop.Database.Entities;
using ClothesShop.Database.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClothesShop.Database.DBContexts
{
    /// <summary>
    /// Product context that represents connection between application and database
    /// </summary>
    public class ProductDB : IdentityDbContext
    {
        public ProductDB(DbContextOptions<ProductDB> options) : base(options)
        {

        }

        public DbSet<AddressEntity>? Address { get; set; }
        public DbSet<AvailableProductsEntity>? AvailableProducts { get; set; }
        public DbSet<OrderEntity>? Order { get; set; }
        public DbSet<ProductEntity>? Product { get; set; }
        public DbSet<ProductMarkEntity>? Mark { get; set; }
        public DbSet<ProductOpinionsEntity>? Opinions { get; set; }
        public DbSet<ProductOrdersEntity>? ProductOrders { get; set; }
        public DbSet<ProductTypeEntity>? ProductType { get; set; }
        public DbSet<ShopEntity>? Shop { get; set; }
        public DbSet<SizeEntity>? Size { get; set; }
        public DbSet<UserEntity>? User { get; set; }
        public DbSet<UserSessionEntity>? UserSession { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyAllConfigurations();
        }
    }
}
