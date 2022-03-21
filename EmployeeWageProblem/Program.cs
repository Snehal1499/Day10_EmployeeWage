using System;

namespace UC9_EmployeeWageProblem
{
    public class EmployeeWageBuilderObject
    {
        public const int is_Part_Time = 1, is_Full_Time = 2;
        public string company;
        public int emp_Rate_Per_Hr, no_Of_Working_Days, max_Hours_Per_Month, total_Emp_Wage;

        public EmployeeWageBuilderObject (string company, int emp_Rate_Per_Hr, int no_Of_Working_DAys, int max_Hours_Per_Month)
        {
            this.company = company;
            this.emp_Rate_Per_Hr = emp_Rate_Per_Hr;
            this.no_Of_Working_Days = no_Of_Working_DAys;
            this.max_Hours_Per_Month = max_Hours_Per_Month;
        }
        public void computeEmpWage()
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= this.max_Hours_Per_Month && totalEmpHrs < this.no_Of_Working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case is_Part_Time:
                        empHrs = 4;
                        break;
                    case is_Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("DAy# =" + totalWorkingDays + "Emp Hrs =" + empHrs);

            }
            total_Emp_Wage = totalEmpHrs * this.emp_Rate_Per_Hr;
            Console.WriteLine("Total Emp Wage For Comapny =" + company + " is " + total_Emp_Wage);


        }
        public string ToString()
        {
            return "Total Emp Wage For Company " + company + " is " + total_Emp_Wage;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeWageBuilderObject dmart = new EmployeeWageBuilderObject("Dmart", 20, 2, 10);
            EmployeeWageBuilderObject reliance = new EmployeeWageBuilderObject("Reliance", 10, 4, 20);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.ToString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.ToString());
        }
    }
}