using ClothesShop.ConstValues;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    [DisplayColumn(DBValues.tableProductOpinion)]
    public class ProductOpinionsEntity
    {
        [DisplayName(DBValues.columnOpinionKey)]
        [MaxLength(1000, ErrorMessage = DBValues.errMaxLength)]
        public string? Id { get; set; }
        [DisplayName(DBValues.columnRate)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valOpinionMax)]
        public uint Value { get; set; }
        [DisplayName(DBValues.columnCreatedDate)]
        [Required(ErrorMessage = DBValues.errNull)]
        public DateTime CreatedOn { get; set; }
        [DisplayName(DBValues.columnComment)]
        [Required(AllowEmptyStrings = false ,ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(1000, ErrorMessage = DBValues.errMaxLength)]
        public string? Comment { get; set; }
        [DisplayName(DBValues.columnProductKey)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int ProductId { get; set; }
        [DisplayName(DBValues.columnUserKey)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(1000, ErrorMessage = DBValues.errMaxLength)]
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
