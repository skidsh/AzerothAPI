using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class ChannelsBan
    {
        public uint ChannelId { get; set; }
        public uint PlayerGuid { get; set; }
        public uint BanTime { get; set; }
    }
}
