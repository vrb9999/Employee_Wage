using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageUsingInterface
{
    class CompanyEmpWage
    {
        public string companyName;
        public int wagePerHour, maxWorkingDays, maxWorkingHours, totalEmpMonthWage;

        public CompanyEmpWage(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void setTotalEmpWage(int totalEmpMonthWage)
        {
            this.totalEmpMonthWage = totalEmpMonthWage;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
