using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3._4._1.Models
{
    internal class Coffee : Beverage
    {
        public string BeanName {  get; set; }
        public string RoastType {  get; set; }
        public int EspressoShots { get; set; }
        public string Style { get; set; }
        public string? MilkType { get; set; }
        public bool ColdFoam { get; set; }

    }
}
