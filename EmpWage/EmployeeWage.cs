﻿///-----------------Dependencies------------------///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//---------NameSpace---------------//
namespace EmpWage
{
    //---------Class Name------------//
    class EmployeeWage
    {
        public const int Is_Full_Time = 2; //fields here to assign constant values by using keyword const
        public const int Is_Part_Time = 1;
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;
        public EmployeeWage()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void AddCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHoursPermonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHr, numOfWorkingDays, maxHoursPermonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmployeeWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 1;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                Random random = new Random(); //Creating a object for random value
                int empCheck = random.Next(0, 3);// To get the values from 0 to 2
                switch (empCheck)
                {
                    case Is_Full_Time:
                        // If random value is 1 it will execute block of statement
                        empHrs = 8;
                        break;
                    case Is_Part_Time: // If random value is 2 it will execute block of statement
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0; // If random value is 0 then it will execotr
                        break;
                }
                // Employee wage calculation part
                totalEmpHrs += empHrs;
                Console.WriteLine("Day {0} is {1} hrs", totalWorkingDays, empHrs);
                totalWorkingDays++;
            }
            return totalEmpHrs * companyEmpWage.empRatePerHr;
        }

    }
}
