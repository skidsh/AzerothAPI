﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    /// <summary>
    /// Loot System
    /// </summary>
    public partial class ReferenceLootTemplate
    {
        public uint Entry { get; set; }
        public uint Item { get; set; }
        public int Reference { get; set; }
        public float Chance { get; set; }
        public sbyte QuestRequired { get; set; }
        public ushort LootMode { get; set; }
        public byte GroupId { get; set; }
        public byte MinCount { get; set; }
        public byte MaxCount { get; set; }
        public string? Comment { get; set; }
    }
}
