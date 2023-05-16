using AE.Domain.Common;

namespace AE.Domain.Entities;

public class BaseAuditableEntity : EntityBase, IAuditableEntity
{
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}