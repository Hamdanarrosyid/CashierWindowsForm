using CashierWindowsForm.Lib;
using CashierWindowsForm.models;
using CashierWindowsForm.Models.Entity;
using CashierWindowsForm.Utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CashierWindowsForm.Models.Repository
{
    public class EmployeRepository
    {
        private Employee employee = new Employee();
        private JwtManager jwtManager = new JwtManager();

        public string Login(string _email, string _password)
        {
            try
            {
                using (DbContext dbContext = new DbContext())
                {
                    string sql = "SELECT * from employee WHERE email='" + _email + "' AND password='" + _password + "'";
                    SQLiteDataReader row = new DbContext().ExecuteReader(sql);

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
                        string token = jwtManager.GenerateToken(employee.Id.ToString(), employee.Email);
                        new Helper().SetAuthTokenValue(token);

                        return employee.Name;
                    }

                    return null;
                }
            }
            catch (SQLiteException ex)
            {
                System.Diagnostics.Debug.Print("Login error: {0}", ex.Message);
                return null;
            }
        }

        public List<Employee> ReadAll()
        {
            List<Employee> employees = new List<Employee>();
            return employees;
        }

    }
}
