namespace ClothesShop.Database.Entities
{
    public class SizeEntity
    {
        public int Id { get; set; }
        public string? Size { get; set; }
        public uint MinValue { get; set; }
        public uint MaxValue { get; set; }
        public int TypeId { get; set; }
        public ProductTypeEntity? ProductType { get; set; }
        public ICollection<AvailableProductsEntity> AvailableProducts { get; set; }
        public SizeEntity()
        {
            this.AvailableProducts = new List<AvailableProductsEntity>();
        }
    }
}
