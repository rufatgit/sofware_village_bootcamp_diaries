using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18_practice
{
    public class Pineapple : Fruit
    {
        public int VitaminE;
        public int VitaminD;

        public override void Taste()
        {
            Console.WriteLine("Taste: Penetrating the tongue taste");
        }



    }
}
