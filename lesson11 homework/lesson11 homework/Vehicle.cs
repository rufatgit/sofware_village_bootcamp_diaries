using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11_homework
{
    internal class Vehicle
    {
        public string Factory_Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double DriveTime { get; set; }
        public double Drive_Distance { get; set; }
        

        public Vehicle(string factory_Name, string model, string color, double driveTime, double drive_Distance)
        {
            Factory_Name = factory_Name;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            Drive_Distance = drive_Distance;
        }

        public double Average_Speed()
        {
            double average_speed = Drive_Distance / DriveTime;
            return average_speed;
        }

        public virtual void Get_Info()
        {
            Console.WriteLine($@"Color: {Color}
Drive Time: {DriveTime}
Drive Distance: {Drive_Distance}
Average Speed: {Average_Speed()}");
        }

        public virtual void ToString()
        {
            Console.WriteLine($@"Factory Name: {Factory_Name}
Model: {Model}");
        }





    }
}
