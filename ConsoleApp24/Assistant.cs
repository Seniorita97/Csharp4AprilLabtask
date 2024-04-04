using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Assistant : Employee
    {
        public Assistant(string name, bool isSuccessful, int salary) : base(name, isSuccessful, salary)
        {
        }
        public Assistant()
        {
            
        }

        public void GetFeedBack(Employee emp)
        {
            var manager = new Manager();
            if (!emp.IsSuccessfull)
            {
              manager.GetMinusPromotion(emp);
            }
            else
            {
                manager.GetPromotion(emp);

            }
        }
    }
}
