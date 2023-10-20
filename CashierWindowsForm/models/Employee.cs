using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.models
{
    internal class Employee
    {
        public enum Gender
        {
            man,
            woman
        }
        public int id;
        public string email, name, address;
        public Gender gender;
    }
}
