using CashierWindowsForm.Models.Entity;
using CashierWindowsForm.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.Controllers
{
    public class TransactionLstController
    {
        private readonly TransactionLstRepository repository = new TransactionLstRepository();

        public int Create(TransactionLst transactionLst)
        {
            return repository.Create(transactionLst);
        }

        public TransactionLst CreateWithReturnValue(TransactionLst transactionLst)
        {
            return repository.CreateWithReturnValue(transactionLst);
        }

        public List<TransactionLst> GetAll()
        {
            return repository.GetAll();
        }

        public int Update(TransactionLst transactionLst)
        {
            return repository.Update(transactionLst);
        }

        public int Delete(int transactionLstId)
        {
            return repository.Delete(transactionLstId);
        }

        public TransactionLst Get(int transactionLstId)
        {
            return repository.Get(transactionLstId);
        }
    }
}
