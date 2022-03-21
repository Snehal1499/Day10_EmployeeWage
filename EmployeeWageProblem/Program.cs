using System;

namespace EmployeeWageProblem
{
    public class UC3_EmployeeWage
    {
        ///Constants
        public int is_PartTime = 1;
        public int is_FullTime = 2;
        public int emp_Rate_Per_Hr = 20;

        ///variables
        public int empHrs = 0;
        public int empWage = 0;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            UC3_EmployeeWage uc3 = new UC3_EmployeeWage();
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            //Computation
            if (empCheck == uc3.is_FullTime)
            {
                uc3.empHrs = 8;
            }
            else if (empCheck == uc3.is_PartTime)
            {
                uc3.empHrs = 4;
            }
            else
            {
                uc3.empHrs = 0;
            }
            uc3.empWage = uc3.empHrs * uc3.emp_Rate_Per_Hr;
            Console.WriteLine("Wage= " + uc3.empWage);
        }
    }
}




