using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CashierWindowsForm
{
    internal class DbContext
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=root;database=cashier";
        public MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            return conn;
        }
    }
}
