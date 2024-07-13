using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm3_OOP.Poly
{
    internal class TypeD : TypeC

    {

        public int D {  get; set; }

        public TypeD(int a, int b , int c , int d):base(a , b, c)
        {   
            D = d;
        }

        public new void MyFun01()
        {
            Console.WriteLine("I am Dervid [Child Grand Child]");

        }

        public new virtual void MyFun02()
        {

            Console.WriteLine($"TypeD a = {A} , b {B} , c {C} , D {D}");
        }
    }
}
