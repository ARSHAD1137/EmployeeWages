using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_Full_TIME = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_Full_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
