using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Group 
    {
        Student[] students;
        public string GroupName { get; set; }

        public Group( string groupName, Student[] st)
        {
            GroupName = groupName;
            students = st;  
        }


        public void GetAll()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} {student.Surname} {student.Age} {GroupName}");
            }
        }

        public void GetOnlineStudent()
        {
            foreach(Student student in students)
            {
                if (student.IsOnline)
                {
                    Console.WriteLine($"{student.Name} {student.Surname} {student.Age}");
                }
            }

        }

        public void GetOfflineStudent()
        {
            foreach (Student student in students)
            {
                if (!student.IsOnline)
                {
                    Console.WriteLine($"{student.Name} {student.Surname} {student.Age}");
                }
            }
        }
    }
}
