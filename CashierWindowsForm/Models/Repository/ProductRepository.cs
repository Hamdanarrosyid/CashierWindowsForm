using CashierWindowsForm.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;

namespace CashierWindowsForm.Models.Repository
{
    internal class ProductRepository
    {
        BarcodeGenerator barcodeGenerator = new BarcodeGenerator();
        private DbContext dbContext;

        public ProductRepository()
        {
            dbContext = new DbContext();
        }

        public int Create(Product _product)
        {
            int result = 0;
            string sql = @"insert into product (name, price, quantity, brand_id, barcode) values (@name, @price, @quantity, @brandId,@barcode)";


            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql))
                {

                    cmd.Parameters.AddWithValue("@name", _product.Name);
                    cmd.Parameters.AddWithValue("@price", _product.Price);
                    cmd.Parameters.AddWithValue("@quantity", _product.Quantity);
                    cmd.Parameters.AddWithValue("@brandId", _product.BrandId);
                    string base64Barcode = barcodeGenerator.GenerateBarcode(_product.BrandId);
                    cmd.Parameters.AddWithValue("@barcode", base64Barcode);
                    //using (DbContext dbContext = this.dbContext)
                    DbContext dbContext = this.dbContext;
                    {
                        result = dbContext.ExecuteNonQuery(cmd);

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print("Create error: {0}", ex.Message);
            }

            return result;
        }

        public int Update(Product _product)
        {
            int result = 0;
            string sql = @"UPDATE product 
                   SET name = @name, 
                       price = @price, 
                       quantity = @quantity, 
                       brand_id = @brandId, 
                       barcode = @barcode 
                   WHERE id = @productId";



            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql))
                {
                    cmd.Parameters.AddWithValue("@productId", _product.Id);
                    cmd.Parameters.AddWithValue("@name", _product.Name);
                    cmd.Parameters.AddWithValue("@price", _product.Price);
                    cmd.Parameters.AddWithValue("@quantity", _product.Quantity);
                    cmd.Parameters.AddWithValue("@brandId", _product.BrandId);
                    string base64Barcode = barcodeGenerator.GenerateBarcode(_product.BrandId);
                    cmd.Parameters.AddWithValue("@barcode", base64Barcode);
                    //using (DbContext dbContext = this.dbContext)
                    DbContext dbContext = this.dbContext;
                    {
                        result = dbContext.ExecuteNonQuery(cmd);

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print("Update error: {0}", ex.Message);
            }


            return result;
        }

        public int Delete(int productId)
        {
            int result = 0;
            string sql = @"DELETE FROM product WHERE id = @productId";

            using (SQLiteCommand cmd = new SQLiteCommand(sql))
            {
                cmd.Parameters.AddWithValue("@productId", productId);

                try
                {
                    result = dbContext.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Product> GetAll(string filterName = "")
        {
            List<Product> list = new List<Product>();
            try
            {
                string sql = String.Format(@"SELECT product.*,brand.name as brand_name FROM product INNER JOIN brand ON product.brand_id = brand.id WHERE product.name LIKE '%{0}%' ORDER BY product.name", filterName);
                using (SQLiteDataReader dtr = this.dbContext.ExecuteReader(sql))
                //SQLiteDataReader dtr = this.dbContext.ExecuteReader(sql);
                {

                    while (dtr.Read())
                    {
                        Product _product = new Product();
                        _product.Id = int.Parse(dtr["id"].ToString());
                        _product.Name = dtr["name"].ToString();
                        _product.Price = Decimal.Parse(dtr["price"].ToString());
                        _product.Quantity = Int32.Parse(dtr["quantity"].ToString());
                        _product.BrandId = int.Parse(dtr["brand_id"].ToString());

                        _product.Brand = new Brand
                        {
                            Id = int.Parse(dtr["brand_id"].ToString()),
                            Name = dtr["brand_name"].ToString()
                        };

                        list.Add(_product);
                    }
                }


            }
            catch (Exception ex)
            {
                Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }


        public Product Get(int id)
        {
            Product product = new Product();

            string sql = @"SELECT product.*, brand.name as brand_name 
           FROM product 
           INNER JOIN brand ON product.brand_id = brand.id 
           WHERE product.id = @id";

            SQLiteParameter param = new SQLiteParameter("@id");
            param.Value = id;

            using (var dtr = dbContext.ExecuteReader(sql, param))
            {
                if (dtr.Read())
                {
                    product.Id = int.Parse(dtr["id"].ToString());
                    product.Name = dtr["name"].ToString();
                    product.Price = Decimal.Parse(dtr["price"].ToString());
                    product.Quantity = Int32.Parse(dtr["quantity"].ToString());
                    product.BrandId = int.Parse(dtr["brand_id"].ToString());

                    product.Brand = new Brand
                    {
                        Id = int.Parse(dtr["brand_id"].ToString()),
                        Name = dtr["brand_name"].ToString()
                    };
                }
                else
                {
                    throw new Exception("Product not found");
                }
            }

            return product;
        }

    }
}
