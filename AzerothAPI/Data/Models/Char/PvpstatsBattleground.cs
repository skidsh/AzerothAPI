﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class PvpstatsBattleground
    {
        public ulong Id { get; set; }
        public sbyte WinnerFaction { get; set; }
        public byte BracketId { get; set; }
        public byte Type { get; set; }
        public DateTime Date { get; set; }
    }
}
