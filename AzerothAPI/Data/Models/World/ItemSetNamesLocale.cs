using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class ItemSetNamesLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; } = null!;
        public string? Name { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
