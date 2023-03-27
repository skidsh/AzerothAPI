﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Guild System
    /// </summary>
    public partial class GuildRank
    {
        public uint Guildid { get; set; }
        public byte Rid { get; set; }
        public string Rname { get; set; } = null!;
        public uint Rights { get; set; }
        public uint BankMoneyPerDay { get; set; }
    }
}
