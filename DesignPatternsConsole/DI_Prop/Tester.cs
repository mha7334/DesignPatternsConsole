﻿using System;
using System.Collections.Generic;

namespace DesignPatternsConsole.DI_Prop
{
    public class Tester
    {
        public static void Run(string[] args)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            employeeBL.employeeDataObject = new EmployeeDAL();

            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
           
        }
    }
}