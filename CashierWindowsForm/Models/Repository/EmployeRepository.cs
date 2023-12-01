using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.Models.Repository
{
    public class EmployeRepository
    {
        public models.Employee employee = new models.Employee();

        public string Login(string _email, string _password)
        {
            string sql = "SELECT * from employee WHERE email='" + _email + "' AND password='" + _password + "'";
            SQLiteDataReader row = new DbContext().ExcequteReader(sql);

            if (row.HasRows)

            {
                while (row.Read())
                {
                    employee.Id = Int32.Parse(row["id"].ToString());
                    employee.Name = row["name"].ToString();
                    employee.Email = row["email"].ToString();
                    employee.Address = row["address"].ToString();
                    //employee.gender = (models.Employee.Gender)row["gender"];
                }

                return employee.Name;
            }
            return null;
        }
    }
}
