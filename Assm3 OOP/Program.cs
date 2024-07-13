


using Assm3_OOP.Poly;

namespace Assm3_OOP

{
    internal class Program
    {

        #region OverLoading
        public static int Sum(int x , int y)
        {

        return x + y; 
        }
    
        public static int Sum(int x , int y , int z)
        {
            return x + y + z;
        }

        public static double Sum(int x, double y) { 
        return x + y;
        }
        public static double Sum(double x, int y) { 
        return x + y;
        }

        #endregion
        static void Main(string[] args)
        {






            #region Polymor phism (OverLoading)

            //int Result = Sum(1, 2);
            //Console.WriteLine(Result);

            //Result = Sum(2, 3 , 4);
            //Console.WriteLine(Result);

            //double Result02 = Sum(3.2, 4);
            //Console.WriteLine(Result);

            #endregion


            #region Polymorphism [Overriding]

            //TaypA typeA = new TaypA(1);

            //typeA.A = 10;

            //typeA.MyFun01();
            //typeA.MyFun02();

            //TaypB taypB = new TaypB(1, 2);
            //taypB.A = 10;
            //taypB.B = 20;
            //taypB.MyFun01();
            //taypB.MyFun02();



            #endregion 


            #region Binding

            //TaypA refBase;

            //refBase = new TaypB(1, 2);

            //refBase.A = 10;

            //refBase.MyFun01();
            //refBase.MyFun02();

            


            #endregion


            #region

            #endregion


            #region

            #endregion


            #region

            #endregion


        }
    }
}
