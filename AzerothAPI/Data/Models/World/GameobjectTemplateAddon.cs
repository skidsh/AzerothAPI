﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class GameobjectTemplateAddon
    {
        public uint Entry { get; set; }
        public ushort Faction { get; set; }
        public uint Flags { get; set; }
        public uint Mingold { get; set; }
        public uint Maxgold { get; set; }
    }
}
