using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class PoolQuest
    {
        public uint Entry { get; set; }
        public uint PoolEntry { get; set; }
        public string? Description { get; set; }
    }
}
