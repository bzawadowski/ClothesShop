using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            //Already set primary key due IdentityUser inheritation
            builder.HasOne(x => x.Session).WithOne(x => x.User).HasForeignKey<UserEntity>(x => x.SessionId);
            builder.HasOne(x => x.Address).WithMany(x => x.Residents).HasForeignKey(x => x.AddressId);
        }
    }
}
