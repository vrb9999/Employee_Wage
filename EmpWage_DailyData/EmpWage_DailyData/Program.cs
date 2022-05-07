using System;

namespace EmpWage_DailyData
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpBuilder empWageBuilder = new EmpBuilder();
            empWageBuilder.addCompanyEmpWage("hcl", 100, 20, 100);
            empWageBuilder.addCompanyEmpWage("hp", 150, 20, 100);
            empWageBuilder.computeEmpWage();
        }
    }
}
