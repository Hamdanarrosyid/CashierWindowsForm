using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace CashierMigration
{
    internal class Program
    {
        static MySqlConnection GetConnection()
        {
            string connectionString = "server=127.0.0.1;uid=root;pwd=root;database=cashier";
            var conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
            return conn;
        }
        
        static void CreateTableEmployee()
        {
            MySqlConnection connection = GetConnection();
            
            string cmd = "CREATE TABLE IF NOT EXISTS employee(" +
                "id INT PRIMARY KEY NOT NULL AUTO_INCREMENT," +
                "name VARCHAR(100) NOT NULL," +
                "email VARCHAR(100) NOT NULL,"+
                "gender ENUM('man', 'woman') NOT NULL," +
                "address VARCHAR(200)"+
                ")";
            MySqlCommand command = new MySqlCommand(cmd, connection);
            command.CommandType = CommandType.Text;

            try
            {
                var res = command.ExecuteNonQuery();
                Console.WriteLine("Table employee is created");

            }
            catch (MySqlException ex)
            {

                throw ex;
            }

        }
        static void CreateTableBrand()
        {
            MySqlConnection connection = GetConnection();

            string cmd = "CREATE TABLE IF NOT EXISTS brand(" +
                "id INT PRIMARY KEY NOT NULL AUTO_INCREMENT," +
                "name VARCHAR(100) NOT NULL," +
                ")";
            MySqlCommand command = new MySqlCommand(cmd, connection);
            command.CommandType = CommandType.Text;

            try
            {
                var res = command.ExecuteNonQuery();
                Console.WriteLine("Table brand is created");

            }
            catch (MySqlException ex)
            {

                throw ex;
            }

        }
        static void CreateTableProduct()
        {
            MySqlConnection connection = GetConnection();

            string cmd = "CREATE TABLE IF NOT EXISTS product(" +
                "id INT PRIMARY KEY NOT NULL AUTO_INCREMENT," +
                "brand_id INT NOT NULL," +
                "name VARCHAR(100) NOT NULL," +
                "price DECIMAL NOT NULL," +
                "FOREIGN KEY (brand_id) REFERENCES brand(id)" +
                ")";
            MySqlCommand command = new MySqlCommand(cmd, connection);
            command.CommandType = CommandType.Text;

            try
            {
                var res = command.ExecuteNonQuery();
                Console.WriteLine("Table product is created");

            }
            catch (MySqlException ex)
            {

                throw ex;
            }

        }
        static void CreateTableItem()
        {
            MySqlConnection connection = GetConnection();

            string cmd = "CREATE TABLE IF NOT EXISTS item(" +
                "id INT PRIMARY KEY NOT NULL AUTO_INCREMENT," +
                "brand_id INT NOT NULL," +
                "name VARCHAR(100) NOT NULL," +
                "price DECIMAL NOT NULL," +
                "FOREIGN KEY (brand_id) REFERENCES brand(id)" +
                ")";
            MySqlCommand command = new MySqlCommand(cmd, connection);
            command.CommandType = CommandType.Text;

            try
            {
                var res = command.ExecuteNonQuery();
                Console.WriteLine("Table item is created");

            }
            catch (MySqlException ex)
            {

                throw ex;
            }

        }
        static void Main(string[] args)
        {
            CreateTableEmployee();
            CreateTableBrand();
            CreateTableProduct();
            CreateTableItem();
        }
    }
}
