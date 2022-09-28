using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    public class ProductMarkConfiguration : IEntityTypeConfiguration<ProductMarkEntity>
    {
        public void Configure(EntityTypeBuilder<ProductMarkEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
