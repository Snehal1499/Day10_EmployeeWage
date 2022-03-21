using System;

namespace EmployeeWageProblem
{
    public class UC5_EmployeeWage
    {
        ///Constants
        public int is_FullTime = 1;
        public int is_PartTime = 2;
        public int emp_Rate_Per_Hr = 20;
        public int no_of_Working_Days = 20;

        ///Variables
        public int empHrs = 0;
        public int empWage_per_day = 0;
        public int empWage_per_Month = 0;

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            UC5_EmployeeWage uc5 = new UC5_EmployeeWage();
            Random random = new Random();

            //Computation

            int empCheck = random.Next(0, 3);
            if (empCheck == uc5.is_FullTime)
            {
                uc5.empHrs = 8;

            }
            else if (empCheck == uc5.is_PartTime)
            {
                uc5.empHrs = 4;
            }
            else
            {
                uc5.empHrs = 0;
            }
            uc5.empWage_per_day = uc5.empHrs * uc5.emp_Rate_Per_Hr;
            Console.WriteLine("Wage Per Day=" + uc5.empWage_per_day);
            uc5.empWage_per_Month = uc5.empWage_per_day * uc5.no_of_Working_Days;
            Console.WriteLine("Wage PEr Month=" + uc5.empWage_per_Month);
        }
    }
}




