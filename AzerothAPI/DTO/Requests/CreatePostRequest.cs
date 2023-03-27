namespace AzerothAPI.DTO
{
    public partial class CreatePostRequest
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public string JWT { get; set; }
    }
}
