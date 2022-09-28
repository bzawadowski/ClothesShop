using Microsoft.AspNetCore.Identity;

namespace ClothesShop.Database.Entities
{
    public class UserEntity : IdentityUser
    {
        public string? FullAddress { get; set; }
        public string? SessionId { get; set; }
        public int AddressId { get; set; }
        public UserSessionEntity? Session { get; set; }
        public AddressEntity? Address { get; set; }
        public ICollection<OrderEntity> Orders { get; set; }
        public ICollection<ProductOpinionsEntity> UserOpinions { get; set; }
        public UserEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UserOpinions = new List<ProductOpinionsEntity>();
            this.Orders = new List<OrderEntity>();
        }
    }
}
