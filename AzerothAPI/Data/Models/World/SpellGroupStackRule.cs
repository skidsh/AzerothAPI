using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class SpellGroupStackRule
    {
        public uint GroupId { get; set; }
        public sbyte StackRule { get; set; }
        public string Description { get; set; } = null!;
    }
}
