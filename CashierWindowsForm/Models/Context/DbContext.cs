using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;

namespace CashierWindowsForm
{
    public class DbContext : IDisposable
    {
        private SQLiteConnection connection;
        private int counter = 0;
        public DbContext()
        {
            InitializeConnection();
            counter += 1;
            Debug.Print("connection created: {0}", counter);
        }

        private void InitializeConnection()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string grandparentDirectory = Directory.GetParent(currentDirectory)?.Parent?.Parent?.FullName;

            string databaseFileName = "cashier.db";
            string databasePath = Path.Combine(grandparentDirectory, databaseFileName);

            string connectionString = $"Data Source={databasePath};FailIfMissing=True";
                connection = new SQLiteConnection(connectionString);
                connection.Open();
        }

        public SQLiteDataReader ExecuteReader(string sql, SQLiteParameter param = null)
        {
            try
            {
                //using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                {
                    if (param != null)
                    {
                        cmd.Parameters.Add(param);
                    }
                    //using (SQLiteDataReader reader = cmd.ExecuteReader())
                        SQLiteDataReader reader = cmd.ExecuteReader();
                    {
                        return reader;
                    }
                }
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
                int affected;
                using (SQLiteTransaction mytransaction = connection.BeginTransaction())
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    affected = cmd.ExecuteNonQuery();
                    mytransaction.Commit();
                }
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public int ExecuteNonQuery(SQLiteCommand cmd)
        {
            try
            {

                int affected;
                cmd.Connection = connection;
                using (SQLiteTransaction mytransaction = connection.BeginTransaction())
                {
                    affected = cmd.ExecuteNonQuery();
                    mytransaction.Commit();
                }
                return affected;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public object ExecuteScalar(SQLiteCommand cmd)
        {
            try
            {
                cmd.Connection = connection;
                return cmd.ExecuteScalar();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public void Dispose()
        {
            if (connection != null)
            {
                try
                {
                    if (connection.State != ConnectionState.Closed) connection.Close();
                }
                finally
                {
                    connection.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
