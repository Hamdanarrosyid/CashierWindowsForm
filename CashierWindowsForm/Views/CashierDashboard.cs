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
    public partial class CashierDashboard : Form
    {
        private List<Transaction> listOfTransaction = new List<Transaction>();
        private TransactionController transactionController = new TransactionController();
        private void InisialisasiListView()
        {
            lvwTransaction.View = System.Windows.Forms.View.Details;
            lvwTransaction.FullRowSelect = true;
            lvwTransaction.GridLines = true;
            lvwTransaction.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwTransaction.Columns.Add("Barang", 200, HorizontalAlignment.Center);
            lvwTransaction.Columns.Add("Harga", 100, HorizontalAlignment.Left);
            lvwTransaction.Columns.Add("Qty", 80, HorizontalAlignment.Center);
            lvwTransaction.Columns.Add("Sub Total", 100, HorizontalAlignment.Center);
        }

        public CashierDashboard()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        public void OnCreateEventHandler(Transaction transaction)
        {
            listOfTransaction.Add(transaction);
            int noUrut = lvwTransaction.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(transaction.Product.Name);
            item.SubItems.Add(transaction.Product.Price.ToString());
            item.SubItems.Add(transaction.Quantity.ToString());
            decimal subTotal = transaction.Quantity * transaction.Product.Price;
            item.SubItems.Add(subTotal.ToString());
            lvwTransaction.Items.Add(item);
        }

        private void btnSeaerhAdd_Click(object sender, EventArgs e)
        {
            FrmEntryTransaction frmEntry = new FrmEntryTransaction("Tambah Data Mahasiswa", transactionController);
            frmEntry.OnCreate += OnCreateEventHandler;
            frmEntry.ShowDialog();
        }


    }
}
