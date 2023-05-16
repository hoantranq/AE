namespace AE.Domain.Common;

public interface IAuditableEntity : IEntityBase
{
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}