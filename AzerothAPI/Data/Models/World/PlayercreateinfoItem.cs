﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class PlayercreateinfoItem
    {
        public byte Race { get; set; }
        public byte Class { get; set; }
        public uint Itemid { get; set; }
        public int Amount { get; set; }
        public string? Note { get; set; }
    }
}
