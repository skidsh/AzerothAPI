using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class Instance
    {
        public uint Id { get; set; }
        public ushort Map { get; set; }
        public uint Resettime { get; set; }
        public byte Difficulty { get; set; }
        public uint CompletedEncounters { get; set; }
        public string Data { get; set; } = null!;
    }
}
