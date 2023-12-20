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
    internal class BrandRepository
    {
        private DbContext dbContext;

        public BrandRepository()
        {
            dbContext = new DbContext();
        }

        public int Create(Brand _brand)
        {
            int result = 0;
            string sql = @"insert into brand (name) values (@name)";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.AddWithValue("@name", _brand.Name);

            try
            {
                result = dbContext.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                Debug.Print("Create error: {0}", ex.Message);
            }

            return result;
        }

        public int Update(Brand brand)
        {
            int result = 0;
            string sql = @"UPDATE brand SET name = @name WHERE id = @id";

            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.AddWithValue("@name", brand.Name);
            cmd.Parameters.AddWithValue("@id", brand.Id);

            try
            {
                result = dbContext.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                Debug.Print("UpdateBrand error: {0}", ex.Message);
            }

            return result;
        }


        public int Delete(int brandId)
        {
            int result = 0;
            string sql = @"DELETE FROM brand WHERE id = @brandId";

            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.AddWithValue("@brandId", brandId);

            try
            {
                result = dbContext.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                Debug.Print("DeleteBrand error: {0}", ex.Message);
            }

            return result;
        }


        public Brand Get(int id)
        {
            Brand brand = new Brand();

            string sql = @"select * from brand where id = @id";
            SQLiteParameter param = new SQLiteParameter("@id");
            param.Value = id;

            using (SQLiteDataReader dtr = dbContext.ExecuteReader(sql, param))
            {
                if (dtr.Read())
                {
                    brand.Id = int.Parse(dtr["id"].ToString());
                    brand.Name = dtr["name"].ToString();
                }
                else
                {
                    throw new Exception("error");
                }
            }



            return brand;
        }

        public List<Brand> GetAll()
        {
            List<Brand> listOfBrand = new List<Brand>();
            try
            {
                string sql = @"select * from brand order by name";

                using (SQLiteDataReader dtr = dbContext.ExecuteReader(sql))
                {


                    while (dtr.Read())
                    {
                        Brand brand = new Brand();
                        brand.Id = int.Parse(dtr["id"].ToString());
                        brand.Name = dtr["name"].ToString();
                        listOfBrand.Add(brand);
                    }
                }

            }
            catch (Exception e)
            {
                Debug.Print("Read all error: {0}", e.Message);
            }
            return listOfBrand;
        }
    }
}
