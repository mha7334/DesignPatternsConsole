﻿using System;

namespace DesignPatternsConsole.Ioc
{
    public class IocTester
    {
        public static void Run(string[] args)
        {
            
            EmployeeBusinessLogic BL = new EmployeeBusinessLogic(DataAccessFactory.GetEmployeeDataAccessObj());
            Employee employeeDetails = BL.GetEmployeeDetails(1);
            Console.WriteLine();
            Console.WriteLine("Employee Details:");
            Console.WriteLine("ID : {0}, Name : {1}, Department : {2}, Salary : {3}",
                employeeDetails.ID, employeeDetails.Name, employeeDetails.Department,
                employeeDetails.Salary);
            Console.WriteLine("Press any key to exist.");

            GuestBusinessLogic gBL = new GuestBusinessLogic(DataAccessFactory.GetGuestDataAccessObj());

        }
    }
}