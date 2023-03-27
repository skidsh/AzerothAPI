using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Blog
{
    public partial class Post
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? Title { get; set; }
        public byte[]? Text { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? ChangedDate { get; set; }
    }
}
