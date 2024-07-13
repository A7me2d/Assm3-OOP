using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm3_OOP.Binding
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public FullTimeEmployee(int id , string name , int age , decimal salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public new void GetEmpType()
        {
            Console.WriteLine("");
        }
    }
}
