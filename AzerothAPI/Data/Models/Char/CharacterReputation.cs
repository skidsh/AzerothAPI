﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Player System
    /// </summary>
    public partial class CharacterReputation
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        public ushort Faction { get; set; }
        public int Standing { get; set; }
        public ushort Flags { get; set; }
    }
}
