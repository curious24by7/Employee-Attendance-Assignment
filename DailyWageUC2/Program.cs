using System;

namespace DailyWageUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int WagePerHr = 20;
            int WorkingHr = 8;
            int EmpIsPresent = 1;
            //variables
            int DailyWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == EmpIsPresent)
            //else
            //Emp is absent, wage = 0
            DailyWage = WagePerHr * WorkingHr;
            Console.WriteLine("Daily Wage of Employee is: " + DailyWage);
            Console.ReadKey();

        }
    }
}
