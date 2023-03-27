using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    /// <summary>
    /// Spell System
    /// </summary>
    public partial class SpellGroup
    {
        public uint Id { get; set; }
        public uint SpellId { get; set; }
        public uint SpecialFlag { get; set; }
    }
}
