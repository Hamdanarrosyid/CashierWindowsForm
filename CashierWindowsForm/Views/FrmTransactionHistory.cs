using CashierWindowsForm.controllers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CashierWindowsForm.Views
{
    public partial class FrmTransactionHistory : Form
    {
        public delegate void CreateUpdateEventHandler(TransactionLst transactionLst);
        public event CreateUpdateEventHandler OnSelected;
        //public event CreateUpdateEventHandler OnUpdate;
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
            lvwTransactionHistory.Items.Clear();
            foreach (var lst in lstTransactions)
            {
                var noUrut = lvwTransactionHistory.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.Tag = lst.Id;
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lvwTransactionHistory.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwTransactionHistory.SelectedItems[0];
                TransactionLst transactionLst = controller.Get(int.Parse(item.Tag.ToString()));
                
                OnSelected(transactionLst);
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwTransactionHistory.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (confirmation == DialogResult.Yes)
                {
                    int id = (int)lvwTransactionHistory.SelectedItems[0].Tag; ;
                    var result = controller.Delete(id);

                    if (result > 0)
                    {
                        LoadListHistoryTransaction();
                    } else
                    {
                        Debug.Print("error");
                    }
                }
            }
            else // Data not selected
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
