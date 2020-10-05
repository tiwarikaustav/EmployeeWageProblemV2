using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblemV2
{
    class EmpWageBuilder
    {
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilder()
        {
            this.companyEmpWageArray = new CompanyEmpWage[10];
        }

        public void addCompanyEmpWage(string company, int wagePerHour, int maxWorkHour, int maxWorkDays)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, wagePerHour, maxWorkHour, maxWorkDays);
            numOfCompany++;
        }

        public void CalculateEmpWage()
        {
            for(int i=0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.CalculateEmpWage(companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 3);
        }
        public const int ABSENT = 0;
        public const int HALF_DAY = 1;
        public const int FULL_DAY = 2;
        private int CalculateEmpWage(CompanyEmpWage companyEmpWage)
        {
            int dailyHours = 0;
            int totalWorkHours = 0;
            int totalEmpWage = 0;
            for (int currentDay = 1; currentDay <= companyEmpWage.maxWorkDays; currentDay++)
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
                if (totalWorkHours + dailyHours > companyEmpWage.maxWorkHour)
                    dailyHours = 0;
                totalWorkHours += dailyHours;
            }
            Console.WriteLine("Total payable hours for the month are: " + totalWorkHours);
            totalEmpWage = totalWorkHours * companyEmpWage.wagePerHour;
            //Console.WriteLine("Amount payable to Employee is: " + totalEmpWage);
            return totalEmpWage;
        }

    }
    
}
