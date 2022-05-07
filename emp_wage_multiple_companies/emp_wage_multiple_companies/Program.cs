using System;

namespace emp_wage_multiple_companies
{
    class Program
    {
		const int FULL_DAY_HOUR = 8;
		const int PART_TIME_HOUR = 4;
		const int EMP_FULL_TIME = 1;
		const int EMP_PART_TIME = 2;

		static void ComputeWage(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
		{
			int workingHours = 0;
			int workingDays = 0;
			int wagesPerMonth = 0;
			Random rand = new Random();

			while (workingHours < maxWorkingHours && workingDays < maxWorkingDays)
			{
				int attendance = rand.Next(0, 3);
				int hoursWorked = 0;
				switch (attendance)
				{
					case EMP_FULL_TIME:
						workingDays += 1;
						hoursWorked = FULL_DAY_HOUR;
						break;
					case EMP_PART_TIME:
						workingDays += 1;
						hoursWorked = PART_TIME_HOUR;
						break;
					default:
						break;
				}
				workingHours += hoursWorked;
				wagesPerMonth += (wagePerHour * workingHours);
			}
			Console.WriteLine($"Wages for the company {companyName} : {wagesPerMonth}");
		}
		static void Main(string[] args)
        {
			ComputeWage("hcl", 100, 20, 100);
			ComputeWage("hp", 150, 20, 150);
			
		}
    }
}
