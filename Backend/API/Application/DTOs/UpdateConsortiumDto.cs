namespace API.Application.DTOs
{
    public class UpdateConsortiumDto
    {
        public decimal? AssetValue { get; set; }
        public int? NumberOfInstallments { get; set; }
        public decimal? AdministrationFee { get; set; }
        public int? NumberOfQuotas { get; set; }
        public decimal? QuotaValue { get; set; }
    }
}