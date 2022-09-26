namespace ClothesShop.Database.Entities
{
    public class ShopEntity
    {
        public int Id { get; set; }
        public string? FullAddress { get; set; }
        public string? ImgName { get; set; }
        public int AddressId { get; set; }
        public AddressEntity? Address { get; set; }
    }
}
