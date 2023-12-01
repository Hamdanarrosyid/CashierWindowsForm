using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.Models.Entity
{
    internal class Transaction
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ProductId { get; set; }
        public decimal TotalPRice { get; set; }
        public DateTime CreatedAt { get; set; }



    }
}
