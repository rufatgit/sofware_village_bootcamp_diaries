namespace lesson19_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListInt intt = new ListInt();
            intt.Add(1);
            intt.Add(2);
            intt.Add(3);


            intt.AddRange(new int[2] { 5, 6 });

            for (int i = 0; i <intt.Length; i++)
            {
                Console.WriteLine(intt[i]);
            }








        }
    }
}