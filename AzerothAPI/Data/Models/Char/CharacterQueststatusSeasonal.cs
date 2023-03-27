using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Player System
    /// </summary>
    public partial class CharacterQueststatusSeasonal
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Quest Identifier
        /// </summary>
        public uint Quest { get; set; }
        /// <summary>
        /// Event Identifier
        /// </summary>
        public uint Event { get; set; }
    }
}
