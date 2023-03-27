namespace AzerothAPI.DTO
{
    public partial class CreateAccountRequest
    {
        public string? Username { get; set; }
        public string? EncodedPassword { get; set; }
        public string? Email { get; set; }
    }
}
