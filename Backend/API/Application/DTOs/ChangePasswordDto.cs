namespace API.Application.DTOs
{
    public class ChangePasswordDto
    {
        public string? Email { get; set; }
        public string? NewPassword { get; set; }
    }
}