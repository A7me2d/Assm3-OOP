using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm3_OOP.Poly
{
    internal class TypeE : TypeD

    {
        public int E {  get; set; }

        public TypeE(int a, int b, int c, int d , int e) : base(a ,b , c, d)
        {

            E = e;
        }

        public override void MyFun02()
        {

            Console.WriteLine($"TypeE a = {A} , b {B} , c {C} , D {D} , E {E}");
        }



    }
}
