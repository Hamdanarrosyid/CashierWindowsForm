using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace CashierWindowsForm
{
    public class DbContext
    {
        static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn;

            string currentDirectory = Directory.GetCurrentDirectory();
            string grandparentDirectory = Directory.GetParent(currentDirectory)?.Parent?.Parent?.FullName;


            string databaseFileName = "cashier.db";

            string databasePath = Path.Combine(grandparentDirectory, databaseFileName);


           // string dbName = @"C:\Users\hamdan\source\repos\CashierWindowsForm\cashier.db";
            string connectionString = string.Format("DataSource ={0}; FailIfMissing = True", databasePath);
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            
            return conn;
        }

        public SQLiteDataReader ExcequteReader(string sql)
        {
            try
            {
                SQLiteDataReader reader;
                SQLiteCommand cmd = new SQLiteCommand(sql, GetConnection());
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int ExecuteNonQuerySec(string sql)
        {
            try
            {
                var connection = GetConnection();
                int affected;
                SQLiteTransaction mytransaction = connection.BeginTransaction();
                SQLiteCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public int ExecuteNonQuery(SQLiteCommand cmd)
        {
            try
            {
                var connection = GetConnection();
                int affected;
                cmd.Connection = connection;
                SQLiteTransaction mytransaction = connection.BeginTransaction();
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            } 
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
    }
}
