using System;

namespace EmployeeWageProblemV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = Attendance();
            int fullDayHour = 8;
            int wagePerHour = 20;
            int dailyWage = DailyWage(fullDayHour, wagePerHour);
            if (isPresent == 0)
                Console.WriteLine("Employee is Absent");
            else
                Console.WriteLine("Employee is Present");

            Console.WriteLine("Daily wage of the employee is: {0}", dailyWage);
        }

        //Gives random numbers 0/1, 0=Absent, 1=Present
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 2);
        }

        static int DailyWage(int fullDayHour, int wagePerHour)
        {
            return fullDayHour * wagePerHour;
        }
    }
}
