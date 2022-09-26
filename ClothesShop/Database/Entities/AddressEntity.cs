namespace ClothesShop.Database.Entities
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? County { get; set; }
        public string? Community { get; set; }
        public ICollection<ShopEntity> Shops { get; set; }
        public ICollection<UserEntity> Residents { get; set; }
        public AddressEntity()
        {
            this.Shops = new List<ShopEntity>();
            this.Residents = new List<UserEntity>();
        }
    }
}
