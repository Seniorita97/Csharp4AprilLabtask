using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Employee emp1 = new Employee("Aygun", true, 500);
            //Employee emp2 = new Employee("Ayna", false, 200);
            //Employee emp3 = new Employee("Ali", true, 700);

            //Assistant emp4 = new Assistant();

            //emp4.GetFeedBack(emp1);
            //Console.WriteLine(emp1.Salary);


            Student[] students = new Student[]
            {
                new Student("Ali", "Mammadov", 23, true),
                new Student("Vali", "Aliyev", 20, false),
                new Student("Alina", "Ahmadova", 27, true),
                
            };

            Group group = new Group("C#", students); 


            group.GetAll();
        }
    }
}
