using ClothesShop.ConstValues;

namespace ClothesShop.Database.Entities
{
    public class UserSessionEntity
    {
        public string? Id { get; set; }
        public string? Token { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime ExpiresOn { get; set; }
        public string? UserId { get; set; }
        public UserEntity? User { get; set; }
        public UserSessionEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
            this.UpdatedOn = this.CreatedOn;
            this.ExpiresOn = this.CreatedOn.AddMinutes(PageValues.SessionTime);
        }
        public void RefreshSession(string token)
        {
            this.Token = token;
            this.UpdatedOn = DateTime.UtcNow;
            this.ExpiresOn = this.UpdatedOn.AddMinutes(PageValues.SessionTime);
        }
        public bool IsActive() => this.ExpiresOn > DateTime.UtcNow;
    }
}
