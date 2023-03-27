using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class SpellScriptName
    {
        public int SpellId { get; set; }
        public string ScriptName { get; set; } = null!;
    }
}
