using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm3_OOP.Poly
{
    internal class TaypB : TaypA
    {
        public int B {  get; set; }

        public TaypB(int a , int b) : base(a)
        {

            B = b;
        }




        public new void MyFun01()
        {
            Console.WriteLine("i am Base [Child]");
        }



        public override void MyFun02() {
            Console.WriteLine($"taypeB : A = {A} , B = {B}");
        }

    }
}
