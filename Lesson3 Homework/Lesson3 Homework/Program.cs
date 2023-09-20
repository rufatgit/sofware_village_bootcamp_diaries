


public class Program
{
    static void Main(string[] args)
    {
        int age = 20;
        if (age > 18)
        {
            Console.WriteLine("Wlcome to the Course");
        }
        else
        {
            Console.WriteLine("You should be minimum 18 to join our course");
        }

        string[] arr = new string[6]
        {
           "string",
            "st",
            "asd",
            "alyf",
            "xcv",
            "hjg"
        };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }


        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a % 3 == 0)
        {
            Console.WriteLine(a + " number is divisible by 3");
        }
        else
        {
            Console.WriteLine(a + " number is not divisible by 3");

        }

        if (b % 3 == 0)
        {
            Console.WriteLine(b + " number is divisible by 3");
        }
        else
        {
            Console.WriteLine(b + " number is not divisible by 3");

        }

        int[] ar = { 4, 7, 9, 12, 14 };
        int biggest = ar[1];
        int smallest = ar[2];
        for (int i = 0; i < ar.Length; i++)
        {
            if (ar[i] > biggest)
            {
                biggest = ar[i];
            }

            if (ar[i] < smallest)
            {
                smallest = ar[i];
            }
        }

        Console.WriteLine("Biggest: " + biggest);
        Console.WriteLine("smallest: " + smallest);

        double[] average = { 2, 5, 6, 7, 8, 10 };
        Console.WriteLine("Average: " + average.Sum() / average.Length);

    }
}
