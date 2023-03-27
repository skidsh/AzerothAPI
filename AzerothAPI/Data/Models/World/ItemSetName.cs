using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class ItemSetName
    {
        public uint Entry { get; set; }
        public string Name { get; set; } = null!;
        public byte InventoryType { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
