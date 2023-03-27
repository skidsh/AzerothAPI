using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class SummonpropertiesDbc
    {
        public int Id { get; set; }
        public int Control { get; set; }
        public int Faction { get; set; }
        public int Title { get; set; }
        public int Slot { get; set; }
        public int Flags { get; set; }
    }
}
