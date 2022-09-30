using ClothesShop.ConstValues;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    [DisplayColumn(DBValues.tableAddress)]
    public class AddressEntity
    {
        [DisplayName(DBValues.columnAddressKey)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int Id { get; set; }
        [DisplayName(DBValues.columnCity)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(50, ErrorMessage = DBValues.errMaxLength)]
        public string? City { get; set; }
        [DisplayName(DBValues.columnProvince)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(50, ErrorMessage = DBValues.errMaxLength)]
        public string? Province { get; set; }
        [DisplayName(DBValues.columnCounty)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(50, ErrorMessage = DBValues.errMaxLength)]
        public string? County { get; set; }
        [DisplayName(DBValues.columnCommunity)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(50, ErrorMessage = DBValues.errMaxLength)]
        public string? Community { get; set; }
        public ICollection<ShopEntity> Shops { get; set; }
        public ICollection<UserEntity> Residents { get; set; }
        public AddressEntity()
        {
            this.Shops = new List<ShopEntity>();
            this.Residents = new List<UserEntity>();
        }
    }
}
