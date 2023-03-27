using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class PoolCreature
    {
        public uint Guid { get; set; }
        public uint PoolEntry { get; set; }
        public float Chance { get; set; }
        public string? Description { get; set; }
    }
}
