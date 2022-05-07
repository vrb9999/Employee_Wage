using System;
using System.Collections.Generic;
using System.Text;

namespace TotalWageForEachCompany
{
    class Instance_variable
    {
		const int FULL_DAY_HOUR = 8;
		const int PART_TIME_HOUR = 4;
		const int EMP_FULL_TIME = 1;
		const int EMP_PART_TIME = 2;
		readonly string companyName;
		readonly int wagePerHour;
		readonly int maxWorkingDays;
		readonly int maxWorkingHours;
		int wagesPerMonth = 0;
		public Instance_variable(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
		{
			this.companyName = companyName;
			this.wagePerHour = wagePerHour;
			this.maxWorkingDays = maxWorkingDays;
			this.maxWorkingHours = maxWorkingHours;
		}
		public void ComputeWage()
		{
			int workingHours = 0;
			int workingDays = 0;

			Random rand = new Random();

			while (workingHours < maxWorkingHours && workingDays < maxWorkingDays)
			{
				int attendance = rand.Next(0, 3);
				int hoursWorked = 0;
				switch (attendance)
				{
					case 1:
						workingDays += 1;
						hoursWorked = FULL_DAY_HOUR;
						break;
					case 2:
						workingDays += 1;
						hoursWorked = PART_TIME_HOUR;
						break;
					default:
						break;
				}
				workingHours += hoursWorked;
				wagesPerMonth += (wagePerHour * workingHours);
			}
		}
		public override string ToString()
		{
			return $"Wages for the company {companyName} : {wagesPerMonth}";
		}
	}
}
