namespace lesson11_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2nd august homework
            Car audi = new Car(4, true, "Zwickau Factory", "Q4 e-tron", "white", 1000, 100000);
            Car porsche = new Car(4, false, "VW Factory", "Cayenne", "black", 500, 50000);


            Bicycle trek = new Bicycle("Mountain bike", "Waterloo Factory", "Trek Fuel EX 9.9 XX1 AXS", "blue", 5, 7);


           
            Vehicle[] vec = new Vehicle[]
            {
                audi, porsche, trek
            };

            foreach (Vehicle v in vec)
            {
                v.Get_Info();
                Console.WriteLine("******************************");
            }

        }
    }
}

