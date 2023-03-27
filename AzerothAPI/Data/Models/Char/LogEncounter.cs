using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class LogEncounter
    {
        public DateTime Time { get; set; }
        public ushort Map { get; set; }
        public byte Difficulty { get; set; }
        public byte CreditType { get; set; }
        public uint CreditEntry { get; set; }
        public string PlayersInfo { get; set; } = null!;
    }
}
