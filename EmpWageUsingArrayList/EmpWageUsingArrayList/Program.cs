using System;

namespace EmpWageUsingArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            WageBuilder empWageBuilderArray = new WageBuilder(5);
            empWageBuilderArray.addEmployeeWage("hcl", 20, 15, 100);
            empWageBuilderArray.addEmployeeWage("hp", 25, 20, 80);
            empWageBuilderArray.addEmployeeWage("tcs", 20, 22, 90);
            empWageBuilderArray.addEmployeeWage("pwc", 35, 20, 110);
            empWageBuilderArray.addEmployeeWage("ongc", 30, 18, 80);
            empWageBuilderArray.getWage();
        }
    }
}
