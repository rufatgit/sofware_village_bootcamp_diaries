

public class Program
{

    public static float Rec(float a, float b)
    {
        return a * b;
    }


    public static void Main(string[] args)
    {
        float a = 4.5f;
        float b = 3.5f;
        Console.WriteLine(Rec(a, b));

        int c = 56;
        int d = 453;

        if (c % 2 == 0)
        {
            Console.WriteLine("56 is even");
        }
        else
        {
            Console.WriteLine("56 is odd");

        }

        if (d % 2 == 0)
        {
            Console.WriteLine("453 is even");
        }
        else
        {
            Console.WriteLine("453 is odd");

        }

        int[] num = new int[5] { 1, 2, 3, 4, 5 };

        int sum = 0;

        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];
        }

        Console.WriteLine("SUM: "+sum);

    }
}
