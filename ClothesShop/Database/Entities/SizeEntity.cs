using ClothesShop.ConstValues;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    /// <summary>
    /// Table that represents Size of items
    /// </summary>
    [DisplayColumn(DBValues.tableSize)]
    public class SizeEntity
    {
        [DisplayName(DBValues.columnSizeKey)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int Id { get; set; }
        [DisplayName(DBValues.columnSize)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(5, ErrorMessage = DBValues.errMaxLength)]
        public string? Size { get; set; }
        [DisplayName(DBValues.columnMinValue)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valMaxValue)]
        public uint MinValue { get; set; }
        [DisplayName(DBValues.columnMaxValue)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valMaxValue)]
        public uint MaxValue { get; set; }
        [DisplayName(DBValues.columnTypeKey)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int TypeId { get; set; }
        public virtual ProductTypeEntity? ProductType { get; set; }
        public virtual ICollection<AvailableProductsEntity> AvailableProducts { get; set; }
        public SizeEntity()
        {
            this.AvailableProducts = new List<AvailableProductsEntity>();
        }
    }
}
