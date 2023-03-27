using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Last applied sql update to DB
    /// </summary>
    public partial class VersionDbCharacter
    {
        public VersionDbCharacter()
        {
            InverseRequiredRevNavigation = new HashSet<VersionDbCharacter>();
        }

        public string SqlRev { get; set; } = null!;
        public string? RequiredRev { get; set; }
        public string? Date { get; set; }
        public ulong? _2021101400 { get; set; }

        public virtual VersionDbCharacter? RequiredRevNavigation { get; set; }
        public virtual ICollection<VersionDbCharacter> InverseRequiredRevNavigation { get; set; }
    }
}
