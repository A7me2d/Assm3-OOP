using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm3_OOP.Poly
{
    internal class TypeC : TaypB

    {
        public int C {  get; set; }

        public TypeC(int a , int b , int c):base(a , b)
        {

        C = c;
        }   
    

        public new void MyFun01()
        {
            Console.WriteLine("I am Dervid [Grand Child]");

        }

        public override void MyFun02() { 
        
        Console.WriteLine($" a = {A} , b {B} , c {C}");
        }

    }
}
