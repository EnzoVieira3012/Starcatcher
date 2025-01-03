using System.ComponentModel.DataAnnotations;

namespace Starcatcher.Api.Domain.Entities;

public class Consortium
{
    [Key]
    public int ConsortiumId { get; set; }

    [Required(ErrorMessage = "Type is required")]
    public required ConsortiumType Type { get; set; }

    [Required(ErrorMessage = "Description is required")]
    public required string Description { get; set; }
    public required decimal AssetValue { get; set; }
    public required int QuotaQuantity { get; set; }
    public required int AdministrationFee { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? ClosedAt { get; set; }

    public ICollection<Quota>? Quotas { get; set; }
}

public enum ConsortiumType
{
    PopularCar,
    LuxuryCar,
    PopularMotorcycle,
    ResidentialProperty,
    InternashionalTravel,
    NashionalTravel,
    PropertyRenovation,
    EletronicsDevice,
}