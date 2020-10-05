using System;

namespace EmployeeWageProblemV2
{
    class Program
    {
        const int MAX_WORK_HOURS = 100;
        const int MAX_WORK_DAYS = 20;
        const int WAGE_PER_HOUR = 20;
        const int ABSENT = 0;
        const int HALF_DAY = 1;
        const int FULL_DAY = 2;
        static void Main(string[] args)
        {
            CalculateEmpWage();
        }

        //Gives random numbers 0/1/2, 0=Absent, 1=Half day present, 2=Full day present
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 3);
        }

        static void CalculateEmpWage()
        {
            int dailyHours = 0; int totalWorkHours = 0; int totalEmpWage = 0;
            for (int currentDay = 1; currentDay <= MAX_WORK_DAYS; currentDay++)
            {
                switch (Attendance())
                {
                    case ABSENT:
                        dailyHours = 0;
                        break;
                    case HALF_DAY:
                        dailyHours = 4;
                        break;
                    case FULL_DAY:
                        dailyHours = 8;
                        break;
                    default:
                        break;
                }
                if (totalWorkHours + dailyHours >= MAX_WORK_HOURS)
                    dailyHours = 0;
                totalWorkHours += dailyHours;
                Console.WriteLine("For Day" + currentDay + " working hours are " + dailyHours);
            }
            Console.WriteLine("Total payable hours for the month are " + totalWorkHours);
            totalEmpWage = totalWorkHours * WAGE_PER_HOUR;
            Console.WriteLine("Amount payable to Employee is " + totalEmpWage);
        }

    }
}
