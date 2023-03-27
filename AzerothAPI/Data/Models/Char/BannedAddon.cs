using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class BannedAddon
    {
        public uint Id { get; set; }
        public string Name { get; set; } = null!;
        public string Version { get; set; } = null!;
        public DateTime Timestamp { get; set; }
    }
}
