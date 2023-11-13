
//Call By Value 

//using System;
//namespace ConAppMethodsParameters

//{  public class Calc
//{
//  public void Increment( int num)
//{
//Console.WriteLine("In method Value of Num b4 Increment is: \t" + num);
//num += 5;
// Console.WriteLine("In Method Value of Num after Increment is: \t" + num);
//  }
//}
//internal class Program
//{
//static void Main(string[] args)
//{
//int myNum = 10;
//Console.WriteLine("In Main Value of myNum b4 Method Call is: \t" + myNum);
//Calc calc = new Calc();
//calc.Increment(myNum);
//Console.WriteLine("In Mian Value of myNum after Method Call is: \t" + myNum);
//Console.ReadKey();

//Call By Reference

//using System;
//namespace ConAppMethodsParameters

//{
//      public void Increment(ref int num)
//    {
//  Console.WriteLine("In method Value of Num b4 Increment is: \t" + num);
//num += 5;
//Console.WriteLine("In Method Value of Num after Increment is: \t" + num);
//}
//}
//internal class Program
//{
//  static void Main(string[] args)
//{
//  int myNum = 10;
//Console.WriteLine("In Main Value of myNum b4 Method Call is: \t" + myNum);
//Calc calc = new Calc();
//calc.Increment(ref myNum);
//Console.WriteLine("In Mian Value of myNum after Method Call is: \t" + myNum);
//Console.ReadKey();
//}
//}

//using System;

//public class SalaryCalc
//{
//  public void BonousCalc(double salary, out double bonous)
//{
//  bonous = salary * 0.20;
//}
//public class MainClass
//{
//  public static void Main()
// {
//   double salary;
// Console.WriteLine("Enter salary");
//salary = double.Parse(Console.ReadLine());
//SalaryCalc calc = new SalaryCalc();
//calc.BonousCalc(salary, out  double bonous);
//Console.WriteLine("Salary is: \t "+salary +"\nBonous is: \t "+bonous);
//Console.ReadKey();

//}
//}
//}

//Param Example
using ExampleParams;
using System;
namespace ExampleParams
{

    public class Calc
    {
        public void Add(params double[] numbers)
        {
            double total = 0;
            foreach (double number in numbers)
            {
                total += number;
            }
            Console.WriteLine("Total :\t " + total);
        }
    }
}
public class MainClass
{
    public static void Main()
    {
        Calc calc = new Calc();
        calc.Add(12, 34.5);
        calc.Add(1, 2, 4.5, 56.6, 45);
        calc.Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        Console.ReadKey();
    }
}

    


    




    

        

