using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12_homework
{
    internal class Product
    {
        private int Id { get; set; }
        private string Brandname { get; set; }
        private string Model { get; set; }
        private double Price { get; set; }
        private double Cost { get; set; }
        private double Income { get; set; }
        private int Count { get; set; }

        public Product(int id, string brandname, string model, double price, double cost, double income, int count)
        {
            Id = id;
            Brandname = brandname;
            Model = model;
            Price = price;
            Cost = cost;
            Income = income;
            Count = count;
        }



        public virtual void GetInfo()
        {
            Console.WriteLine($@"Product info.
ID: {Id}
Brandname: {Brandname}
Model: {Model}
Price: {Price}
Cost: {Cost}
Income: {Income}
Number of Product to be sold: {Count}
*********************");
        }


        public virtual void Sale(int num_product_sell)  //number_of_product_intended_to_sell
        {
            if (Count>0 && num_product_sell<=Count && num_product_sell>0)
            {
                Income =Income+((Price/2) * num_product_sell);  // actual income of product: Price/2
                Count = Count - num_product_sell;
            }
            else
            {
                Console.WriteLine("ERROR: No enough product to sell.");
            }



        }

    }
}
