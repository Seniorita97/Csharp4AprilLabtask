using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Student : Person
    {
       
        public bool IsOnline { get; set; }


        public Student(string name, string surname, int age, bool isOnline) : base(name, surname, age) 
        {
            IsOnline = isOnline;
        }
    }
}
