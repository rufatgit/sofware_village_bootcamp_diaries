namespace lesson14_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student a1 = new Student("Rufat","Valiyev");
            Student a2 = new Student("Alex","Osman");
            Student a3 = new Student("Aqil","Kate");


            Group b = new Group(1, "Group B");

            b.Add_Student(a1);
            b.Add_Student(a2);
            b.Add_Student(a3);

            b.Show_Students();
            b.Get_Group_Info();

            Console.WriteLine("************************");
            b.Search("Alex");
            b.Get_Student(3);
        }
    }
}