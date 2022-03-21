using System;

namespace UC8_EmployeeWageProblem
{
    public class Program
    {
        ///Constants
        public const int is_Part_Time = 1;
        public const int is_Full_Time = 2;

        public static int companyEmpWage(string companyName, int empRatePerHr, int noOfWorkingDays, int maxHrsPerMonth)
        {
            int totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs < maxHrsPerMonth && totalWorkingDays < noOfWorkingDays)
            {
                int empHrs = 0;
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs = empHrs + totalEmpHrs;
               
            }
            int totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("totalEmpWage = " + totalEmpWage);
            Console.WriteLine("totalEmpWage of " + companyName + " is " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            companyEmpWage("Dmart", 20, 2, 10);
            companyEmpWage("Reliance", 10, 4, 20);

        }
    }
}







