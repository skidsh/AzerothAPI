using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class CurrencytypesDbc
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public int BitIndex { get; set; }
    }
}
