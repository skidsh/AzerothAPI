﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class QuestPoiPoint
    {
        public uint QuestId { get; set; }
        public uint Idx1 { get; set; }
        public uint Idx2 { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
