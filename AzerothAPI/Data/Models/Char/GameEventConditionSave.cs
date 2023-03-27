using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class GameEventConditionSave
    {
        public byte EventEntry { get; set; }
        public uint ConditionId { get; set; }
        public float? Done { get; set; }
    }
}
