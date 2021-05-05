using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //varibles
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            // computation
            int empcheck = random.Next(0, 3);
            if (empcheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if
            {
                empHrs = 4;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("EmpWage:" + empWage);

        }
    }
}
