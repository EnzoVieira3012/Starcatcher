namespace API.Application.DTOs
{
    public class CreateConsortiumDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal AssetValue { get; set; }
        public int NumberOfInstallments { get; set; }
        public decimal AdministrationFee { get; set; }
        public int NumberOfQuotas { get; set; }
    }
}