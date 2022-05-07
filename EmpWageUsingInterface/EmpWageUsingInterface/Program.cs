using System;

namespace EmpWageUsingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompany("TCS", 1000, 20, 100);
            empWageBuilder.AddCompany("TATA", 200, 20, 100);
            empWageBuilder.AddCompany("Infy", 300, 20, 100);
            empWageBuilder.IterateOverListOfCompany();
            Console.ReadLine();          
        }
    }
}
