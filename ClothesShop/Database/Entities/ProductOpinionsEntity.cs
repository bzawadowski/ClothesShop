namespace ClothesShop.Database.Entities
{
    public class ProductOpinionsEntity
    {
        public string? Id { get; set; }
        public uint Value { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Comment { get; set; }
        public int ProductId { get; set; }
        public string? UserId { get; set; }
        public ProductEntity? Product { get; set; }
        public UserEntity? User { get; set; }
        public ProductOpinionsEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
        }
        
    }
}
