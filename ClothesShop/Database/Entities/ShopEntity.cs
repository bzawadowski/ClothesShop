using ClothesShop.ConstValues;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    /// <summary>
    /// Table that represents stationary Shop with items
    /// </summary>
    [DisplayColumn(DBValues.tableShop)]
    public class ShopEntity
    {
        [DisplayName(DBValues.columnShopKey)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int Id { get; set; }
        [DisplayName(DBValues.columnAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNull)]
        [MaxLength(100, ErrorMessage = DBValues.errMaxLength)]
        public string? FullAddress { get; set; }
        [DisplayName(DBValues.columnImage)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(100, ErrorMessage = DBValues.errMaxLength)]
        public string? ImgName { get; set; }
        [DisplayName(DBValues.columnAddressKey)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int AddressId { get; set; }
        public virtual AddressEntity? Address { get; set; }
    }
}
