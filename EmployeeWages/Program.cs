using System;

namespace EmployeeWages
{
    class Program
    {   
        public const int IS_FULL_TIME = 1;
        public const int PART_TIME = 2;
       
        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPermonth)
        { 
            // Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDay = 0;

            //Computation
            while(totalEmpHrs <= maxHoursPermonth && totalWorkingDay < numOfWorkingDays)
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
            int totalEmpWage = totalEmpHrs + empRatePerHour;
            Console.WriteLine("Total Emp Wage for company:" + company + "is:" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("Dmart", 20, 2, 10);
            ComputeEmpWage("Wipro", 10, 3, 30);
        }
    }
}
