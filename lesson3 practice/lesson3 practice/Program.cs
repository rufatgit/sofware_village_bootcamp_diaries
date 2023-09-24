


public class Program
{
    public static void Payment(double d)
    {
        double c = d;
        if (d < 100 && d >= 1)
        {
            c = d - (d * 5) / 100;
            Console.WriteLine("Plz pay " + c);
        }
        else if (100 <= d && d <= 1000)
        {
            c = d - (d * 8) / 100;
            Console.WriteLine("Plz pay " + c);

        }
        else if (d > 1000)
        {
            c = d - (d * 10) / 100;
            Console.WriteLine("Plz pay " + c);

        }
        else { Console.WriteLine("Customer didnt buy anything"); }


    }

    public static void Cal(double a, double b, int choice)
    {
        switch (choice)
        {
            case 0:
                Console.WriteLine(a+b);
                break;
            case 1:
                Console.WriteLine(a-b);
                break;
            case 2:
                Console.WriteLine(a * b);
                break;
            case 3:
                Console.WriteLine(a / b);
                break;
            default:
                Console.WriteLine("Wrong Input");
                break;
        }
    }


    public static void Main(string[] args)
    {
        Console.WriteLine("Enter customer's payment: ");
        double input = double.Parse(Console.ReadLine());
        Payment(input);

        double a = 15, b = 5;
        Console.WriteLine($@"Choose operation:
Addition - 0
Substruction - 1
Multiplication - 2
Division - 3 :");
        int cho = int.Parse(Console.ReadLine());

        Cal(a, b, cho);

    }
}