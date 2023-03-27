using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class TaxipathDbc
    {
        public int Id { get; set; }
        public int FromTaxiNode { get; set; }
        public int ToTaxiNode { get; set; }
        public int Cost { get; set; }
    }
}
