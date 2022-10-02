using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    /// <summary>
    /// Configuration of Mark table
    /// </summary>
    public class ProductMarkConfiguration : IEntityTypeConfiguration<ProductMarkEntity>
    {
        public void Configure(EntityTypeBuilder<ProductMarkEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IsPopular).HasDefaultValue(false);
            builder.Property(x => x.IsPromoted).HasDefaultValue(false);
        }
    }
}
