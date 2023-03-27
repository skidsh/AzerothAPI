using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class AccountInstanceTime
    {
        public uint AccountId { get; set; }
        public uint InstanceId { get; set; }
        public ulong ReleaseTime { get; set; }
    }
}
