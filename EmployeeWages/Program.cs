using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            // Variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computation
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case 1:
                    empHrs = 8;
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    break;
                case 2:
                    empHrs = 4;
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    break;
                case 3:
                    empHrs = 0;
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    break;
            }

            Console.WriteLine("EmpWage:" + empWage);


        }
    }
}
