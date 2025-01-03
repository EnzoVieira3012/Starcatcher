namespace API.Domain.Entities
{
    public class Consortium
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal AssetValue { get; set; }
        public int NumberOfInstallments { get; set; }
        public decimal AdministrationFee { get; set; }
        public int NumberOfQuotas { get; set; }
        public decimal QuotaValue { get; set; }
        public Guid UserId { get; set; }
        public ICollection<Quota> Quotas { get; set; } = new List<Quota>();
    }
}