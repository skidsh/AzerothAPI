using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class PowerdisplayDbc
    {
        public int Id { get; set; }
        public int ActualType { get; set; }
        public string? GlobalstringBaseTag { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }
}
