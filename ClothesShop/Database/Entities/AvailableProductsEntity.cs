using ClothesShop.ConstValues;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    /// <summary>
    /// Table that represents Available Products
    /// </summary>
    [DisplayColumn(DBValues.tableAvailableProducts)]
    public class AvailableProductsEntity
    {
        [DisplayName(DBValues.columnAvailableProductKey)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int Id { get; set; }
        [DisplayName(DBValues.columnInStock)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeZero, DBValues.valRangeStock)]
        public uint InStock { get; set; }
        [DisplayName(DBValues.columnProductKey)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int ProductId { get; set; }
        [DisplayName(DBValues.columnSizeKey)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int SizeId { get; set; }
        public virtual ProductEntity? Product { get; set; }
        public virtual SizeEntity? Size { get; set; }
        public AvailableProductsEntity()
        {
            this.InStock = 0;
        }
        public void SubstractInStockValue()
        {
            this.InStock = (this.InStock > 0) ? this.InStock - 1 : 0;
        }
    }
}
