using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class PlayercreateinfoSkill
    {
        public uint RaceMask { get; set; }
        public uint ClassMask { get; set; }
        public ushort Skill { get; set; }
        public ushort Rank { get; set; }
        public string? Comment { get; set; }
    }
}
