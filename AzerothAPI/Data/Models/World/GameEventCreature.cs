using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class GameEventCreature
    {
        /// <summary>
        /// Entry of the game event. Put negative entry to remove during event.
        /// </summary>
        public sbyte EventEntry { get; set; }
        public uint Guid { get; set; }
    }
}
