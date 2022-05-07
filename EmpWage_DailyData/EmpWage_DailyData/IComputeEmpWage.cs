using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage_DailyData
{
    interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpWage();
        public int getTotalWage(string company);
    }
}



