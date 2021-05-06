using System;

namespace EmployeeWages
{
    class Program
    {   
        public const int IS_FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKINGDAYS = 20;

        static void Main(string[] args)
        { 
            // Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            //Computation
            for (int day = 0; day < NUM_OF_WORKINGDAYS; day++)
            {
                Random random = new Random();
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("EmpWage:" + empWage);
            }
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);


        }
    }
}
