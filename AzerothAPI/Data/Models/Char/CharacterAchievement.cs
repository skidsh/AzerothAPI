using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class CharacterAchievement
    {
        public uint Guid { get; set; }
        public ushort Achievement { get; set; }
        public uint Date { get; set; }
    }
}
