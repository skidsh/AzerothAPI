﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Debug System
    /// </summary>
    public partial class Bugreport
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public uint Id { get; set; }
        public string Type { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
