using System;

namespace UC10_EmployeeWageProblem
{
    public class CompanyEmpWage
    {
        public string company;
        public int emp_Rate_Per_Hr, no_Of_Working_Days, max_Hrs_Per_Month, total_Emp_Wage;

        public CompanyEmpWage(string company, int emp_Rate_Per_Hr, int no_Of_Working_Days, int max_Hrs_Per_Month)
        {
            this.company = company;
            this.emp_Rate_Per_Hr = emp_Rate_Per_Hr;
            this.no_Of_Working_Days = no_Of_Working_Days;
            this.max_Hrs_Per_Month = max_Hrs_Per_Month;
        }

        public void setTotalEmpWage(int total_Emp_Wage)
        {
            this.total_Emp_Wage = total_Emp_Wage;
        }

        public string ToString()
        {
            return "Total Emp Wage For Company " + this.company + " is " + this.total_Emp_Wage;
        }
    }

    public class EmpWageBuilderArray
    {
        public const int is_Part_Time = 1, is_Full_Time = 2;
        private int no_Of_Company = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int emp_Rate_Per_Hr, int no_Of_Working_Days, int max_Hrs_Per_Month)
        {
            companyEmpWageArray[this.no_Of_Company] = new CompanyEmpWage(company, emp_Rate_Per_Hr, no_Of_Working_Days, max_Hrs_Per_Month);
            no_Of_Company++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < no_Of_Company; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }

        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            ///variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            ///Computation
            while (totalEmpHrs <= companyEmpWage.max_Hrs_Per_Month && totalWorkingDays < companyEmpWage.no_Of_Working_Days)
            {
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days# = " + totalWorkingDays + " is " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.emp_Rate_Per_Hr;
        }
    }

    public class program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilderArray.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilderArray.computeEmpWage();
        }
    }
}