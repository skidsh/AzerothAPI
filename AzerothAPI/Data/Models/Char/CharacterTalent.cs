using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class CharacterTalent
    {
        public uint Guid { get; set; }
        public uint Spell { get; set; }
        public byte SpecMask { get; set; }
    }
}
