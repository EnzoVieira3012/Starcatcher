namespace API.Application.DTOs
{
    public class QuotaDto
    {
        public int Id { get; set; }
        public int ConsortiumId { get; set; }
        public required string Status { get; set; }
    }
}