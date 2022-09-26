namespace ClothesShop.Database.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public decimal Price { get; set; }
        public string? ImgName { get; set; }
        public string? Description { get; set; }
        public bool IsItInStock { get; set; }
        public float Discount { get; set; }
        public int GenderId { get; set; }
        public int ColorId { get; set; }
        public int MarkId { get; set; }
        public int TypeId { get; set; }
        public ProductMarkEntity? Mark { get; set; }
        public ProductTypeEntity? Type { get; set; }
        public ICollection<ProductOpinionsEntity> Opinions { get; set; }
        public ICollection<AvailableProductsEntity> AvailableProducts { get; set; }
        public ProductEntity()
        {
            this.IsItInStock = true;
            this.Discount = 0;
            this.Opinions = new List<ProductOpinionsEntity>();
            this.AvailableProducts = new List<AvailableProductsEntity>();
        }
    }
}
