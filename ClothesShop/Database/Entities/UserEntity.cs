using Microsoft.AspNetCore.Identity;

namespace ClothesShop.Database.Entities
{
    public class UserEntity : IdentityUser
    {
        public UserSessionEntity? Session { get; set; }
        public ICollection<ProductOpinionsEntity> UserOpinions { get; set; }
        public ICollection<UserOrdersEntity> UserOrders { get; set; }
        public UserEntity()
        {
            this.UserOpinions = new List<ProductOpinionsEntity>();
            this.UserOrders = new List<UserOrdersEntity>();
        }
    }
}
