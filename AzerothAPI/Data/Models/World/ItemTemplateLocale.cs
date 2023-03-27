using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class ItemTemplateLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; } = null!;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
