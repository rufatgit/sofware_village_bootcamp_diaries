using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10_practice
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public bool Is_success {  get; set; }

        public Employee(string name, int salary, bool is_success)
        {
            Name = name;
            Salary=salary;
            Is_success = is_success;
        }


    }
}
