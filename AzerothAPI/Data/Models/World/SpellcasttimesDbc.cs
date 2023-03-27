using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class SpellcasttimesDbc
    {
        public int Id { get; set; }
        public int Base { get; set; }
        public int PerLevel { get; set; }
        public int Minimum { get; set; }
    }
}
