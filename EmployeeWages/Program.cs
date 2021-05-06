using System;

namespace EmployeeWages
{
    class Program
    {   
        public const int IS_FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKINGDAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public static int ComputeEmpWage()
        { 
            // Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDay = 0;

            //Computation
            while(totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDay < NUM_OF_WORKINGDAYS)
            {
                totalWorkingDay++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    case 3:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDay + "Emp Hrs:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs + EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
        }
    }
}
