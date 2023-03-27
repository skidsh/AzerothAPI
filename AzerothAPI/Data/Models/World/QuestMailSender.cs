using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class QuestMailSender
    {
        public uint QuestId { get; set; }
        public uint RewardMailSenderEntry { get; set; }
    }
}
