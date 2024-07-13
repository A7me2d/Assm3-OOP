using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm3_OOP.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string FirstName { get; set; }
        public int Age { get; set; }

        public void GetEmp() {

            Console.WriteLine("Employees");
        }

        public virtual void GetEmpData()
        {
            Console.WriteLine($"Emp id {Id} , Name {Name} , Age {Age}");
        }

    }
}
