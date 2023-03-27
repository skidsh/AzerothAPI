using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class MovieDbc
    {
        public int Id { get; set; }
        public string? Filename { get; set; }
        public int Volume { get; set; }
    }
}
