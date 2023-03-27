using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class QuestRequestItem
    {
        public uint Id { get; set; }
        public ushort EmoteOnComplete { get; set; }
        public ushort EmoteOnIncomplete { get; set; }
        public string? CompletionText { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
