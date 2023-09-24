using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10_practice
{
    public class Assistant : Employee
    {
        public Manager man=new Manager("Kale", 3000, true);

        public Assistant(string name, int salary, bool is_success) :base(name, salary, is_success)
        {
            
        }


        public void Get_feedback(Employee e)
        {
            if (e.Is_success)
            {
                man.Get_promotion(e);
                Console.WriteLine("Manager salary: "+e.Salary);
            }
            else
            {
                man.Get_minus_promotion(e);
                Console.WriteLine("Manager salary: " + e.Salary);

            }
        }







    }
}
