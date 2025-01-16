namespace API.Domain.Entities
{
    public class Installment
    {
        public int Id { get; set; }
        public int QuotaId { get; set; }
        public Quota Quota { get; set; } = null!;
        public decimal Value { get; set; }
        public InstallmentStatus Status { get; set; } = InstallmentStatus.Pendente;
    }

    public enum InstallmentStatus
    {
        Pendente,
        Pago
    }
}