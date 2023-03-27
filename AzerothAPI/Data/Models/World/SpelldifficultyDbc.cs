using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class SpelldifficultyDbc
    {
        public int Id { get; set; }
        public int DifficultySpellId1 { get; set; }
        public int DifficultySpellId2 { get; set; }
        public int DifficultySpellId3 { get; set; }
        public uint DifficultySpellId4 { get; set; }
    }
}
