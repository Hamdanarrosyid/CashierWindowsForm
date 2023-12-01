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
            
            string cmd = "CREATE TABLE IF NOT EXISTS employee(" +
                "id INT PRIMARY KEY NOT NULL," +
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

            string cmd = "CREATE TABLE IF NOT EXISTS brand(" +
                "id INT PRIMARY KEY NOT NULL ," +
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

            string cmd = "CREATE TABLE IF NOT EXISTS product(" +
                "id INT PRIMARY KEY NOT NULL ," +
                "brand_id INT NOT NULL," +
                "name VARCHAR(100) NOT NULL," +
                "price DECIMAL NOT NULL," +
                "quantity INT NOT NULL," +
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

            string cmd = "CREATE TABLE IF NOT EXISTS transactions(" +
                "id INT PRIMARY KEY NOT NULL ," +
                "employee_id INT NOT NULL," +
                "product_id INT NOT NULL," +
                "total_price DECIMAL NOT NULL," +
                "created_at DATE NOT NULL," +
                "FOREIGN KEY (employee_id) REFERENCES employee(id)," +
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

        static void InsertAdminEmploye()
        {
            SQLiteConnection connection = GetConnection();
            string cmd = "INSERT INTO employee(id,name, email, password, gender) VALUES(1,'admin', 'admin@gmail.com', 'admin', 'man')";
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
            CreateTableTransaction();
            InsertAdminEmploye();

        }
    }
}
