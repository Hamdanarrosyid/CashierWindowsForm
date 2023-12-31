﻿using CashierWindowsForm.models;
using CashierWindowsForm.Models.Repository;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.controllers
{
    public class EmployeeController
    {
        private EmployeRepository employeRepository = new EmployeRepository();
        public string Login(string _email, string _password)
        {
            return employeRepository.Login(_email, _password);
        }
        public List<Employee> ReadAll() {
            return employeRepository.ReadAll();
        }

        public int Create(Employee employe)
        {
            return 1;
            //return employeRepository.Create(employe);
        }

        public int Update(Employee employee)
        {
            return 1;
            //return employeRepository.Update(employee);
        }
    }
}
