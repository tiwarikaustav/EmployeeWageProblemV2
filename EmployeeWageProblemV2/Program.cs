using System;

namespace EmployeeWageProblemV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = Attendance();
            int dailyWage = 0;
            int fullDayHour = 8;
            int halfDayHour = 4;
            int wagePerHour = 20;

            switch (isPresent)
            {
                case (0):
                    Console.WriteLine("Employee is Absent");
                    dailyWage = 0;
                    break;
                case (1):
                    Console.WriteLine("Employee is present but half day");
                    dailyWage = halfDayHour * wagePerHour;
                    break;
                case (2):
                    Console.WriteLine("Employee is present full day");
                    dailyWage = fullDayHour * wagePerHour;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Daily wage of the employee is: {0}", dailyWage);
        }

        //Gives random numbers 0/1/2, 0=Absent, 1=Half day present, 2=Full day present
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 3);
        }

    }
}
