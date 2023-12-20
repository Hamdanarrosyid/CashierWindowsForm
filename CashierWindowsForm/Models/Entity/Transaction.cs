using CashierWindowsForm.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.Models.Entity
{
    public class Transaction
    {
        public int Id { get; set; }
        public int TransactionLstId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public DateTime CreatedAt { get; set; }

        public Product Product { get; set; }
        public TransactionLst TransactionLst { get; set; }



    }
}
