namespace lesson5_practice
{
    internal class Program
    {


        public static void Area(double a, double b)
        {
            Console.WriteLine("Area : " + (a * b));

        }

        public static void Area_parallelepiped(double l, double w, double h)
        {
            Console.WriteLine("Area of parallelepiped: " + 2 * (l * w + l * h + w * h));
        }

        public static void Area_circle_triangle(double a, double b, double c)
        {
            double sp= (a + b + c) / 2;  //semi_perimeter
            double at = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));//area_of_triangle
            double radius = at / sp;
            double area_of_inscribed_circle = radius * sp;
            Console.WriteLine("Area of inscribed circle in triangle: "+area_of_inscribed_circle);



        }



        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and width of rectangle: ");
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            Area(width, length);

            Console.WriteLine("Enter length, width and height of rectangle, respectively: ");
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Area_parallelepiped(l, w, h);


            double pi = 3.14;
            Console.WriteLine("Enter sides of triangle: ");
            double a=double.Parse(Console.ReadLine());
            double b=double.Parse(Console.ReadLine());
            double c=double.Parse(Console.ReadLine());
            Area_circle_triangle(a,b,c);




        }
    }
}