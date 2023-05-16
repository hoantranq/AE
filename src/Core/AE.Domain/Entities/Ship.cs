using AE.Domain.Common;

namespace AE.Domain.Entities;

public class Ship : BaseAuditableEntity
{
    public string Name { get; set; } = default!;
    public double Velocity { get; set; } = default!;
    public Geolocation Geolocation { get; set; } = default!;
}
