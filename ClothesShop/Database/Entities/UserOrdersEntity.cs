namespace ClothesShop.Database.Entities
{
    public class UserOrdersEntity
    {
        public int ProductId { get; set; }
        public string? OrderId { get; set; }
        public ProductEntity? Product { get; set; }
        public UserEntity? User { get; set; }
    }
}
