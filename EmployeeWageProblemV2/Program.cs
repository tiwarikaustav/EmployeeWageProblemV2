using System;

namespace EmployeeWageProblemV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = Attendance();
            int dailyWage = DailyWage(isPresent);
            if (isPresent == 0)
                Console.WriteLine("Employee is Absent");
            else if (isPresent == 1)
                Console.WriteLine("Employee is present but half day");
            else
                Console.WriteLine("employee is present full day");

            Console.WriteLine("Daily wage of the employee is: {0}", dailyWage);
        }

        //Gives random numbers 0/1/2, 0=Absent, 1=Half day present, 2=Full day present
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 3);
        }

        //Computes daily wage of employee if he is absent, half day present or full day present
        static int DailyWage(int flag)
        {
            int fullDayHour = 8;
            int halfDayHour = 4;
            int wagePerHour = 20;
            if (flag == 0)
            {
                return 0;
            }
            else if (flag == 1)
            {
                return halfDayHour * wagePerHour;
            }
            else
            {
                return fullDayHour * wagePerHour;
            }
        }

    }
}
