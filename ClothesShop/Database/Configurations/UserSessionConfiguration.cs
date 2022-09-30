using ClothesShop.ConstValues;
using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    public class UserSessionConfiguration : IEntityTypeConfiguration<UserSessionEntity>
    {
        public void Configure(EntityTypeBuilder<UserSessionEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithOne().HasForeignKey<UserSessionEntity>(x => x.UserId);

            builder.Property(x => x.Id).HasDefaultValue(Guid.NewGuid().ToString());
            builder.Property(x => x.CreatedOn).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.UpdatedOn).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.ExpiresOn).HasDefaultValue(DateTime.UtcNow.AddMinutes(PageValues.SessionTime));
        }
    }
}
