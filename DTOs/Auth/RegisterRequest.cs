namespace NearU_Backend_Revised.DTOs.Auth
{
    public class RegisterRequest
    {
        public string Email { get; set; } = string.empty;
        public string Password { get; set; } = string.empty;
        public string Role { get; set; } = "Student"
    }
}
