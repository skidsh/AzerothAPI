﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    public partial class LogMoney
    {
        public uint SenderAcc { get; set; }
        public uint SenderGuid { get; set; }
        public string SenderName { get; set; } = null!;
        public string SenderIp { get; set; } = null!;
        public uint ReceiverAcc { get; set; }
        public string ReceiverName { get; set; } = null!;
        public ulong Money { get; set; }
        public string Topic { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
