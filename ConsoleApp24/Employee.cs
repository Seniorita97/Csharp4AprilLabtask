using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Employee
    {
        private bool isSuccessful;

        public string Name { get; set; }
        public bool IsSuccessfull { get; set; }
        public int Salary { get; set; }


      

        public Employee(string name, bool isSuccessful, int salary)
        {
            Name = name;
            IsSuccessfull = isSuccessful;
            Salary = salary;
        }
        public Employee()
        {
            
        }
    }
}
