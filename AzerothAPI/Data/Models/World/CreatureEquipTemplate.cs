﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class CreatureEquipTemplate
    {
        public uint CreatureId { get; set; }
        public byte Id { get; set; }
        public uint ItemId1 { get; set; }
        public uint ItemId2 { get; set; }
        public uint ItemId3 { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
