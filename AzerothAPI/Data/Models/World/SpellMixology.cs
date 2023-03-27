using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class SpellMixology
    {
        public uint Entry { get; set; }
        /// <summary>
        /// bonus multiplier
        /// </summary>
        public float PctMod { get; set; }
    }
}
