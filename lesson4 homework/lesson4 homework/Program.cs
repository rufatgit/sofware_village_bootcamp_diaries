

public class Program
{
    public static void Space(int a)
    {
        int[] dividents = new int[2];


        dividents[0] = a / 10;
        dividents[1] = a % 10;

        Console.WriteLine("*****");
        for (int i = 0; i < dividents.Length; i++)
        {
            Console.Write(dividents[i] + " ");
        }
        Console.WriteLine();
    }


    public static void Digits(int b)
    {
        int[] dividents = { 10,100,1000,10000,100000, 1000000, 10000000, 100000000};
        int counter=1;

        for (int i = 0; i < dividents.Length; i++)
        {
            if (b % dividents[i] != b)
            {
                ++counter;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Number of digits is " + counter);

    }

    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        Space(a);

        int b=int.Parse(Console.ReadLine());
        Digits(b);



    }
}