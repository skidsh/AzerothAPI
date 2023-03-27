namespace AzerothAPI.DTO.Blog
{
    public partial class PostDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? ChangedDate { get; set; }
    }
}
