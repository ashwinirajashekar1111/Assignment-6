using System;
namespace ConAppMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OurClass obj = new OurClass();
            //obj.Display();
            //Console.ReadKey();
            //Static Method
            //OurClass.Display();
            //Example-3 , 4
            OurClass our = new OurClass();
            double res = our.Add(23.45, 12.55);
            Console.WriteLine
            ("Result after Addition is: " + res);
            our.Welcome("Sameer", "Gaur");
            Console.ReadKey();

                
        }
    }
}
