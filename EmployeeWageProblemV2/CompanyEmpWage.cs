using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblemV2
{
    class CompanyEmpWage
    {
        public string company;
        public int wagePerHour;
        public int maxWorkDays;
        public int maxWorkHour;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int wagePerHour, int maxWorkHour, int maxWorkDays)
        {
            this.company = company;
            this.wagePerHour = wagePerHour;
            this.maxWorkDays = maxWorkDays;
            this.maxWorkHour = maxWorkHour;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Employee Wage for company: " + this.company + " is " + this.totalEmpWage + "\n";
        }
    }
}
