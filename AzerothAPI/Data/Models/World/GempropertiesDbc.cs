using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class GempropertiesDbc
    {
        public int Id { get; set; }
        public int EnchantId { get; set; }
        public int MaxcountInv { get; set; }
        public int MaxcountItem { get; set; }
        public int Type { get; set; }
    }
}
