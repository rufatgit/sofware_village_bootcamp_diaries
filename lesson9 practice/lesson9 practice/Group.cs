using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_practice
{
    internal class Group
    {
        public string Name_Group;
        public Student[] Students;

        public Group(string name_group, Student[] students)
        {
            Name_Group = name_group;
            Students = students;
        }

        public void Get_All()
        {
            Console.WriteLine("*************************\nALL STUDENTS:");
            foreach (var i in Students)
            {
                i.Show();
            }
        }

        public void Get_Online_Students()
        {
            Console.WriteLine("*************************\nONLINE STUDENTS:");

            foreach (var i in Students)
            {
                if (i.Isonline)
                {
                    i.Show();
                }
            }

        }

        public void Get_Offline_Students()
        {
            Console.WriteLine("*************************\nOFFLINE STUDENTS:");

            foreach (var i in Students)
            {
                if (!i.Isonline)
                {
                    i.Show();
                }
            }

        }


    }
}
