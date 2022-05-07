using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageUsingArrayList
{
    class WageBuilder
    {
        private CompanyEmpWage[] empWageArray;

        public WageBuilder(int size)
        {
            this.empWageArray = new CompanyEmpWage[size];
        }
        int i = 0;
        public void addEmployeeWage(string companyName, int wagePerHour, int totalWorkingDays, int maxHrsWorked)
        {
            empWageArray[i] = new CompanyEmpWage(companyName, wagePerHour, totalWorkingDays, maxHrsWorked);
            i++;
        }
        public void getWage()
        {
            for (int j = 0; j < empWageArray.Length; j++)
            {
                empWageArray[j].ComputingWage();
            }
        }
    }
}
