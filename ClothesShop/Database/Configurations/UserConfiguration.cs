using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    /// <summary>
    /// Configuration of User table
    /// </summary>
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            //Already set primary key due IdentityUser inheritation
            builder.HasOne(x => x.Address).WithMany(x => x.Residents).HasForeignKey(x => x.AddressId);
        }
    }
}
