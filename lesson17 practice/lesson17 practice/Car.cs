using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17_practice
{
    public class Car
    {
        public int Id { get; set; }
        public static int Count { get; set; } = 0;
        public string Name { get; set; }
        public double Speed { get; set; }
        public double Price { get; set; }

        public Car( string name, double speed, double price)
        {
            Id = ++Count;
            Name = name;
            Speed = speed;
            Price = price;
        }



        public void GetinfoCar()
        {
            Console.WriteLine($@"ID: {Id}
Name: {Name}
Speed: {Speed}
Price: {Price}");


        }
    }






}
