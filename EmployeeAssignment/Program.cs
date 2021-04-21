using System;

namespace EmployeeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int EmployeeIsAbsent = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == EmployeeIsAbsent)
                Console.WriteLine("Employee is Absent");
            else
                Console.WriteLine("Employee is Present");
            Console.ReadKey();

        }
    }
}
