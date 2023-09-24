using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10_practice
{
    public class Manager : Employee
    {
        public Manager(string name, int salary, bool is_success) :base(name, salary, is_success)
        {
            
        }

        public void Get_promotion(Employee e)
        {
            e.Salary +=100;
            
        }

        public void Get_minus_promotion( Employee e)
        {
            e.Salary -= 50;



        }

    }
}
