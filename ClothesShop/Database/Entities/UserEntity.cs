using ClothesShop.ConstValues;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    /// <summary>
    /// Table that represents User/Client
    /// </summary>
    [DisplayColumn(DBValues.tableUser)]
    public class UserEntity : IdentityUser
    {
        [DisplayName(DBValues.columnAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(100, ErrorMessage = DBValues.errMaxLength)]
        public string? FullAddress { get; set; }
        [DisplayName(DBValues.columnAddressKey)]
        [Required(ErrorMessage = DBValues.errNull)]
        [Range(DBValues.valRangeGeneralMin, DBValues.valRangeIntMax)]
        public int AddressId { get; set; }
        public virtual UserSessionEntity? Session { get; set; }
        public virtual AddressEntity? Address { get; set; }
        public virtual ICollection<OrderEntity> Orders { get; set; }
        public virtual ICollection<ProductOpinionsEntity> UserOpinions { get; set; }
        public UserEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UserOpinions = new List<ProductOpinionsEntity>();
            this.Orders = new List<OrderEntity>();
        }
    }
}
