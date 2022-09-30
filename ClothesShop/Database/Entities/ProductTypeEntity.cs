using ClothesShop.ConstValues;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    [DisplayColumn(DBValues.tableProductType)]
    public class ProductTypeEntity
    {
        [DisplayName(DBValues.columnTypeKey)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int Id { get; set; }
        [DisplayName(DBValues.columnType)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(50, ErrorMessage = DBValues.errMaxLength)]
        public string? Name { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
        public ICollection<SizeEntity> Sizes { get; set; }
        public ProductTypeEntity()
        {
            this.Sizes = new List<SizeEntity>();
            this.Products = new List<ProductEntity>();
        }
    }
}
