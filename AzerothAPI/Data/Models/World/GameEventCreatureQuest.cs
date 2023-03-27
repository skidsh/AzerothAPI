﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class GameEventCreatureQuest
    {
        /// <summary>
        /// Entry of the game event.
        /// </summary>
        public byte EventEntry { get; set; }
        public uint Id { get; set; }
        public uint Quest { get; set; }
    }
}
