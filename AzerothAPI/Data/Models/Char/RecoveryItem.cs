using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class RecoveryItem
    {
        public uint Id { get; set; }
        public uint Guid { get; set; }
        public uint ItemEntry { get; set; }
        public uint Count { get; set; }
    }
}
