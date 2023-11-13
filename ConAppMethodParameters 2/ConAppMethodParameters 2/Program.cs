using System;
namespace ConAppMethodParameters_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string firstName, lastName;
            //Console.WriteLine( "Enter First Name");
            //firstName = Console.ReadLine(); 
            //Console.WriteLine("Enter Last Name"); 
            //lastName = Console.ReadLine();
            //OurClass obj = new OurClass();
            //Console.WriteLine("*** First Method Call ***");
            //obj.Display(firstName, lastName);
            //Console.WriteLine("*** Second Method Call ***");
            //obj.Display(lname:lastName,fname:firstName);
            //DateTime dateTime = new DateTime(day: 23, month: 10, year: 2022);
            //Console.WriteLine("Stored Date is: \t "+dateTime.ToLongDateString());
            //Console.WriteLine("Stored Date is: \t " + dateTime.ToShortDateString());

            //Example-Default parameters
            OurClass obj = new OurClass();
            obj.Add(10);
            obj.Add(1, 2);
            obj.Add(1, 2, 3);
            obj.Add(25, 25, 25, 5);

            Console.ReadKey();

        }
    }
}
