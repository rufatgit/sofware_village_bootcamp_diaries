using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lesson12_homework
{
    internal class Phone : Product
    {
        private int RAM { get; set; }
        private string Color { get; set; }
        private double Balance { get; set; }


        public Phone(int ram, string color, int id, string brandname, string model, double price, double cost, double income, int count) :
            base(id, brandname, model, price, cost, income, count)
        {
            RAM = ram;
            Color = color;
            Balance = 0;

        }

        public Phone(int ram, int id, string brandname, string model, double price, double cost, double income, int count) :
            base(id, brandname, model, price, cost, income, count)
        {

            RAM = ram;
            Color = "Black";
            Balance = 0;

        }

        public override void GetInfo()
        {
            Console.WriteLine($@"Ram: {RAM}
Color: {Color}
Balance: {Balance}");
            base.GetInfo();
        }

        public void Pay(double money)
        {
            if (money > 0)
            {
                Balance=+money;
            }
            else
            {
                Console.WriteLine("Enter positive amount to increase the balance.");
            }
        }

        public void Call(int seconds)
        {
            if (Balance-seconds*0.1>0)
            {
                Balance =Balance-seconds*0.1;
                Console.WriteLine($"Called. Duration of call: {seconds} seconds");
            }
            else
            {
                Console.WriteLine("Not enough balance to make a call.");
            }
        }



    }
}
