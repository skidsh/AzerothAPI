using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Auth
{
    /// <summary>
    /// Last applied sql update to DB
    /// </summary>
    public partial class VersionDbAuth
    {
        public VersionDbAuth()
        {
            InverseRequiredRevNavigation = new HashSet<VersionDbAuth>();
        }

        public string SqlRev { get; set; } = null!;
        public string? RequiredRev { get; set; }
        public string? Date { get; set; }
        public ulong? _2021101400 { get; set; }

        public virtual VersionDbAuth? RequiredRevNavigation { get; set; }
        public virtual ICollection<VersionDbAuth> InverseRequiredRevNavigation { get; set; }
    }
}
