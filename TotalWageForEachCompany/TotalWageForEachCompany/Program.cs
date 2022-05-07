using System;

namespace TotalWageForEachCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Instance_variable comp1 = new Instance_variable("hcl", 100, 20, 100);
            comp1.ComputeWage();
            Console.WriteLine(comp1.ToString());
            Instance_variable comp2 = new Instance_variable("hp", 150, 30, 150);
            comp2.ComputeWage();
            Console.WriteLine(comp2.ToString());
        }
    }
}
