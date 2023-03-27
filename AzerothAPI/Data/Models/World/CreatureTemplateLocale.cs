using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class CreatureTemplateLocale
    {
        public uint Entry { get; set; }
        public string Locale { get; set; } = null!;
        public string? Name { get; set; }
        public string? Title { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
