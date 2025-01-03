namespace API.Domain.Entities
{
    public class Quota
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int ConsortiumId { get; set; }
        public Consortium Consortium { get; set; } = null!;
        public QuotaStatus Status { get; set; }
        public ICollection<Installment> Installments { get; set; } = new List<Installment>();
        public int? ClientId { get; set; }
        public Client? Client { get; set; }
    }

    public enum QuotaStatus
    {
        Disponivel,
        Vinculada,
        Inativa
    }
}