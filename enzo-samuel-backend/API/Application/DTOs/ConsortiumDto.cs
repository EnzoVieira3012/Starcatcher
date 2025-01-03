namespace API.Application.DTOs
{
    public class ConsortiumDto
    {
        public ConsortiumDto(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal AssetValue { get; set; }
        public int NumberOfInstallments { get; set; }
        public decimal AdministrationFee { get; set; }
        public int NumberOfQuotas { get; set; }
        public decimal QuotaValue { get; set; }
    }
}