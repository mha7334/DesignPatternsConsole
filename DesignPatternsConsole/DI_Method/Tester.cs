﻿using System;
using System.Collections.Generic;

namespace DesignPatternsConsole.DI_Method
{
    public class Tester
    {
        public static void Run(string[] args)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            //Call to GetAllEmployees method with proper object.            
            List<Employee> ListEmployee = employeeBL.GetAllEmployees(new EmployeeDAL());
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }

        }
    }
}