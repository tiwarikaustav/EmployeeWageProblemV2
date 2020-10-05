using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblemV2
{
    class EmpWageBuilder
    {
        private string companyName;
        private int dailyWage;
        private int maxWorkHours;
        private int maxWorkDays;
        private int totalWorkHours = 0;
        public int totalEmpWage = 0;

        //constructor for the class
        public EmpWageBuilder(string company, int dailyWage, int maxWorkHours, int maxWorkDays)
        {
            this.companyName = company;
            this.dailyWage = dailyWage;
            this.maxWorkHours = maxWorkHours;
            this.maxWorkDays = maxWorkDays;
        }
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 3);
        }
        public const int ABSENT = 0;
        public const int HALF_DAY = 1;
        public const int FULL_DAY = 2;
        public void CalculateEmpWage()
        {
            Console.WriteLine("\n************************");
            Console.WriteLine("Wage Computation for the company: " + this.companyName);
            Console.WriteLine("************************");
            int dailyHours = 0;
            int totalWorkHours = 0;
            int totalEmpWage = 0;
            for (int currentDay = 1; currentDay <= this.maxWorkDays; currentDay++)
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
                Console.WriteLine("For day "+currentDay+" working hours are "+dailyHours);
                if (totalWorkHours + dailyHours > this.maxWorkHours)
                    dailyHours = 0;
                totalWorkHours += dailyHours;
            }
            Console.WriteLine("Total payable hours for the month are: " + totalWorkHours);
            totalEmpWage = totalWorkHours * this.dailyWage;
            Console.WriteLine("Amount payable to Employee is: " + totalEmpWage);
        }

    }
    
}
