using CashierWindowsForm.Controllers;
using CashierWindowsForm.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierWindowsForm.Views
{
    public partial class FrmTransactionHistory : Form
    {
        private List<TransactionLst> lstTransactions= new List<TransactionLst>();
        private TransactionLstController controller;
        private void InisialisasiListView()
        {
            lvwTransactionHistory.View = View.Details;
            lvwTransactionHistory.FullRowSelect = true;
            lvwTransactionHistory.GridLines = true;
            lvwTransactionHistory.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwTransactionHistory.Columns.Add("Employee", 200, HorizontalAlignment.Center);
            lvwTransactionHistory.Columns.Add("Total Price", 100, HorizontalAlignment.Left);
            lvwTransactionHistory.Columns.Add("Created At", 200, HorizontalAlignment.Center);
        }

        private void LoadListHistoryTransaction()
        {
            lstTransactions = controller.GetAll();
            foreach (var lst in lstTransactions)
            {
                var noUrut = lvwTransactionHistory.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(lst.Employee.Name);
                item.SubItems.Add(lst.TotalPrice.ToString());
                item.SubItems.Add(lst.CreatedAt.ToString());
                lvwTransactionHistory.Items.Add(item);
            }
        }


        public FrmTransactionHistory()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        public FrmTransactionHistory(string title, TransactionLstController _controller): this()
        {
            Text = title;
            controller = _controller;
            LoadListHistoryTransaction();

        }

        private void lvwTransactionHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.Print("selected");
        }
    }
}
