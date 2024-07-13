using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm3_OOP.Binding
{
    internal class PartTimeEmployee : Employee

    {

        public int CountOfHours { get; set; }

        public decimal Houers { get; set; }


        public new void GetEmpType()
        {
            Console.WriteLine("i am Parttime employee");
        }

        public virtual void GetEmpData()
        {
            Console.WriteLine($"Emp CountOfHours {CountOfHours} , Houers {Houers}");
        }

    }
}
