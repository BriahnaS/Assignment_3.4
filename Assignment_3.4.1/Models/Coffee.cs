using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3._4._1.Models
{
    internal class Coffee : Beverage
    {
        public BeanName BeanName { get; set; }
        public RoastType RoastType { get; set; }
        public int EspressoShots { get; set; }
        public string? Style { get; set; }
        public MilkType MilkType { get; set; }
        public bool ColdFoam { get; set; }

    }
}
