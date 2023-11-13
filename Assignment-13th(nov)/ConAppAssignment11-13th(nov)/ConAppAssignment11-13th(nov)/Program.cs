using System;

namespace ConAppAssignment11_13th_nov_
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Choose Employee Type:");
                Console.WriteLine("1. HR");
                Console.WriteLine("2. Admin");
                Console.WriteLine("3. Software Developer");

                int employeeType = int.Parse(Console.ReadLine());

                switch (employeeType)
                {
                    case 1:
                        Console.WriteLine("Enter working hours:");
                        int hrWorkingHours = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number of working days:");
                        int hrWorkingDays = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Monthly salary for HR: {CalculateSalary(hrWorkingHours, hrWorkingDays)}");
                        break;

                    case 2:
                        Console.WriteLine("Enter working hours:");
                        int adminWorkingHours = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number of working days:");
                        int adminWorkingDays = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter project handles:");
                        int adminProjectHandles = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Monthly salary for Admin: {CalculateSalary(adminWorkingHours, adminWorkingDays, projectHandles: adminProjectHandles)}");
                        break;

                    case 3:
                        Console.WriteLine("Enter working hours:");
                        int devWorkingHours = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number of working days:");
                        int devWorkingDays = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter project handles:");
                        int devProjectHandles = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter extras:");
                        int devExtras = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Monthly salary for Software Developer: {CalculateSalary(devWorkingHours, devWorkingDays, devProjectHandles, devExtras)}");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

            static int CalculateSalary(int wHour, int nWDays, int projectHandles = 0, int extras = 0)
            {
                return wHour * nWDays * 100 + projectHandles * 3000 + extras * 2000;
            }
        }
    }
    

