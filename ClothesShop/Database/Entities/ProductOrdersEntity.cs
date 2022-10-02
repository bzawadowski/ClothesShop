using ClothesShop.ConstValues;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    /// <summary>
    /// Table that represents order of products
    /// </summary>
    [DisplayColumn(DBValues.tableProductOrders)]
    public class ProductOrdersEntity
    {
        [DisplayName(DBValues.columnProductKey)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int ProductId { get; set; }
        [DisplayName(DBValues.columnOrderKey)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(450, ErrorMessage = DBValues.errMaxLength)]
        public string? OrderId { get; set; }
        public virtual ProductEntity? Product { get; set; }
        public virtual OrderEntity? Order { get; set; }
    }
}
