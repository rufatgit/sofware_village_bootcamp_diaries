using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson15_practice
{
    internal class Car
    {
        public int Id { get; set; }
        public static int Count { get; set; } = 0;
        public string Name { get; set; }
        public double Speed { get; set; }
        public double Price { get; set; }

        public Car(string name, double speed, double price)
        {
            Id = ++Count;
            Name = name;
            Speed = speed;
            Price = price;
        }


        public void Get_Info_Car()
        {
            Console.WriteLine($@"ID number: {Id}
Name: {Name}
Speed km/h: {Speed}
Price: {Price}");
        }




    }
}
