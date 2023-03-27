using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    /// <summary>
    /// SpellInfo custom attributes
    /// </summary>
    public partial class SpellCustomAttr
    {
        /// <summary>
        /// spell id
        /// </summary>
        public uint SpellId { get; set; }
        /// <summary>
        /// SpellCustomAttributes
        /// </summary>
        public uint Attributes { get; set; }
    }
}
