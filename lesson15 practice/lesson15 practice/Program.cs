namespace lesson15_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi", 50, 100000);
            Car bmw = new Car("bmw", 100, 200000);
            Car tesla = new Car("tesla", 150, 300000);
            Car volvo = new Car("volvo", 200, 400000);


            Gallery gall=new Gallery();

            gall.Add_Car(audi);
            gall.Add_Car(bmw);
            gall.Add_Car(tesla);
            gall.Add_Car(volvo);


            gall.Sum_Car();

            gall.Get_Gallery_Show();

            gall.DeleteCar(2);
            Console.WriteLine("********************");
            gall.Get_Gallery_Show();

        }
    }
}