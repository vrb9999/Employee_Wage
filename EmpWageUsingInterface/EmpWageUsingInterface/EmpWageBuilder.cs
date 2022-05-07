using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageUsingInterface
{
    class EmpWageBuilder : IComputeEmpWage
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        private int numberOfCompany = 0;
        private CompanyEmpWage[] companyEmpWagesArray = new CompanyEmpWage[5];
        public void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            companyEmpWagesArray[numberOfCompany] = new CompanyEmpWage(companyName, wagePerHour, maxWorkingDays, maxWorkingHours);
            numberOfCompany++;
        }
        public void IterateOverListOfCompany()
        {
            for (int i = 0; i < numberOfCompany; i++)
            {
                ComputeWage(companyEmpWagesArray[i]);
            }
        }
        public int ComputeWage(CompanyEmpWage obj) 
        {
            int empWorkHour = 0, empDailyWage = 0, empTotalHour = 0, empTotalWorkDays = 0, totalMonthWage = 0;
            Random random = new Random(); 
            while (empTotalHour <= obj.maxWorkingHours && empTotalWorkDays <= obj.maxWorkingDays)
            {
                int check = random.Next(0, 3); 
                switch (check)
                {
                    case IS_FULL_TIME:
                        empWorkHour = 8;
                        break;

                    case IS_PART_TIME:
                        empWorkHour = 4;
                        break;
                    default:
                        empWorkHour = 0;
                        break;
                }
                empDailyWage = empWorkHour * obj.wagePerHour; 
                                                              
                totalMonthWage += empDailyWage;
                empTotalWorkDays++;
                empTotalHour += empWorkHour;
            }
            if (empTotalHour > obj.maxWorkingHours) 
            {
                int a = empTotalHour - obj.maxWorkingHours;
                empTotalHour -= a;
                int wage = a * obj.wagePerHour;
                totalMonthWage -= wage; 
            }
            if (empTotalWorkDays > obj.maxWorkingDays)
            {
                empTotalWorkDays -= 1;
            }
            Console.WriteLine("\n\nCompany Name : " + obj.companyName);
            Console.WriteLine($"\nEmployee total working days for {obj.companyName} company is : {empTotalWorkDays}");
            Console.WriteLine($"Employee total working hours for {obj.companyName} company is : {empTotalHour}\n");
            Console.WriteLine($"Employee Total Month Wage for {obj.companyName} company is : {totalMonthWage}\n");
            return totalMonthWage;
        }

    }
}
