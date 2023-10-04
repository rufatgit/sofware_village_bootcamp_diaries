using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17_practice
{
    public class Gallery
    {

        Car[] Cars = new Car[0];

        public void GetGalleryCarShow()
        {
            foreach (Car c in Cars)
            {
                c.GetinfoCar();


            }
        }

        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;


        }

        public void SumCar()
        {
            double sum = 0;

            for (int i = 0; i < Cars.Length; i++)
            {
                sum = sum + Cars[i].Price;
            }

            Console.WriteLine("Sum of price of the cars in Gallery: " + sum);
        }

        public void DeleteCar(int id)
        {
            Car[] new_cars = new Car[0];

            foreach (Car c in Cars)
            {
                if (c.Id != id)
                {
                    Array.Resize(ref new_cars, new_cars.Length + 1);
                    new_cars[new_cars.Length - 1] = c;

                }
            }

            Cars= new_cars;



        }

        public void ShowCarForSpeed(double min, double max)
        {
            Console.WriteLine($"Cars within given ranges({min}, {max}): ");
            foreach (Car c in Cars)
            {
                if(c.Speed>=min && c.Speed<=max)
                {
                    Console.WriteLine(c.Name);
                }
            }



        }



    }
}
