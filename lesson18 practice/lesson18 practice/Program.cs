namespace lesson18_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple a1 = new Apple();
            Apple a2 = new Apple();
            Apple a3 = new Apple();
            Pineapple p1 = new Pineapple();
            Pineapple p2 = new Pineapple();
            Orange o1 = new Orange();
            Orange o2 = new Orange();

            Fruit[] basket = new Fruit[3];
            basket[0] = new Apple
            {
                Price = 5,
                Type = "a1",
                VitaminA = 4,
                VitaminB = 3
            };

            basket[1] = new Pineapple
            {
                Price = 10,
                Type = "p1",
                VitaminE = 7,
                VitaminD = 8
            };

            basket[2] = new Orange
            {
                Price = 99,
                Type = "o1",
                VitaminC = 75,

            };



            foreach (Fruit f in basket)
            {
                f.Taste();
                Console.WriteLine($@"Price: {f.Price}
Type: {f.Type}");


                if (f is Apple apple)
                {
                    Console.WriteLine("Vitamin A amount: "+apple.VitaminA);
                    Console.WriteLine("Vitamin B amount: " + apple.VitaminB);
                }
                else if (f is Pineapple pineapple)
                {
                    Console.WriteLine("Vitamin E amount: " + pineapple.VitaminE);
                }
                else if(f is Orange orange)
                {
                    Console.WriteLine("Vitamin C amount: " + orange.VitaminC);
                }

                
            }




        }
    }
}