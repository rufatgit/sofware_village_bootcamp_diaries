using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson13_practice
{
    internal class Student : IAcademy
    {
        public static int Count { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }


        public Student(string name, string surname)
        {
            ++Count;
            Id = Count;
            Name = name;
            Surname = surname;
            GenerateEmail();
        }

        public void GenerateEmail()
        {
            string email = Name + "." + Surname + Id + "@edu.az";
            CodeEmail = email;
        }


        public void ShowStudent()
        {
            Console.WriteLine($@"Fullname: {Name} {Surname}
Id: {Id}
Email: {CodeEmail}");

        }




    }
}
