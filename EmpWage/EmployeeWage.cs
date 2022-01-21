///-----------------Dependencies------------------///

using System;
using System.Collections.Generic;
using System.Text;

//---------NameSpace---------------//
namespace EmpWage
{
    //---------Class Name------------//
    internal class EmployeeWage
    {
        /// <summary>
        /// ---------Instance Variables-------///
        /// </summary>
        const int Is_Full_Time = 1;
        const int Is_Part_Time = 2;
        const int Emp_Rate_Per_Hour = 20;
        const int Num_Of_Working_days = 5;
        //----------Method Starts-------------//
        public void NoWorkingDays()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            Random randomNumber = new Random();
            for (int day = 1; day <= Num_Of_Working_days; day++)
            {
                int checkingNum = randomNumber.Next(0, 3);
                switch (checkingNum)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        Console.WriteLine("\nEmp present FullTime");
                        break;
                    case Is_Part_Time:
                        empHrs = 4;
                        Console.WriteLine("\nEmp present partTime");

                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("\nEmp absent");

                        break;
                }
                empWage = empHrs * Emp_Rate_Per_Hour;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("daycount:\t" + day + "\nEmp Wage:\t" + empWage);
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("\n\nTotal Employee wage :\t" + totalEmpWage);
        }
    }
    //---------------Method Ends----------------------------//
}


