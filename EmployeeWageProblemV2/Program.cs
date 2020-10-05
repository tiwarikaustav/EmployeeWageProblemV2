using System;

namespace EmployeeWageProblemV2
{
    class Program
    {      
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Capgemini", 20, 100, 20);
            empWageBuilder.addCompanyEmpWage("Cadence", 25, 120, 28);
            empWageBuilder.CalculateEmpWage();
        }

    }
}
