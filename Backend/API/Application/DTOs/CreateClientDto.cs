namespace API.Application.DTOs
{
    public class CreateClientDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}