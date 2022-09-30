using ClothesShop.ConstValues;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    [DisplayColumn(DBValues.tableProduct)]
    public class ProductEntity
    {
        [DisplayName(DBValues.columnProductKey)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valOpinionMax)]
        public int Id { get; set; }
        [DisplayName(DBValues.columnProductName)]
        [Required(AllowEmptyStrings = false ,ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(100, ErrorMessage = DBValues.errMaxLength)]
        public string? FullName { get; set; }
        [DisplayName(DBValues.columnProductPrice)]
        [Range(DBValues.valRangeZero, 10000)]
        public decimal Price { get; set; }
        [DisplayName(DBValues.columnImage)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(200, ErrorMessage = DBValues.errMaxLength)]
        public string? ImgName { get; set; }
        [DisplayName(DBValues.columnDescription)]
        [MaxLength(5000, ErrorMessage = DBValues.errMaxLength)]
        public string? Description { get; set; }
        [DisplayName(DBValues.columnIsItInStock)]
        [Required(ErrorMessage = DBValues.errNull)]
        public bool IsItInStock { get; set; }
        [DisplayName(DBValues.columnDiscount)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeZero, DBValues.valDiscountRange)]
        public float Discount { get; set; }
        [DisplayName(DBValues.columnGender)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeZero, DBValues.valGenderCount)]
        public int GenderId { get; set; }
        [DisplayName(DBValues.columnColor)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int ColorId { get; set; }
        [DisplayName(DBValues.columnMarkKey)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int MarkId { get; set; }
        [DisplayName(DBValues.columnTypeKey)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int TypeId { get; set; }
        public ProductMarkEntity? Mark { get; set; }
        public ProductTypeEntity? Type { get; set; }
        public ICollection<ProductOpinionsEntity> Opinions { get; set; }
        public ICollection<AvailableProductsEntity> AvailableProducts { get; set; }
        public ICollection<ProductOrdersEntity> Orders { get; set; }
        public ProductEntity()
        {
            this.IsItInStock = true;
            this.Discount = 0;
            this.Opinions = new List<ProductOpinionsEntity>();
            this.AvailableProducts = new List<AvailableProductsEntity>();
            this.Orders = new List<ProductOrdersEntity>();
        }
    }
}
