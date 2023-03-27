using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class CharacterInstance
    {
        public uint Guid { get; set; }
        public uint Instance { get; set; }
        public byte Permanent { get; set; }
        public byte Extended { get; set; }
    }
}
