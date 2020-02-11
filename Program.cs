using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApp1 {
    class MyClass
    {
        public void Method()
        {
            Console.Write("");
            try
            {
                int x = 0;
                int sum = 100 / x;
            }
            catch (DivideByZeroException e)
            {   
                throw;                                 
                Console.WriteLine(e.Message);
            }
        }
    }
    class MyClient
    {
        public static void Main()
        {
            MyClass mc = new MyClass();
            try
            {
                mc.Method();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught here");
            }
            Console.WriteLine("LAST STATEMENT");
            Console.ReadLine();
        }
    }
}
        /* public class Calculation
         {
             int sum = 0;
             int count = 0;
             float average;
             public void CalAverage()
             {
                 if (count == 0)
                     throw (new CountIsZeroException("Zero count in DoAverage"));
                 {
                     average = sum / count;
                     Console.WriteLine("Program executed successfully");
                 }
             }
         }

         public class CountIsZeroException : ApplicationException
         {
             public CountIsZeroException(string message) : base(message)
             {
             }
         }

         class Program
         {
             static void Main(string[] args)
             {
                 Calculation c = new Calculation();
                 try
                 {
                     c.CalAverage();
                 }
                 catch (CountIsZeroException e)
                 {
                     Console.WriteLine("CountIsZeroException : {0}", e);
                 }
                 Console.ReadLine();
             }
         }*/

        /*class MyProgram 
        {
            public static void Main(string[] args)
            {
                try
                {
                    int rand = 0;
                    if (rand == 0)
                    {
                        throw new Exception("Random = 0");
                        rand = 1;
                    }
                    if (rand == 1)
                    {
                        Console.WriteLine("Random = 1");
                        return;
                    }
                    Console.WriteLine("Random = 2");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception is Catched"+e.Message);
                }
                finally
                {
                    Console.WriteLine("Flow reaches Finally");
                }
                Console.ReadLine();
            }
        }*/

        //{
        //    public class Program
        //    {
        //        public static void Main()
        //        {
        //            try
        //            {
        //                Hello();
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }

        //            Console.ReadLine();
        //        }

        //        public static void Hello()
        //        {
        //            try
        //            {
        //                // This exception will be lost
        //                throw new Exception("Exception in TRY block");
        //            }
        //            finally
        //            {
        //                throw new Exception("Exception in FINALLY block");
        //            }
        //        }

    

        //public class TypeOfExample
        //{
        //    public static void Main(String[] args)
        //    {
        //        new Girafee().A();

//Object b = new Girafee();
//Console.WriteLine(b is Animal);
//Console.WriteLine(b.GetType() == typeof(Animal));
//Console.WriteLine(b is Girafee);
//Console.WriteLine(b.GetType() == typeof(Girafee));
//    Console.ReadLine();
//}
//  }

