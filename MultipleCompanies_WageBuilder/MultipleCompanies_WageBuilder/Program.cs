using System;

namespace MultipleCompanies_WageBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompany("TCS", 100, 20, 100);
            empWageBuilder.AddCompany("TATA", 200, 20, 100);
            empWageBuilder.AddCompany("Infy", 300, 20, 100);
            empWageBuilder.AddCompany("Google", 1000, 20, 100);
            empWageBuilder.DisplayCompanyWages();
        }
    }
}
