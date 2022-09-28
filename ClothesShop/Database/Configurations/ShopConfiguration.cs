using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    public class ShopConfiguration : IEntityTypeConfiguration<ShopEntity>
    {
        public void Configure(EntityTypeBuilder<ShopEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Address).WithMany(x => x.Shops).HasForeignKey(x => x.AddressId);
        }
    }
}
