using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    /// <summary>
    /// Trigger System
    /// </summary>
    public partial class AreatriggerInvolvedrelation
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
