using CashierWindowsForm.Models.Entity;
using CashierWindowsForm.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierWindowsForm.controllers
{
    public class TransactionController
    {
        private readonly TransactionRepository repository = new TransactionRepository();

        public int Create(Transaction transaction)
        {
            return repository.Create(transaction);
        }

        public List<Transaction> GetAll()
        {
            return repository.GetAll();
        }

        public List<Transaction> GetAllTransactionByTransactionLstID(int transactionLstId)
        {
            return repository.GetAllByTransactionLstId(transactionLstId);
        }

        public int Update(Transaction transaction)
        {
            return repository.Update(transaction);
        }

        public int Delete(int transactionId)
        {
            return repository.Delete(transactionId);
        }

        public Transaction Get(int transactionId)
        {
            return repository.Get(transactionId);
        }
    }
}
