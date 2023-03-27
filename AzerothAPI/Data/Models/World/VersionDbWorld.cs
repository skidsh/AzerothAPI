using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    /// <summary>
    /// Last applied sql update to DB
    /// </summary>
    public partial class VersionDbWorld
    {
        public VersionDbWorld()
        {
            InverseRequiredRevNavigation = new HashSet<VersionDbWorld>();
        }

        public string SqlRev { get; set; } = null!;
        public string? RequiredRev { get; set; }
        public string? Date { get; set; }
        public ulong? _2021112802 { get; set; }

        public virtual VersionDbWorld? RequiredRevNavigation { get; set; }
        public virtual ICollection<VersionDbWorld> InverseRequiredRevNavigation { get; set; }
    }
}
