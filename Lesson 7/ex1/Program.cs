

/*1.Ədəd və rəqəmlərdən ibarət arrayda neçə rəqəm olduğunu ekrana çap edin(Məs: { 1,77,6,144}
arrayında 2 rəqəm var)

2.Arraydaki təkrarlanan elemetləri ekrana çıxaran alqoritm qurun. Misal [1,2,3,2,5,3]=>output => 2,3
3.Kiçikdən böyüyə siralanmış array - i böyükdən kiçiyə sıralayan alqoritm.
4.Verilmish ededin bolenleri sayini tapan algorithm


1. Print the number of digits in an array of numbers (Example: In the array {1, 77, 6, 144}, there are 2 digits).

2. Create an algorithm to print the repeated elements in an array. Example: For [1, 2, 3, 2, 5, 3], the output should be 2, 3.

3. Create an algorithm to sort an array sorted from smallest to largest in descending order.

4. Algorithm to find the number of divisors of a given number. */

public class Program
{

    public static int[] Input_array(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());

        }


        return arr;
    }

    public static void Output_array(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }


    public static int Check(int[] arr)
    {
        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 10)
            {
                ++counter;
            }
        }

        return counter;
    }



    public static void Output_duplicates(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {


                if (arr[j] == arr[i])
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

    }


    public static int[] Bubble_sort(int[] arr, bool b)
    {
        if (b)
        {
            for (int i = 0; i < arr.Length * arr.Length; i++)
            {
                for (int j = 0; j + 1 < arr.Length; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < arr.Length * arr.Length; i++)
            {
                for (int j = 0; j + 1 < arr.Length; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }
        }

        return arr;

    }

    public static int Divisors_number(int input)
    {
        int counter = 0;

        for (int i = 1; i <= input; i++)
        {
            if (input%i==0)
            {
                Console.Write(i+" ");
                ++counter;
            }
        }
        return counter;
    }

    public static void Main(string[] args)
    {
        /* int[] arr = new int[10];
         arr = Input_array(arr);
         Console.WriteLine("Array consists of " + Check(arr) + " digits.");
 */

        /*int[] arr = new int[10];
        arr = Input_array(arr);
        Console.WriteLine("****************\nDuplicates:");
        Output_duplicates(arr);
*/


        /* int[] arr = new int[10];
         arr = Input_array(arr);
         Console.WriteLine("Ascending - 'y' or descending? - 'n' : ");
         char c=char.Parse(Console.ReadLine());
         bool b = false;
         if (c =='y')
         {
             b = true;
         }

         int[] ascending_arr= Bubble_sort(arr, b);
         Output_array(ascending_arr);
 */

        int input = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int result = Divisors_number(input);
        Console.WriteLine("\nNumber of divisors of inputted number: "+result);

    }
}
