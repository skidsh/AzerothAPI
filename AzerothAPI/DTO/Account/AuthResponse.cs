namespace AzerothAPI.DTO.Account
{
    public partial class AuthResponse
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
        public bool IsAdmin { get; set; }
    }
}
