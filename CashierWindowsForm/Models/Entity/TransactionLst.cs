using CashierWindowsForm.models;
using Org.BouncyCastle.Crypto.Agreement.JPake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.Models.Entity
{
    public class TransactionLst
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime CreatedAt { get; set; }

        public Employee Employee { get; set; }
        public decimal Pay { get; set; }
        public decimal PayBack { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
