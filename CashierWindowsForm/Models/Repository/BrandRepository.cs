using CashierWindowsForm.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.Models.Repository
{
    internal class BrandRepository
    {

        public BrandRepository() { }
            public int Create(Brand _brand)
            {
                int result = 0;
                string sql = @"insert into product (name, brandId) values (@name, @brandId)";
                SQLiteCommand cmd = new SQLiteCommand(sql);

                cmd.Parameters.AddWithValue("@name", _brand.Name);
                cmd.Parameters.AddWithValue("@price", _brand.BrandId);

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

    }
}
