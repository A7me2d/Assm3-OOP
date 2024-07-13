


using Assm3_OOP.Binding;
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



        public static void ProcessEmployee(Employee employee)
        {
            employee.GetEmp();
            employee.GetEmpData();
        }  
        //public static void ProcessEmployee(PartTimeEmployee employee)
        //{
        //    employee.GetEmpType();
        //    employee.GetEmpData();
        //}

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


            #region not Binding

            //TaypB typeB = (TaypB) new TaypA(1);

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //object o = 2;
            //int x = (int)o;


            //TaypA taypA = new TaypB(1, 2);
            //TaypB taypB =(TaypB) taypA;


            //Console.WriteLine(taypA.A);
            //Console.WriteLine(taypB.B);

            //object o = "2";
            //int x = (int)0;

            //Console.WriteLine(x);

            #endregion


            #region Binding Ex01

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(1 , "Ahmed" , 25 , 2021);
            ProcessEmployee(fullTimeEmployee);

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Id = 20,
                Name = "AhmedTwo",
                Age = 20,
                Houers = 2.3M,
                CountOfHours = 20,
                
            };

            ProcessEmployee(partTimeEmployee);

            #endregion


            #region Binding Ex02

            //TaypA taypA = new TypeC(1, 2, 3);

            //taypA.A = 10;

            //taypA.MyFun01();
            //taypA.MyFun02();

            //TaypB taypB = new TypeC(1, 2, 3);
            //taypB.A = 10;
            //taypB.B = 20;

            //taypB.MyFun01();
            //taypB.MyFun02();


            //TaypA taypA = new TypeE ( 1,2,3,4,5 );
            //TaypB taypB = new TypeE ( 1,2,3,4,5 );
            //TypeC typeC = new TypeE ( 1,2,3,4,5 );

            //taypA.MyFun02();
            //taypB.MyFun02();
            //typeC.MyFun02();

            
            #endregion


        }
    }
}
