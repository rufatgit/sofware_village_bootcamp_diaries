using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14_practice
{
    internal class Group
    {
        public int Group_Id { get; set; }
        public string Group_Name { get; set; }
        public Student[] Students = new Student[0];


        public Group(int id, string name)
        {
            Group_Id = id;
            Group_Name = name;
        }

        public void Get_Group_Info()
        {
            Console.WriteLine($@"Group Info:
ID: {Group_Id}
Name: {Group_Name}
Number of Students: {Students.Length}");
        }

        public void Show_Students()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine( student.GetInfo());
            }

        }


        public string Get_Student(int id)
        {
            foreach(Student student in Students)
            {
                if (student.Id == id)
                {
                    Console.WriteLine(student.GetInfo());
                }
            }

            return null;
        }

        public void Add_Student(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length-1] = student;
        }

        public void Search(string value)
        {
            foreach (var student in Students)
            {
                if(student.Name.Contains(value) || student.Surname.Contains(value))
                {
                    var result = student.GetInfo();
                    Console.WriteLine(result);
                }
            }
        }

    }
}
