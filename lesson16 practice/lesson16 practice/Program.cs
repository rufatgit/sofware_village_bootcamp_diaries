namespace lesson16_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone iphone = new Phone("Iphone", 100, 5);
            Phone blackberry = new Phone("blackberry", 200, 10);
            Phone htc = new Phone("htc", 300, 15);
            Phone redmi = new Phone("redmi", 400, 20);


            Store store = new Store();

            store.AddPhone(iphone);
            store.AddPhone(blackberry);
            store.AddPhone(htc);
            store.AddPhone(redmi);

            store.ShowAllPhone();

            Console.WriteLine(store.Sell(2, 6));

            store.ShowAllPhone();
            Console.WriteLine("**********************");
            store.ShowPhoneForPrice(150,500);


            store.Remove(3);
            Console.WriteLine("**********************");
            store.ShowAllPhone();

        }
    }
}