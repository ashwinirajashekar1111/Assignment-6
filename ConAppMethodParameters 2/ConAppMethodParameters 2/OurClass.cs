using System;
namespace ConAppMethodParameters_2
{
    public class OurClass
    {

        public void Display(string fname, string lname)
        {
            Console.WriteLine
            ("Welcome Mr.\\Ms. "+fname + " " + lname);
        }
        public void Add(string fname, string lname)
        {
            Console.WriteLine
            ("Welcome Mr.\\Ms. "+fname + " " + lname);
        }
        public void Add(int num1,int num2=10, int num3=20, int num4=40)
        {
            int result = num1 + num2 + num3 + num4;
            Console.WriteLine
            ($"Result after Adding{num1},{num2},{num3},{num4} " +
            $"= \t {result}");
        }
    }
}
