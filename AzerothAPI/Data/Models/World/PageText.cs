using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    /// <summary>
    /// Item System
    /// </summary>
    public partial class PageText
    {
        public uint Id { get; set; }
        public string Text { get; set; } = null!;
        public uint NextPageId { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
