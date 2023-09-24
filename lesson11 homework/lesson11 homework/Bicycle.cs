using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11_homework
{
    internal class Bicycle :Vehicle
    {
        public string Type { get; set; }
        public Bicycle(string type, string factory_Name, string model, string color, double driveTime, double drive_Distance)
        : base(factory_Name, model, color, driveTime, drive_Distance)
        {
            Type = type;
        }

        public override void Get_Info()
        {
            Console.WriteLine($@"Type: {Type}
Color: {Color}
Drive Time: {DriveTime}
Drive Distance: {Drive_Distance}
Average Speed: {Average_Speed()}");
        }

        public override void ToString()
        {
            Console.WriteLine($@"Factory Name: {Factory_Name}
Model: {Model}");
        }



    }
}
