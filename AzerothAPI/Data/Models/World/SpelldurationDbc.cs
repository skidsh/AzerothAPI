﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class SpelldurationDbc
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public int DurationPerLevel { get; set; }
        public int MaxDuration { get; set; }
    }
}
