using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class GameEventBattlegroundHoliday
    {
        /// <summary>
        /// Entry of the game event
        /// </summary>
        public byte EventEntry { get; set; }
        public uint Bgflag { get; set; }
    }
}
