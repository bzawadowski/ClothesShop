using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    /// <summary>
    /// Configuration of ProductType table
    /// </summary>
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductTypeEntity>
    {
        public void Configure(EntityTypeBuilder<ProductTypeEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
