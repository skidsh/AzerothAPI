﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class CreatureQuestitem
    {
        public uint CreatureEntry { get; set; }
        public uint Idx { get; set; }
        public uint ItemId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
