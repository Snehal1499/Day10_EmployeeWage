using System;

namespace UC10_EmployeeWage
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int emp_Rate_Per_Hr, int no_Of_Working_Days, int max_Hrs_Per_Month);
        public void computeEmpWage();
        public int getTotalWage(string company);
    }
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
            this.total_Emp_Wage = 0;
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

    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int is_Part_Time = 1;
        public const int is_Full_Time = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyEmpWageMap;
    



        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyEmpWageMap = new Dictionary<string,  CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int emp_Rate_Per_Hr, int no_Of_Working_Days, int max_Hrs_Per_Month)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, emp_Rate_Per_Hr, no_Of_Working_Days, max_Hrs_Per_Month);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyEmpWageMap.Add(company, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.ToString());
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
        public int getTotalWage(string company)
        {
            return this.companyEmpWageMap[company].total_Emp_Wage;

        }
    }

    public class program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Emp Wage for Dmart Company :" + empWageBuilder.getTotalWage("Dmart"));


        }
    }
}
