using CashierWindowsForm.Controllers;
using CashierWindowsForm.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierWindowsForm.Views
{
    public partial class FrmEntryTransaction : Form
    {
        public delegate void CreateUpdateEventHandler(Transaction transaction);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;

        private TransactionController controller = new TransactionController();

        public FrmEntryTransaction()
        {
            InitializeComponent();
        }

        public FrmEntryTransaction(string title, TransactionController controller) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }


    }
}
