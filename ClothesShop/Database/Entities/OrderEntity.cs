using ClothesShop.ConstValues;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    [DisplayColumn(DBValues.tableOrder)]
    public class OrderEntity
    {
        [DisplayName(DBValues.columnOrderKey)]
        [MaxLength(1000, ErrorMessage = DBValues.errMaxLength)]
        public string? Id { get; set; }
        [DisplayName(DBValues.columnCreatedDate)]
        [Required(ErrorMessage = DBValues.errNull)]
        public DateTime CreatedOn { get; set; }
        [DisplayName(DBValues.columnExecutedDate)]
        public DateTime Executed { get; set; }
        [DisplayName(DBValues.columnIsPaid)]
        [Required(ErrorMessage = DBValues.errNullOrEmpty)]
        public bool IsPaid { get; set; }
        [DisplayName(DBValues.columnIsSent)]
        [Required(ErrorMessage = DBValues.errNullOrEmpty)]
        public bool IsSent { get; set; }
        [DisplayName(DBValues.columnIsDelivered)]
        [Required(ErrorMessage = DBValues.errNullOrEmpty)]
        public bool IsDelivered { get; set; }
        [DisplayName(DBValues.columnUserKey)]
        [Required(AllowEmptyStrings = false ,ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(1000, ErrorMessage = DBValues.errMaxLength)]
        public string? UserId { get; set; }
        public UserEntity? User { get; set; }
        public ICollection<ProductOrdersEntity> UserOrders { get; set; }
        public OrderEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
            this.IsPaid = false;
            this.IsSent = false;
            this.IsDelivered = false;
            this.UserOrders = new List<ProductOrdersEntity>();
        }
        public void SetExecutionDate() => this.Executed = DateTime.UtcNow;

    }
}
