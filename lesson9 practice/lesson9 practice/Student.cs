using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_practice
{
    internal class Student : Person
    {
        public bool Isonline;

        public Student(bool isonline, string name, string surname, int age):base(name, surname, age) 
        {
            Isonline = isonline;

        }


        public void Show()
        {
            Console.WriteLine($@"Name: {Name}
Surname: {Surname}
Age: {Age}
IsOnline: {Isonline}");
        }

    }
}
