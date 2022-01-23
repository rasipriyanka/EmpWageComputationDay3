using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------Creating Instance For Class------------//
            EmployeeWage empWageBuilder = new EmployeeWage(); // Creating a Object
            empWageBuilder.AddCompanyEmpWage("hgs", 20, 20, 90);
            empWageBuilder.AddCompanyEmpWage("abc", 40, 23, 100);
            empWageBuilder.AddCompanyEmpWage("jkk", 12, 22, 100);
            empWageBuilder.computeEmpWage();
            Console.ReadLine();
        }
    }
}
