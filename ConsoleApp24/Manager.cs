using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp24
{
    internal class Manager : Employee
    {
        public Manager(string name, bool isSuccessful, int salary) : base(name, isSuccessful, salary)
        {
        }
        public Manager()
        {
            
        }



        public void GetPromotion(Employee emp)
        {
             emp.Salary += 100;
           
        }

        public void GetMinusPromotion(Employee emp)
        {
           emp.Salary -= 50;
            
        }
    }
}
