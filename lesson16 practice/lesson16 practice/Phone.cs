using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson16_practice
{
    internal class Phone
    {
        public int Id {  get; set; }
        public static int ID_Counter { get; set; } = 0;
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count_amount { get; set; }

        public Phone(string name, double price, int amount)
        {
            Id = ++ID_Counter;
            Name=name;
            Price = price;
            Count_amount = amount;
        }


        public void Show_Info()
        {
            Console.WriteLine($@"ID: {Id}
Name: {Name}
Price: {Price}
Amount: {Count_amount}");
        }


    }
}
