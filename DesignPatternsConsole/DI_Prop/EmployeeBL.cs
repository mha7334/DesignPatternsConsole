﻿using System;
using System.Collections.Generic;

namespace DesignPatternsConsole.DI_Prop
{
    public class EmployeeBL
    {
        private IEmployeeDAL employeeDAL;
        public IEmployeeDAL employeeDataObject
        {
            set
            {
                this.employeeDAL = value;
            }
            get
            {
                if (employeeDataObject == null)
                {
                    throw new Exception("Employee is not initialized");
                }
                else
                {
                    return employeeDAL;
                }
            }
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.SelectAllEmployees();
        }
    }

    public class DI_PropTester
    {
        public static void Main(string[] args)
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