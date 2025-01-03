using System.ComponentModel.DataAnnotations;
using Starcatcher.Api.Domain.Entities;

namespace Starcatcher.Api.Application.DTO;

public class ConsortiumDto
{
    public int ConsortiumId { get; set; }
    public required ConsortiumType Type { get; set; }
    public required string Description { get; set; }
    public required decimal AssetValue { get; set; }
    public required int QuotaQuantity { get; set; }
    public required int AdministrationFee { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? ClosedAt { get; set; }
    public ICollection<QuotaDto>? Quotas { get; set; }

    public static ConsortiumDto FromEntity(Consortium consortium)
    {
        return new ConsortiumDto
        {
            ConsortiumId = consortium.ConsortiumId,
            Type = consortium.Type,
            Description = consortium.Description,
            AssetValue = consortium.AssetValue,
            QuotaQuantity = consortium.QuotaQuantity,
            AdministrationFee = consortium.AdministrationFee,
            CreatedAt = consortium.CreatedAt,
            ClosedAt = consortium.ClosedAt,
            Quotas = consortium.Quotas?.Select(QuotaDto.FromEntity).ToList()
        };
    }
}