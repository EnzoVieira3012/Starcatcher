using System.ComponentModel.DataAnnotations;
using Starcatcher.Api.Domain.Entities;

namespace Starcatcher.Api.Application.DTO
{
    public class CreationConsortiumDto
    {
        [Required(ErrorMessage = "Type is required")]
        public required ConsortiumType Type { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "AssetValue is required")]
        [Range(1, double.MaxValue, ErrorMessage = "AssetValue must be a positive number")]
        public decimal AssetValue { get; set; }

        [Required(ErrorMessage = "QuotaQuantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "QuotaQuantity must be at least 1")]
        public int QuotaQuantity { get; set; }

        [Required(ErrorMessage = "AdministrationFee is required")]
        [Range(0, 100, ErrorMessage = "AdministrationFee must be between 0 and 100")]
        public int AdministrationFee { get; set; }

        public Consortium ToEntity()
        {
            return new Consortium
            {
                Type = Type,
                Description = Description,
                AssetValue = AssetValue,
                QuotaQuantity = QuotaQuantity,
                AdministrationFee = AdministrationFee
            };
        }
    }
}