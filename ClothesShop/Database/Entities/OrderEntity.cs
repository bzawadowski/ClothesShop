namespace ClothesShop.Database.Entities
{
    public class OrderEntity
    {
        public string? Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime Executed { get; set; }
        public bool IsPaid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDelivered { get; set; }
        public string? UserId { get; set; }
        public UserEntity? User { get; set; }
        public ICollection<UserOrdersEntity> UserOrders { get; set; }
        public OrderEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
            this.IsPaid = false;
            this.IsSent = false;
            this.IsDelivered = false;
            this.UserOrders = new List<UserOrdersEntity>();
        }
        public void SetExecutionDate() => this.Executed = DateTime.UtcNow;

    }
}
