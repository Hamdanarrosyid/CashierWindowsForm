using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm
{
    internal class Employee
    {
        //private DbContext dbContext = new DbContext();
        
        public models.Employee employee = new models.Employee();

        public string Login(string _email, string _password)
        {
            string sql = "SELECT * from employee WHERE email='"+ _email + "' AND password='"+ _password+"'";
            MySqlDataReader row = new DbContext().ExcequteReader(sql);

            if (row.HasRows)

            {
                while (row.Read())
                {                   
                    employee.id = row.GetInt32("id");
                    employee.name = row.GetString("name");
                    employee.email = row.GetString("email");
                    employee.address = row.GetString("address");
                    //employee.gender = (models.Employee.Gender)row["gender"];
                }
                
                return employee.name;
            }
            return null;
        }

    }
}
