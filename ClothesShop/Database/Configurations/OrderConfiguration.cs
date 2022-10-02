using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    /// <summary>
    /// Configuration of Order table
    /// </summary>
    public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);

            builder.Property(x => x.IsPaid).HasDefaultValue(false);
            builder.Property(x => x.IsSent).HasDefaultValue(false);
            builder.Property(x => x.IsDelivered).HasDefaultValue(false);
            builder.Property(x => x.CreatedOn).HasDefaultValue(DateTime.UtcNow);
        }
    }
}
