using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageUsingInterface
{
    internal interface IComputeEmpWage
    {
        void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
        void IterateOverListOfCompany();
    }
}
