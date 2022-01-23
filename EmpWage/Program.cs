using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------Creating Instance For Class------------//
            EmployeeWage empWageBuilder = new EmployeeWage();
            empWageBuilder.AddCompanyEmpWage("Dmart", 20, 20, 90);
            empWageBuilder.AddCompanyEmpWage("TATA", 20, 23, 100);
            empWageBuilder.computeEmpWage();
            Console.ReadLine();
        }
    }
}
