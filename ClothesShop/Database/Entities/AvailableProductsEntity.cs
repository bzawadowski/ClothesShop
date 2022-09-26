namespace ClothesShop.Database.Entities
{
    public class AvailableProductsEntity
    {
        public int Id { get; set; }
        public uint InStock { get; set; }
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public ProductEntity? Product { get; set; }
        public SizeEntity? Size { get; set; }
    }
}
