using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    /// <summary>
    /// Configuration of AvailableProducts table
    /// </summary>
    public class AvailableProductsConfiguration : IEntityTypeConfiguration<AvailableProductsEntity>
    {
        public void Configure(EntityTypeBuilder<AvailableProductsEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany(x => x.AvailableProducts).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Size).WithMany(x => x.AvailableProducts).HasForeignKey(x => x.SizeId).OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.InStock).HasDefaultValue(0);
        }
    }
}
