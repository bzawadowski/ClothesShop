namespace ClothesShop.Database.Entities
{
    public class ProductTypeEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<SizeEntity> Sizes { get; set; }
        public ProductTypeEntity()
        {
            this.Sizes = new List<SizeEntity>();
        }
    }
}
