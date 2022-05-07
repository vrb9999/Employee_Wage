using System;

namespace TotalWage_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpBuilderArray empWageBuilder = new EmpBuilderArray();
            empWageBuilder.addCompanyEmpWage("hcl", 100, 20, 100);
            empWageBuilder.addCompanyEmpWage("hp", 150, 25, 150);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for hcl Comapny " + empWageBuilder.getTotalWage("hcl"));
            Console.WriteLine("Total Wage for hp Comapny " + empWageBuilder.getTotalWage("hp"));
        }
    }
}
