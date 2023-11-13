using System;
namespace ConAppMethods
{
    public class OurClass
    {
        //void returntype no parameters
        //public void Display()
        //{
        //    Console.WriteLine("Welcome to Methods");
        //}
        //public static void Display()
        //{
        //    Console.WriteLine("Welcome to Static Method");
        //}
        //Example-3
        //Method with return type and parameters

        public double Add(double num1, double num2)
        {
            double result;
            result = num1 + num2;
            return result;
        }
        //Example -3
        //Method with void return type parameters

        public void Welcome(string fname, string lname)
        {
            Console.WriteLine("We Welcome you to Methods Mr.\\Ms. " + fname + " " + lname);
        }



    }
    
    
}
