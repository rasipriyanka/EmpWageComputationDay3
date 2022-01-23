using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------Creating Instance For Class------------//
            EmployeeWage Jio = new EmployeeWage("Jio", 10, 15, 100);
            EmployeeWage hgs = new EmployeeWage("hgs", 20, 55, 50);
            Jio.EmployeeWageUc9();
            Console.WriteLine(Jio.toString());
            hgs.EmployeeWageUc9();
            Console.WriteLine(hgs.toString());

        }
    }
}
