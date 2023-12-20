using CashierWindowsForm.controllers;
using CashierWindowsForm.Controllers;
using CashierWindowsForm.Lib;
using CashierWindowsForm.Models.Entity;
using CashierWindowsForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
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

        private List<Product> products = new List<Product>();
        private TransactionLst TransactionLst = new TransactionLst();

        private TransactionController transactionController;
        private ProductController productController = new ProductController();
        private TransactionLstController transactionLstController = new TransactionLstController();

        private JwtManager jwtManager = new JwtManager();

        public FrmEntryTransaction()
        {
            InitializeComponent();
            LoadProduct();
        }

        public void LoadProduct(string filterName = "")
        {
            lstProduct.Items.Clear();
            var products = productController.GetAll(filterName);
            foreach (var product in products)
            {
                lstProduct.Items.Add(product);
                lstProduct.DisplayMember = "Name";
            }
        }

        public FrmEntryTransaction(string title, TransactionController controller, TransactionLst transactionLst) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.transactionController = controller;
            this.TransactionLst = transactionLst;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();

            if (lstProduct.SelectedItem != null)
            {
                Product selectedPRoduct = (Product)lstProduct.SelectedItem;
                transaction.ProductId = selectedPRoduct.Id;

                transaction.Quantity = int.Parse(txtQuantityProduct.Text);
                transaction.TransactionLstId = TransactionLst.Id;
                transaction.SubTotal = transaction.Quantity * selectedPRoduct.Price;
                var result = transactionController.Create(transaction);
                if (result > 0)
                {
                    TransactionLst transactionLst = transactionLstController.Get(transaction.TransactionLstId);
                    transactionLst.TotalPrice += transaction.SubTotal;
                    transactionLstController.Update(transactionLst);
                    MessageBox.Show("Success", "Berhasil menambah transaction", MessageBoxButtons.OK);
                    OnCreate(transaction);
                    Close();
                }
            }

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            LoadProduct(lstProduct.Text);
        }
    }
}
