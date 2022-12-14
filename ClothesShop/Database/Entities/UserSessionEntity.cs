using ClothesShop.ConstValues;
using ClothesShop.ExtensionMethods;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothesShop.Database.Entities
{
    ///<summary>
    ///Table represents current user session
    ///</summary>
    [DisplayColumn(DBValues.tableUserSession)]
    public class UserSessionEntity
    {
        [DisplayName(DBValues.columnSessionKey)]
        [MaxLength(450, ErrorMessage = DBValues.errMaxLength)]
        public string? Id { get; set; }
        [DisplayName(DBValues.columnToken)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        [MaxLength(1000, ErrorMessage = DBValues.errMaxLength)]
        public string? Token { get; set; }
        [DisplayName(DBValues.columnCreatedDate)]
        [Required(ErrorMessage = DBValues.errNull)]
        public DateTime CreatedOn { get; set; }
        [DisplayName(DBValues.columnUpdatedDate)]
        [Required(ErrorMessage = DBValues.errNull)]
        public DateTime UpdatedOn { get; set; }
        [DisplayName(DBValues.columnExpiredDate)]
        [Required(ErrorMessage = DBValues.errNull)]
        public DateTime ExpiresOn { get; set; }
        [DisplayName(DBValues.columnUserKey)]
        [Required(AllowEmptyStrings = false, ErrorMessage = DBValues.errNullOrEmpty)]
        public string? UserId { get; set; }
        public virtual UserEntity? User { get; set; }
        public UserSessionEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
            this.UpdatedOn = this.CreatedOn;
            this.ExpiresOn = this.CreatedOn.AddMinutes(PageValues.SessionTime);
        }
        public void RefreshSession(string token)
        {
            if (!token.IsNullOrEmpty())
            {
                this.Token = token;
                this.UpdatedOn = DateTime.UtcNow;
                this.ExpiresOn = this.UpdatedOn.AddMinutes(PageValues.SessionTime);
            }
        }
        public bool IsActive() => this.ExpiresOn > DateTime.UtcNow;
    }
}
