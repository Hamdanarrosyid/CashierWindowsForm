using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using System.Data.SQLite;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace CashierMigration
{
    internal class Program
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
        
        static void CreateTableEmployee()
        {
            SQLiteConnection connection = GetConnection();

            string cmd = "DROP TABLE IF EXISTS employee;" +
                "CREATE TABLE IF NOT EXISTS employee(" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                "name VARCHAR(100) NOT NULL," +
                "email VARCHAR(100) NOT NULL,"+
                "password VARCHAR(100) NOT NULL," +
                "gender VARCHAR(100) NOT NULL," +
                "address VARCHAR(200)"+
                ")";
            SQLiteCommand command = new SQLiteCommand(cmd, connection);
            command.CommandType = CommandType.Text;

            try
            {
                var res = command.ExecuteNonQuery();
                Console.WriteLine("Table employee is created");

            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
            connection.Close();
            connection.Dispose();

        }
        static void CreateTableBrand()
        {
            SQLiteConnection connection = GetConnection();

            string cmd = "DROP TABLE IF EXISTS brand;" +
                "CREATE TABLE IF NOT EXISTS brand(" +
                "id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL ," +
                "name VARCHAR(100) NOT NULL" +
                ")";
            SQLiteCommand command = new SQLiteCommand(cmd, connection);
            command.CommandType = CommandType.Text;

            try
            {
                var res = command.ExecuteNonQuery();
                Console.WriteLine("Table brand is created");

            }
            catch (SQLiteException ex)
            {

                throw ex;
            }
            connection.Close();
            connection.Dispose();

        }
        static void CreateTableProduct()
        {
            SQLiteConnection connection = GetConnection();

            string cmd = "DROP TABLE IF EXISTS product;" +
                "CREATE TABLE IF NOT EXISTS product(" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL ," +
                "brand_id INTEGER NOT NULL," +
                "name VARCHAR(100) NOT NULL," +
                "price DECIMAL NOT NULL," +
                "quantity INTEGER NOT NULL," +
                "barcode VARCHAR(255) NOT NULL,"+
                "FOREIGN KEY (brand_id) REFERENCES brand(id)" +
                ")";
            SQLiteCommand command = new SQLiteCommand(cmd, connection);
            command.CommandType = CommandType.Text;

            try
            {
                var res = command.ExecuteNonQuery();
                Console.WriteLine("Table product is created");

            }
            catch (SQLiteException ex)
            {

                throw ex;
            }
            connection.Close();
            connection.Dispose();
        }
        static void CreateTableTransaction()
        {
            SQLiteConnection connection = GetConnection();

            string cmd = "DROP TABLE IF EXISTS transactions;" +
                "CREATE TABLE IF NOT EXISTS transactions(" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL ," +
                "transaction_lst_id INTEGER NOT NULL," +
                "product_id INTEGER NOT NULL," +
                "quantity INTEGER NOT NULL," +
                "sub_total DECIMAL NOT NULL," +
                "created_at DATE NOT NULL," +
                "FOREIGN KEY (transaction_lst_id) REFERENCES transaction_lst(id)," +
                "FOREIGN KEY (product_id) REFERENCES product(id)" +
                ")";
            SQLiteCommand command = new SQLiteCommand(cmd, connection);
            command.CommandType = CommandType.Text;

            try
            {
                var res = command.ExecuteNonQuery();
                Console.WriteLine("Table transaction is created");

            }
            catch (SQLiteException ex)
            {

                throw ex;
            }
            connection.Close();
            connection.Dispose();

        }

        static void CreateTableTransactionLst()
        {
            SQLiteConnection connection = GetConnection();

            string cmd = "DROP TABLE IF EXISTS transactions_lst;" +
                "CREATE TABLE IF NOT EXISTS transactions_lst(" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL ," +
                "employee_id INTEGER NOT NULL," +
                "total_price DECIMAL," +
                "pay DECIMAL," +
                "payback DECIMAL," +
                "created_at DATE NOT NULL," +
                "FOREIGN KEY (employee_id) REFERENCES employee(id)" +
                ")";
            SQLiteCommand command = new SQLiteCommand(cmd, connection);
            command.CommandType = CommandType.Text;

            try
            {
                var res = command.ExecuteNonQuery();
                Console.WriteLine("Table transaction is created");

            }
            catch (SQLiteException ex)
            {

                throw ex;
            }
            connection.Close();
            connection.Dispose();

        }

        static void InsertAdminEmploye()
        {
            SQLiteConnection connection = GetConnection();
            string cmd = "INSERT INTO employee(name, email, password, gender) VALUES('admin', 'admin@gmail.com', 'admin', 'man')";
            SQLiteCommand command = new SQLiteCommand(cmd, connection);
            try
            {
                var res = command.ExecuteNonQuery();
                Console.WriteLine("Table transaction is created");

            }
            catch (SQLiteException ex)
            {

                throw ex;
            }
            connection.Close();
            connection.Dispose();
        }
        static void Main(string[] args)
        {
            CreateTableEmployee();
            CreateTableBrand();
            CreateTableProduct();
            CreateTableTransactionLst();
            CreateTableTransaction();
            InsertAdminEmploye();

        }
    }
}
