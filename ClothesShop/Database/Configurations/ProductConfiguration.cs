using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    /// <summary>
    /// Configuration of Product table
    /// </summary>
    public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Mark).WithMany(x => x.Products).HasForeignKey(x => x.MarkId);
            builder.HasOne(x => x.Type).WithMany(x => x.Products).HasForeignKey(x => x.TypeId);

            builder.Property(x => x.IsItInStock).HasDefaultValue(true);
            builder.Property(x => x.Discount).HasDefaultValue(0);
            builder.Property(x => x.Price).HasColumnType("decimal(8,2)");
        }
    }
}
