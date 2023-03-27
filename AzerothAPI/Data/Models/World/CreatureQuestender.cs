using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    /// <summary>
    /// Creature System
    /// </summary>
    public partial class CreatureQuestender
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// Quest Identifier
        /// </summary>
        public uint Quest { get; set; }
    }
}
