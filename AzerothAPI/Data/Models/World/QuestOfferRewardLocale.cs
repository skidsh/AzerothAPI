using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class QuestOfferRewardLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; } = null!;
        public string? RewardText { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
