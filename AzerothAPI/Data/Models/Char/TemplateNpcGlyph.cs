using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Templates
    /// </summary>
    public partial class TemplateNpcGlyph
    {
        public string PlayerClass { get; set; } = null!;
        public string PlayerSpec { get; set; } = null!;
        public byte Slot { get; set; }
        public ushort Glyph { get; set; }
    }
}
