﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Auth
{
    public partial class AccountAccess
    {
        public uint Id { get; set; }
        public byte Gmlevel { get; set; }
        public int RealmId { get; set; }
        public string? Comment { get; set; }
    }
}
