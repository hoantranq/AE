using AE.Domain.Common;

namespace AE.Domain.Entities;

public class EntityBase : IEntityBase
{
    public Guid Id { get; set; }
}