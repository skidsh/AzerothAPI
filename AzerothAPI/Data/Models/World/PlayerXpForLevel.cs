using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class PlayerXpForLevel
    {
        public byte Level { get; set; }
        public uint Experience { get; set; }
    }
}
