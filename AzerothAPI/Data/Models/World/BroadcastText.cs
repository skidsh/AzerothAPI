using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class BroadcastText
    {
        public uint Id { get; set; }
        public uint Language { get; set; }
        public string? MaleText { get; set; }
        public string? FemaleText { get; set; }
        public uint EmoteId0 { get; set; }
        public uint EmoteId1 { get; set; }
        public uint EmoteId2 { get; set; }
        public uint EmoteDelay0 { get; set; }
        public uint EmoteDelay1 { get; set; }
        public uint EmoteDelay2 { get; set; }
        public uint SoundId { get; set; }
        public uint Unk1 { get; set; }
        public uint Unk2 { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
