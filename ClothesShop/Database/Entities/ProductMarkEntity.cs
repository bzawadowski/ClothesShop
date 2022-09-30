using ClothesShop.ConstValues;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    [DisplayColumn(DBValues.tableProductMark)]
    public class ProductMarkEntity
    {
        [DisplayName(DBValues.columnMarkKey)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valOpinionMax)]
        public int Id { get; set; }
        [DisplayName(DBValues.columnMark)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(50, ErrorMessage = DBValues.errMaxLength)]
        public string? MarkName { get; set; }
        [DisplayName(DBValues.columnImage)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(50, ErrorMessage = DBValues.errMaxLength)]
        public string? ImgLogo { get; set; }
        [DisplayName(DBValues.columnIsPopular)]
        [Required(ErrorMessage = DBValues.errNull)]
        public bool IsPopular { get; set; }
        [DisplayName(DBValues.columnIsPromoted)]
        [Required(ErrorMessage = DBValues.errNull)]
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
