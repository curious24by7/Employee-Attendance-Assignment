using System;

namespace Switch_Case_UC4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case 0:
                    Console.WriteLine("Employee is Absent.");
                    break;
                case 1:
                    Console.WriteLine("Employee is Present Full time and Daily wage = 160");
                    break;
                case 2:
                    Console.WriteLine("Employee is Present part time and Daily Wage = 80");
                    break;
            }
        }   
    }
}
