namespace Todo.Infrastructure.Persistence.Entities
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime? ModifiedOn { get; set; }

        public string CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
