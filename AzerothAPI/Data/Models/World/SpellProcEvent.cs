using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class SpellProcEvent
    {
        public int Entry { get; set; }
        public sbyte SchoolMask { get; set; }
        public ushort SpellFamilyName { get; set; }
        public uint SpellFamilyMask0 { get; set; }
        public uint SpellFamilyMask1 { get; set; }
        public uint SpellFamilyMask2 { get; set; }
        public uint ProcFlags { get; set; }
        public uint ProcEx { get; set; }
        public float PpmRate { get; set; }
        public float CustomChance { get; set; }
        public uint Cooldown { get; set; }
    }
}
