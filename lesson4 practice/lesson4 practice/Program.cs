

public class Program
{
    public static int Max(int[] arr)
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }

        return max;
    }

    public static double Two(double a, double b)
    {
        if (a % 2 == 0 && b % 2 == 0)
        {
            return a + b;
        }
        else if (!(a % 2 == 0 && b %2==0))
        {
            return a * b;
        }
        else
        {
            return a / b;
        }

    }

    public static double Area(double pi, double r)
    {
        return pi * r * r;
    }

    static void Main(string[] args)
    {
        int[] arr = { 8, 3, 4, 11 };
        Console.WriteLine($@"Max value: {Max(arr)}");

        Console.WriteLine("Enter 2 values");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(Two(a,b));

        double pi = 3.14;
        Console.WriteLine("Enter radius: ");
        double r=double.Parse(Console.ReadLine());
        Console.WriteLine("Area of circle: "+Area(pi, r));

    }
}