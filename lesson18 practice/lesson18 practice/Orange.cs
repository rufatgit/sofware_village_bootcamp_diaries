﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18_practice
{
    public class Orange :Fruit
    {
        public int VitaminC;


        public override void Taste()
        {
            Console.WriteLine("Taste: Sour");
        }


    }
}
