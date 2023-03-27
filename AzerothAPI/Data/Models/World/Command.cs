using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    /// <summary>
    /// Chat System
    /// </summary>
    public partial class Command
    {
        public string Name { get; set; } = null!;
        public byte Security { get; set; }
        public string? Help { get; set; }
    }
}
