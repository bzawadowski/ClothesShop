using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    public class UserOrdersConfiguration : IEntityTypeConfiguration<UserOrdersEntity>
    {
        public void Configure(EntityTypeBuilder<UserOrdersEntity> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(x => x.Product).WithMany(x => x.Orders).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Order).WithMany(x => x.UserOrders).HasForeignKey(x => x.OrderId);
        }
    }
}
