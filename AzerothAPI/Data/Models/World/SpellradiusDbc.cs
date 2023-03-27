using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class SpellradiusDbc
    {
        public int Id { get; set; }
        public float Radius { get; set; }
        public float RadiusPerLevel { get; set; }
        public float RadiusMax { get; set; }
    }
}
