using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Templates
    /// </summary>
    public partial class TemplateNpcTalent
    {
        public string PlayerClass { get; set; } = null!;
        public string PlayerSpec { get; set; } = null!;
        public uint TalentId { get; set; }
    }
}
