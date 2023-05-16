namespace AE.Domain.Entities;

public class Port : BaseAuditableEntity
{
    public string Name { get; set; } = default!;
    public Geolocation Geolocation { get; set; } = default!;
}