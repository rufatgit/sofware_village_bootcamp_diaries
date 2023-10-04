using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18_practice
{
    public class Apple : Fruit
    {
        public int VitaminA;
        public int VitaminB;



        public override void Taste()
        {
            Console.WriteLine("Taste: sweet");
        }



    }
}
