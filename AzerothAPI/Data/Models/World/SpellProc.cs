using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class SpellProc
    {
        public int SpellId { get; set; }
        public sbyte SchoolMask { get; set; }
        public ushort SpellFamilyName { get; set; }
        public uint SpellFamilyMask0 { get; set; }
        public uint SpellFamilyMask1 { get; set; }
        public uint SpellFamilyMask2 { get; set; }
        public uint TypeMask { get; set; }
        public uint SpellTypeMask { get; set; }
        public int SpellPhaseMask { get; set; }
        public int HitMask { get; set; }
        public uint AttributesMask { get; set; }
        public float RatePerMinute { get; set; }
        public float Chance { get; set; }
        public float Cooldown { get; set; }
        public uint Charges { get; set; }
    }
}
