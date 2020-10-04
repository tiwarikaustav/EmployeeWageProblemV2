using System;

namespace EmployeeWageProblemV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 0;
            int dailyWage = 0;
            int fullDayHour = 8;
            int halfDayHour = 4;
            int wagePerHour = 20;
            int workDaysMonthly = 0;
            int maxWorkDaysMonthly = 20;
            int workHoursMonthly = 0;
            int maxWorkHoursMonthly = 100;
            int wageForMonth = 0;
            
            //Monthly wage is added until a condition of max working hours or max working days is met
            while(workDaysMonthly < maxWorkDaysMonthly && workHoursMonthly < maxWorkHoursMonthly)
            {
                isPresent = Attendance();
                switch (isPresent)
                {
                    case (0):
                        Console.WriteLine("Employee is Absent");
                        dailyWage = 0;
                        wageForMonth += dailyWage;
                        break;
                    case (1):
                        Console.WriteLine("Employee is present but half day");
                        dailyWage = halfDayHour * wagePerHour;
                        wageForMonth += dailyWage;
                        workHoursMonthly += 4;
                        workDaysMonthly++;
                        break;
                    case (2):
                        Console.WriteLine("Employee is present full day");
                        dailyWage = fullDayHour * wagePerHour;
                        wageForMonth += dailyWage;
                        workHoursMonthly += 8;
                        workDaysMonthly++;
                        break;
                    default:
                        break;
                }
            }
            

            Console.WriteLine("Monthly wage of the employee is: {0}", wageForMonth);
        }

        //Gives random numbers 0/1/2, 0=Absent, 1=Half day present, 2=Full day present
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 3);
        }

    }
}
