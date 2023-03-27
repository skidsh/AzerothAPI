using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class GameobjectAddon
    {
        public uint Guid { get; set; }
        public byte InvisibilityType { get; set; }
        public uint InvisibilityValue { get; set; }
    }
}
