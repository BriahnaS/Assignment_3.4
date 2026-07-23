using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3._4._1.Models
{
    internal abstract class Beverage
    {
        public bool IsIced { get; set; }
        public int AddedTbspSugar { get; set; }
        public int AddedTbspCreamer { get; set; }
        public double? Price { get; set; }

    }
}
