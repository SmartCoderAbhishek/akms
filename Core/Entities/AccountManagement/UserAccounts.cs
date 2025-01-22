using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.AccountManagement
{
    public class UserAccounts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(36)]
        public string? UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? UserName { get; set; }

        [Required]
        [MaxLength(256)]
        public string? Password { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public bool EmailConfirmed { get; set; }

        [MaxLength(15)]
        [Phone]
        public string? MobileNumber { get; set; }

        [Required]
        public bool MobileNumberConfirmed { get; set; } = true;

        [Required]
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual required Role Role { get; set; }

        public bool IsLocked { get; set; } = false;

        public DateTime? LockoutEndDateTime { get; set; } = null;

        [Required]
        [Range(0, 3)]
        public int FailedLoginAttempts { get; set; } = 0;

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedOn { get; set; } = DateTime.Now;

        public DateTime? LastLoginDateTime { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Salt { get; set; }
    }
}
