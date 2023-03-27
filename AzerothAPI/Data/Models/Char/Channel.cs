using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Channel System
    /// </summary>
    public partial class Channel
    {
        public uint ChannelId { get; set; }
        public string Name { get; set; } = null!;
        public uint Team { get; set; }
        public byte Announce { get; set; }
        public byte Ownership { get; set; }
        public string? Password { get; set; }
        public uint LastUsed { get; set; }
    }
}
