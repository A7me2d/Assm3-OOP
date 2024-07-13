using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm3_OOP.Poly
{
    internal class TaypA
    {
        public int A  { get; set; }

        public TaypA(int a)
        {
            A = a;
        }

        public void MyFun01()
        {
            Console.WriteLine("i am Base [Partent]");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"TaypeA : A = {A}");
        }
    }
}
