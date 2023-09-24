

using lesson_10_practice;

public class Program
{


	static void Main(string[] args)
	{
		Employee e = new Employee("Alex", 2000, true);
		Assistant a = new Assistant("Harry", 1500, false);
		a.Get_feedback(e);
		



	}


}