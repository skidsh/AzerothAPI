using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class GameGraveyard
    {
        public int Id { get; set; }
        public int Map { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public string? Comment { get; set; }
    }
}
