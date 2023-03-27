﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Auth
{
    public partial class Log
    {
        public uint Time { get; set; }
        public uint Realm { get; set; }
        public string Type { get; set; } = null!;
        public byte Level { get; set; }
        public string? String { get; set; }
    }
}
