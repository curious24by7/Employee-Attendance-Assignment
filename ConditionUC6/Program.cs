using System;

namespace ConditionUC6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int IS_FULL_TIME = 1;
            //int IS_PART_TIME = 2;
            int EmpRatePerHr = 20;
            int EmpHrs = 0;
            int EmpWage = 0;
            int MaxEmpWage = 100;
            int TotalWorkHrs = 0;
            int TotalWorkdays = 0;

            while (TotalWorkdays < 20 && TotalWorkHrs < MaxEmpWage)
            {
                TotalWorkdays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent.");
                        EmpHrs = 0;
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present Full Time.");
                        EmpHrs = 8;
                        break;
                    case 2:
                        Console.WriteLine("Employe is Present Part Time.");
                        EmpHrs = 4;
                        break;
                }
                TotalWorkHrs = TotalWorkHrs + EmpHrs;
            }
            EmpWage = TotalWorkHrs * EmpRatePerHr;

            Console.WriteLine("Employee Wage:" + EmpWage);

        }  
    }
}
