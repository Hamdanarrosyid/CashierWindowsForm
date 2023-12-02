using CashierWindowsForm.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.Models.Repository
{
    internal class ProductRepository
    {
        public ProductRepository() { }

        public int Create(Product _product)
        {
            int result = 0;
            string sql = @"insert into product (name, price, stock, brand_id) values (@name, @price, @stock, @brandId)";
            SQLiteCommand cmd = new SQLiteCommand(sql);

                cmd.Parameters.AddWithValue("@name", _product.Name);
                cmd.Parameters.AddWithValue("@price", _product.Price);
                cmd.Parameters.AddWithValue("@stock", _product.Quantity);

                try
                {
                result = new DbContext().ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
   
            return result;
        }

        public List<Product> ReadAll()
        {
            List<Product> list = new List<Product>();
            try
            {
                string sql = @"select * from Product order by name";
                var dtr = new DbContext().ExcequteReader(sql);
                {
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Product _product = new Product();
                            _product.Name = dtr["name"].ToString();
                            _product.Price = Decimal.Parse(dtr["price"].ToString());
                            _product.Quantity = Int32.Parse(dtr["quantity"].ToString());
                            // tambahkan objek Product ke dalam collection
                            list.Add(_product);
                        }
                    }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }
    }
}
