﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Player System
    /// </summary>
    public partial class CharacterSocial
    {
        /// <summary>
        /// Character Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Friend Global Unique Identifier
        /// </summary>
        public uint Friend { get; set; }
        /// <summary>
        /// Friend Flags
        /// </summary>
        public byte Flags { get; set; }
        /// <summary>
        /// Friend Note
        /// </summary>
        public string Note { get; set; } = null!;
    }
}
