

using lesson9_practice;

public class Program
{
   




    public static void Main(string[] args)
    {
        Student stu1 = new Student(true, "Rufat", "Valiyev", 20);
        Student stu2 = new Student(false, "Alex", "Bach", 25);
        Student[] arr=new Student[] { stu1, stu2 };

        Group agroup = new Group("A Group", arr);

        agroup.Get_All();
        agroup.Get_Online_Students();
        agroup.Get_Offline_Students();

    }



}

