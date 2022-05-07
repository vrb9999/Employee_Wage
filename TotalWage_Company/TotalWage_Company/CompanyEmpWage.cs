using System;
using System.Collections.Generic;
using System.Text;

namespace TotalWage_Company
{
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public int dailyWage;
        public int TotalWageAlongWithDailyWage;
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "\n\nTotal Emp Wage for Company : " + this.company + " is :" + this.totalEmpWage + "\n\nDaily Wage for Company : " + this.company + " is :" + this.dailyWage + "\n\nTotal  Emp wage along with daily Wage is " + this.TotalWageAlongWithDailyWage;
        }
    }
}
