namespace ClothesShop.Database.Entities
{
    public class ProductMarkEntity
    {
        public int Id { get; set; }
        public string? MarkName { get; set; }
        public string? ImgLogo { get; set; }
        public bool IsPopular { get; set; }
        public bool IsPromoted { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
        public ProductMarkEntity()
        {
            this.IsPopular = false;
            this.IsPromoted = false;
            this.Products = new List<ProductEntity>();
        }
    }
}
