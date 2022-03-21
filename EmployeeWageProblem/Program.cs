using System;

namespace UC6_EmployeeWageProblem
{
    public class UC6_EmployeeWage
    {
        ///Constants
        public int is_FullTime = 1;
        public int is_PartTime = 2;
        public int emp_Rate_Per_Hr = 20;
        public int total_Working_Hrs = 99;
        public int total_Work_Days_In_Month = 20;

        ///Variables
        public int empHrs = 0;
        public int empTotalWage = 0;
        public int total_Worked_DAys = 0;
        public int total_Worked_Hrs = 0;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            UC6_EmployeeWage uc5 = new UC6_EmployeeWage();

            ///Computation
            while (uc5.total_Worked_DAys <= uc5.total_Work_Days_In_Month || uc5.total_Worked_Hrs <= uc5.total_Working_Hrs)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                uc5.total_Worked_DAys++;
                uc5.total_Worked_Hrs++;
                switch (empCheck)
                {
                    case 1:
                        uc5.empHrs = 8;
                        break;
                    case 2:
                        uc5.empHrs = 4;
                        break;
                    default:
                        uc5.empHrs = 0;
                        break;
                }

            }
            Console.WriteLine("Total Worked Hr =" + uc5.total_Worked_Hrs);
            uc5.empTotalWage = uc5.total_Worked_Hrs * uc5.emp_Rate_Per_Hr;
            Console.WriteLine("emp Total Wage =" + uc5.empTotalWage);
        }
    }
}





