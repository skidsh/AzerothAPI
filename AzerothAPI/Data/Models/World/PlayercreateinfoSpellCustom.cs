﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class PlayercreateinfoSpellCustom
    {
        public uint Racemask { get; set; }
        public uint Classmask { get; set; }
        public uint Spell { get; set; }
        public string? Note { get; set; }
    }
}
