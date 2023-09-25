using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14_practice
{
    internal class Student
    {

        public static int Count { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            
            Id = ++Count;
            Name = name;
            Surname = surname;
        }

        public string GetInfo()
        {
            return $@"Name: {Name}
Surname: {Surname}";
        }



    }
}
