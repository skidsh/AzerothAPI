using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class CharacterArenaStat
    {
        public uint Guid { get; set; }
        public byte Slot { get; set; }
        public ushort MatchMakerRating { get; set; }
        public short MaxMmr { get; set; }
    }
}
