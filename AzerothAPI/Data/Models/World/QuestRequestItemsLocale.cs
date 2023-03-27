using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class QuestRequestItemsLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; } = null!;
        public string? CompletionText { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
