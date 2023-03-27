using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Auth
{
    public partial class Vote
    {
        public long Id { get; set; }
        public string Ip { get; set; } = null!;
        public string? VoteSite { get; set; }
        public long? Accountid { get; set; }
        public DateTime? Votedate { get; set; }
        public int Done { get; set; }
    }
}
