﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    /// <summary>
    /// Spell Additinal Data
    /// </summary>
    public partial class SpellRequired
    {
        public int SpellId { get; set; }
        public int ReqSpell { get; set; }
    }
}
