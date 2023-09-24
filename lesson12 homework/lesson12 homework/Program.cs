namespace lesson12_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone iphone = new Phone(16, 3223, "Apple", "13 pro", 1000, 800, 0, 5);

            iphone.GetInfo();
            iphone.Sale(4);
            iphone.GetInfo();

            iphone.Pay(5);
            iphone.Call(15);
            iphone.GetInfo();


        }
    }
}




