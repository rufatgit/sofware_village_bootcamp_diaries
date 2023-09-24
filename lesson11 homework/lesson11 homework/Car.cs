using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lesson11_homework
{
    internal class Car : Vehicle
    {

        public int Door_Count { get; set; }
        public bool Is_Electric { get; set; }
        public Car(int door_count, bool iselectric, string factory_Name, string model, string color, double driveTime, double drive_Distance)
        : base(factory_Name, model, color, driveTime, drive_Distance)
        {
            Door_Count = door_count;
            Is_Electric = iselectric;
        }

        public override void Get_Info()
        {
            Console.WriteLine($@"Door Count: {Door_Count}
Electric? {Is_Electric}
Model: {Model}
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
