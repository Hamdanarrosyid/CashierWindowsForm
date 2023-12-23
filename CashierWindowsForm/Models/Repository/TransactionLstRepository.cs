using CashierWindowsForm.models;
using CashierWindowsForm.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.Models.Repository
{
    internal class TransactionLstRepository
    {
        private DbContext dbContext = new DbContext();

        public TransactionLst CreateWithReturnValue(TransactionLst transactionLst)
        {
            string sql = "INSERT INTO transactions_lst (employee_id, created_at, total_price) VALUES (@employeeId, @createdAt, @totalPrice); SELECT last_insert_rowid();";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql))
                {
                    cmd.Parameters.AddWithValue("@employeeId", transactionLst.EmployeeId);
                    cmd.Parameters.AddWithValue("@createdAt", transactionLst.CreatedAt);
                    cmd.Parameters.AddWithValue("@totalPrice", transactionLst.TotalPrice);

                    // Execute the command and retrieve the last inserted ID
                    object lastInsertedId = dbContext.ExecuteScalar(cmd);

                    if (lastInsertedId != null && int.TryParse(lastInsertedId.ToString(), out int newId))
                    {
                        // Set the generated ID to the transactionLst object
                        transactionLst.Id = newId;
                        return transactionLst;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print("Create error: {0}", ex.Message);
            }

            return null; // Return null if an error occurs
        }


        public int Create(TransactionLst transactionLst)
        {
            int result = 0;
            string sql = "INSERT INTO transactions_lst (employee_id, created_at, total_price) VALUES (@employeeId, @createdAt, @totalPrice)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql))
                {
                    cmd.Parameters.AddWithValue("@employeeId", transactionLst.EmployeeId);
                    cmd.Parameters.AddWithValue("@createdAt", transactionLst.CreatedAt);
                    cmd.Parameters.AddWithValue("@totalPrice", transactionLst.TotalPrice);

                    result = dbContext.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                Debug.Print("Create error: {0}", ex.Message);
            }

            return result;
        }

        public List<TransactionLst> GetAll()
        {
            List<TransactionLst> list = new List<TransactionLst>();
            try
            {
                string sql = "SELECT DISTINCT transactions_lst.*,employee.name as employee_name, sum(transactions.sub_total) as total FROM transactions_lst inner join transactions on transactions_lst.id = transactions.transaction_lst_id inner join employee on transactions_lst.employee_id = employee.id group by transactions_lst.id";
                using (SQLiteDataReader dtr = dbContext.ExecuteReader(sql))
                {
                    while (dtr.Read())
                    {
                        TransactionLst transactionLst = new TransactionLst();
                        transactionLst.Id = int.Parse(dtr["id"].ToString());
                        transactionLst.EmployeeId = int.Parse(dtr["employee_id"].ToString());
                        transactionLst.CreatedAt = DateTime.Parse(dtr["created_at"].ToString());
                        transactionLst.TotalPrice = Decimal.Parse(dtr["total"].ToString());

                        // Assuming you have an Employee table with corresponding columns
                        // Adjust the columns accordingly based on your actual schema
                        transactionLst.Employee = new Employee
                        {
                            Id = int.Parse(dtr["employee_id"].ToString()),
                            Name = dtr["employee_name"].ToString(),
                        };

                        list.Add(transactionLst);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        public int Update(TransactionLst transactionLst)
        {
            int result = 0;
            string sql = "UPDATE transactions_lst SET employee_id = @employeeId, created_at = @createdAt, total_price = @totalPrice, pay = @pay, payback = @payback WHERE id = @id";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql))
                {
                    cmd.Parameters.AddWithValue("@employeeId", transactionLst.EmployeeId);
                    cmd.Parameters.AddWithValue("@createdAt", transactionLst.CreatedAt);
                    cmd.Parameters.AddWithValue("@totalPrice", transactionLst.TotalPrice);
                    cmd.Parameters.AddWithValue("@payback", transactionLst.PayBack);
                    cmd.Parameters.AddWithValue("@pay", transactionLst.Pay);
                    
                    cmd.Parameters.AddWithValue("@id", transactionLst.Id);

                    result = dbContext.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                Debug.Print("Update error: {0}", ex.Message);
            }

            return result;
        }

        public int Delete(int transactionLstId)
        {
            int result = 0;
            string sql = "DELETE FROM transactions_lst WHERE id = @id";

            using (SQLiteCommand cmd = new SQLiteCommand(sql))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@id", transactionLstId);

                    result = dbContext.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    Debug.Print("Delete error: {0}", ex.Message);
                }

            }
            return result;
        }

        public TransactionLst Get(int transactionLstId)
        {
            TransactionLst transactionLst = null;

            try
            {
                string sql = $@"SELECT * FROM transactions_lst WHERE id = '{transactionLstId}'";

                using (SQLiteDataReader dtr = dbContext.ExecuteReader(sql))
                {
                    if (dtr.Read())
                    {
                        transactionLst = new TransactionLst();
                        transactionLst.Id = int.Parse(dtr["id"].ToString());
                        transactionLst.EmployeeId = int.Parse(dtr["employee_id"].ToString());
                        transactionLst.CreatedAt = DateTime.Parse(dtr["created_at"].ToString());
                        transactionLst.TotalPrice = Decimal.Parse(dtr["total_price"].ToString());
                        transactionLst.Pay = Decimal.Parse(dtr["pay"].ToString());
                        transactionLst.PayBack = Decimal.Parse(dtr["payback"].ToString());

                        // Assuming you have an Employee table with corresponding columns
                        // Adjust the columns accordingly based on your actual schema
                        transactionLst.Employee = new Employee
                        {
                            // Set properties based on Employee table columns
                        };
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.Print("Get error: {0}", ex.Message);
            }

            return transactionLst;
        }
    }

}
