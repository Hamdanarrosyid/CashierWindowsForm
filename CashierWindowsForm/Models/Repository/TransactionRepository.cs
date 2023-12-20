using CashierWindowsForm.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;

namespace CashierWindowsForm.Models.Repository
{
    internal class TransactionRepository
    {
        private DbContext dbContext;

        public TransactionRepository()
        {
            dbContext = new DbContext();
        }

        public int Create(Transaction transaction)
        {
            int result = 0;
            string sql = @"INSERT INTO transactions (transaction_lst_id, product_id, quantity, sub_total, created_at) 
                           VALUES (@transaction_lst_id, @productId, @quantity, @subTotal, @createdAt)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql))
                {
                    cmd.Parameters.AddWithValue("@transaction_lst_id", transaction.TransactionLstId);
                    cmd.Parameters.AddWithValue("@productId", transaction.ProductId);
                    cmd.Parameters.AddWithValue("@quantity", transaction.Quantity);
                    cmd.Parameters.AddWithValue("@subTotal", transaction.SubTotal);
                    cmd.Parameters.AddWithValue("@createdAt", transaction.CreatedAt);

                    result = dbContext.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                Debug.Print("Create error: {0}", ex.Message);
            }

            return result;
        }

        public List<Transaction> GetAllByTransactionLstId(int transactionLstID)
        {
            List<Transaction> list = new List<Transaction>();
            try
            {
                string sql = $@"SELECT *, product.id as product_id, product.name as product_name, product.price as product_price FROM transactions inner join product on transactions.product_id = product.id where transactions.transaction_lst_id = {transactionLstID} order by created_at";
                using (SQLiteDataReader dtr = dbContext.ExecuteReader(sql))
                {
                    while (dtr.Read())
                    {
                        Transaction transaction = new Transaction
                        {
                            Id = int.Parse(dtr["id"].ToString()),
                            TransactionLstId = int.Parse(dtr["transaction_lst_id"].ToString()),
                            ProductId = int.Parse(dtr["product_id"].ToString()),
                            Quantity = int.Parse(dtr["quantity"].ToString()),
                            SubTotal = Decimal.Parse(dtr["sub_total"].ToString()),
                            CreatedAt = DateTime.Parse(dtr["created_at"].ToString()),
                            Product = new Product
                            {
                                Id = int.Parse(dtr["product_id"].ToString()),
                                Name = dtr["product_name"].ToString(),
                                Price = decimal.Parse(dtr["product_price"].ToString()),
                            }
                        };

                        list.Add(transaction);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        public List<Transaction> GetAll()
        {
            List<Transaction> list = new List<Transaction>();
            try
            {
                string sql = @"SELECT *, product.id as product_id, product.name as product_name, product.price as product_price FROM transactions inner join product on transactions.product_id = product.id order by created_at";
                using (SQLiteDataReader dtr = dbContext.ExecuteReader(sql))
                {
                    while (dtr.Read())
                    {
                        Transaction transaction = new Transaction
                        {
                            Id = int.Parse(dtr["id"].ToString()),
                            TransactionLstId = int.Parse(dtr["transaction_lst_id"].ToString()),
                            ProductId = int.Parse(dtr["product_id"].ToString()),
                            Quantity = int.Parse(dtr["quantity"].ToString()),
                            SubTotal = Decimal.Parse(dtr["sub_total"].ToString()),
                            CreatedAt = DateTime.Parse(dtr["created_at"].ToString()),
                            Product = new Product
                            {
                                Id = int.Parse(dtr["product_id"].ToString()),
                                Name = dtr["product_name"].ToString(),
                                Price = decimal.Parse(dtr["product_price"].ToString()),
                            }
                    };

                        list.Add(transaction);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        public Transaction Get(int id)
        {
            Transaction transaction = new Transaction();

            string sql = @"SELECT * FROM transactions WHERE id = @id";

            SQLiteParameter param = new SQLiteParameter("@id");
            param.Value = id;

            using (var dtr = dbContext.ExecuteReader(sql, param))
            {
                if (dtr.Read())
                {
                    transaction.Id = int.Parse(dtr["id"].ToString());
                    transaction.TransactionLstId = int.Parse(dtr["transaction_lst_id"].ToString());
                    transaction.ProductId = int.Parse(dtr["product_id"].ToString());
                    transaction.Quantity = int.Parse(dtr["quantity"].ToString());
                    transaction.SubTotal = Decimal.Parse(dtr["sub_total"].ToString());
                    transaction.CreatedAt = DateTime.Parse(dtr["created_at"].ToString());
                }
                else
                {
                    throw new Exception("Transaction not found");
                }
            }

            return transaction;
        }

        public int Update(Transaction transaction)
        {
            int result = 0;
            string sql = @"UPDATE transactions 
                           SET transaction_lst_id = @transaction_lst_id, 
                               product_id = @productId, 
                               quantity = @quantity, 
                               sub_total = @subTotal, 
                               created_at = @createdAt 
                           WHERE id = @transactionId";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql))
                {
                    cmd.Parameters.AddWithValue("@transactionId", transaction.Id);
                    cmd.Parameters.AddWithValue("@transaction_lst_id", transaction.TransactionLstId);
                    cmd.Parameters.AddWithValue("@productId", transaction.ProductId);
                    cmd.Parameters.AddWithValue("@quantity", transaction.Quantity);
                    cmd.Parameters.AddWithValue("@subTotal", transaction.SubTotal);
                    cmd.Parameters.AddWithValue("@createdAt", transaction.CreatedAt);

                    result = dbContext.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                Debug.Print("Update error: {0}", ex.Message);
            }

            return result;
        }

        public int Delete(int id)
        {
            int result = 0;
            string sql = @"DELETE FROM transactions WHERE id = @transactionId";

            using (SQLiteCommand cmd = new SQLiteCommand(sql))
            {
                cmd.Parameters.AddWithValue("@transactionId", id);

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
    }
}
