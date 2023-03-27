using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class QuestTracker
    {
        public uint Id { get; set; }
        public uint CharacterGuid { get; set; }
        public DateTime QuestAcceptTime { get; set; }
        public DateTime? QuestCompleteTime { get; set; }
        public DateTime? QuestAbandonTime { get; set; }
        public sbyte CompletedByGm { get; set; }
        public string CoreHash { get; set; } = null!;
        public string CoreRevision { get; set; } = null!;
    }
}
