using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Auth
{
    public partial class AccountInformation
    {
        public uint Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public uint Coins { get; set; }
        public uint Points { get; set; }
    }
}
