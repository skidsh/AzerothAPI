using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Auth
{
    public partial class AccountPassword
    {
        public uint Id { get; set; }
        public DateTime? PasswordChangedAt { get; set; }
        public DateTime? PasswordResetExpires { get; set; }
        public string? PasswordResetToken { get; set; }
    }
}
