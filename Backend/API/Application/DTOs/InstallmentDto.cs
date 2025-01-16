namespace API.Application.DTOs
{
    public class InstallmentDto
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}