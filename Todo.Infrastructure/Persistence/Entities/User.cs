using System.ComponentModel.DataAnnotations;

namespace Todo.Infrastructure.Persistence.Entities
{
    public class User : BaseAuditableEntity
    {
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(256)]
        public string Email { get; set; }

        public string PasswordHash { get; set; }
    }
}
