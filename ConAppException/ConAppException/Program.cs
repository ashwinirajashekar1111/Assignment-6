using System;

namespace ConAppException
{    public class InvalidAge:Exception
    {    public InvalidAge(string message):base(message)
        {
             
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            try {
                Console.WriteLine("Enter Age");
                age = int.Parse(Console.ReadLine());
                if(age<=0||age>=150)
                {
                    throw new InvalidAge("Age must be not negative or greater than 150");
                }
                else if(age>=18)
                {
                    Console.WriteLine("Eligible to castvote");
                }
                else
                {
                    Console.WriteLine("Not Eligible to caste vote");
                }
                Console.WriteLine("Age \t " + age);

            }
            catch (InvalidAge ex)
            {
                Console.WriteLine("Invalid Age Error!!!" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error !!"+ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program!!!");
            }
        }
    }
}
