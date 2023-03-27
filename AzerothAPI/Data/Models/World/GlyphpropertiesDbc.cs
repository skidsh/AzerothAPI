using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class GlyphpropertiesDbc
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public int GlyphSlotFlags { get; set; }
        public int SpellIconId { get; set; }
    }
}
