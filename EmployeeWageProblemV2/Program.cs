using System;

namespace EmployeeWageProblemV2
{
    class Program
    {      
        static void Main(string[] args)
        {
            EmpWageBuilder Capgemini = new EmpWageBuilder("Capgemini", 20, 100, 20);
            EmpWageBuilder Cadence = new EmpWageBuilder("Cadence", 25, 120, 28);
            Capgemini.CalculateEmpWage();
            Cadence.CalculateEmpWage();
        }

    }
}
