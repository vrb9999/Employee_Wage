using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageUsingArrayList
{
    class CompanyEmpWage
    {
        const int ISPRESENT = 1;
        const int ISPARTTIME = 2;
        readonly string companyName;
        readonly int wagePerHour;
        readonly int totalWorkingDays;
        readonly int maxHrsWorked;

        public CompanyEmpWage(string companyName, int wagePerHour, int totalWorkingDays, int maxHrsWorked)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.totalWorkingDays = totalWorkingDays;
            this.maxHrsWorked = maxHrsWorked;
        }
        public void ComputingWage()
        {
            static int getworkhrs()
            {
                int workDayHours = 0;

                Random random = new Random();
                int employeeCheck = random.Next(0, 3);
                switch (employeeCheck)
                {
                    case 1:
                        workDayHours = 8;
                        return workDayHours;
                    case 2:
                        workDayHours = 4;
                        return workDayHours;
                    default:
                        workDayHours = 0;
                        return workDayHours;
                }
            }
            int totalWorkingHrs = 0;
            int workingDays = 1;
            int totalWage = 0;
            int workingHrs = 0;

            while (workingDays <= totalWorkingDays && totalWorkingHrs < maxHrsWorked)
            {
                workingHrs = getworkhrs();
                totalWage += wagePerHour * workingHrs;

                totalWorkingHrs += workingHrs;
                workingDays++;
            }
            Console.WriteLine($"Employee from {companyName} earns {totalWage} ");
        }
    }
}
