using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson15_practice
{
    internal class Gallery
    {

        public string Name { get; set; }
        public Car[] Cars= new Car[0];


        public void Add_Car(Car car)
        {
            Array.Resize(ref Cars, Cars.Length+1);
            Cars[Cars.Length-1]= car;
        }

        public void Get_Gallery_Show()
        {
            foreach(Car car in Cars)
            {
                car.Get_Info_Car();
            }
        }


        public void Sum_Car()
        {
            double sum = 0;

            foreach(Car car in Cars)
            {
                sum += car.Price;
            }
            Console.WriteLine($"Total price of the Cars in Gallery: {sum}");
        }

        public void DeleteCar(int id)
        {
            Car[] temp_car = new Car[0];

            foreach(Car car in Cars)
            {
                if(car.Id != id)
                {
                    Array.Resize(ref temp_car, temp_car.Length + 1);
                    temp_car[temp_car.Length - 1] = car;
                }
            }

            Cars= temp_car;

        }



    }
}
