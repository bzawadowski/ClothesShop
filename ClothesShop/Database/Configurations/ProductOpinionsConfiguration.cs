using ClothesShop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesShop.Database.Configurations
{
    /// <summary>
    /// Configuration of ProductOpinion table
    /// </summary>
    public class ProductOpinionsConfiguration : IEntityTypeConfiguration<ProductOpinionsEntity>
    {
        public void Configure(EntityTypeBuilder<ProductOpinionsEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany(x => x.Opinions).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.User).WithMany(x => x.UserOpinions).HasForeignKey(x => x.UserId);

            builder.Property(x => x.CreatedOn).HasDefaultValue(DateTime.UtcNow);
        }
    }
}
