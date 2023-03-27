using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Player System
    /// </summary>
    public partial class CharacterEntryPoint
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        public float JoinX { get; set; }
        public float JoinY { get; set; }
        public float JoinZ { get; set; }
        public float JoinO { get; set; }
        /// <summary>
        /// Map Identifier
        /// </summary>
        public uint JoinMapId { get; set; }
        public string? TaxiPath { get; set; }
        public uint MountSpell { get; set; }
    }
}
