using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Templates
    /// </summary>
    public partial class TemplateNpcAlliance
    {
        public string PlayerClass { get; set; } = null!;
        public string PlayerSpec { get; set; } = null!;
        public uint Pos { get; set; }
        public uint ItemEntry { get; set; }
        public uint Enchant { get; set; }
        public uint Socket1 { get; set; }
        public uint Socket2 { get; set; }
        public uint Socket3 { get; set; }
        public uint BonusEnchant { get; set; }
        public int? PrismaticEnchant { get; set; }
    }
}
