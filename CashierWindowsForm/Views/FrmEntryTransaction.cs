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
using System.Xml.Linq;

namespace CashierWindowsForm.Views
{
    public partial class FrmEntryTransaction : Form
    {
        public delegate void CreateUpdateEventHandler(Transaction transaction);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;

        private TransactionLst TransactionLst = new TransactionLst();

        private TransactionController transactionController;
        private ProductController productController = new ProductController();
        private TransactionLstController transactionLstController = new TransactionLstController();

        private Transaction editingTransaction;

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

        public FrmEntryTransaction(string title, Transaction transaction, TransactionController controller, TransactionLst transactionLst) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.transactionController = controller;
            this.TransactionLst = transactionLst;
            editingTransaction = transaction;
            LoadTransactionData();
        }

        private void LoadTransactionData()
        {
            if (editingTransaction != null)
            {
                txtQuantityProduct.Text = editingTransaction.Quantity.ToString();
                List<Product> products = productController.GetAll();
                Product selectedProduct = products.FirstOrDefault(b => b.Id == editingTransaction.Product.Id);
                var index = lstProduct.Items.IndexOf(selectedProduct);

                lstProduct.SelectedIndex = index;
                lstProduct.DisplayMember = "Name";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (editingTransaction != null)
            {
                SetTransactionData(editingTransaction);
                var result = transactionController.Update(editingTransaction);
                if (result > 0)
                {
                    MessageBox.Show("Success", "Berhasil melakukan update", MessageBoxButtons.OK);
                    OnUpdate(editingTransaction);
                    Close();
                }
            }
            else
            {
                Transaction transaction = new Transaction();
                SetTransactionData(transaction);
                if (lstProduct.SelectedItem != null)
                {

                    var result = transactionController.Create(transaction);
                    if (result > 0)
                    {
                        Product product = productController.Get(transaction.ProductId);

                        product.Quantity -= transaction.Quantity;
                        productController.Update(product);

                        TransactionLst transactionLst = transactionLstController.Get(transaction.TransactionLstId);
                        transactionLst.TotalPrice += transaction.SubTotal;
                        transactionLstController.Update(transactionLst);
                        MessageBox.Show("Success", "Berhasil menambah transaction", MessageBoxButtons.OK);
                        OnCreate(transaction);
                        Close();
                    }
                }

            }


        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            LoadProduct(lstProduct.Text);
        }

        private void SetTransactionData(Transaction transaction)
        {
            Product selectedPRoduct = (Product)lstProduct.SelectedItem;
            transaction.ProductId = selectedPRoduct.Id;

            transaction.Quantity = int.Parse(txtQuantityProduct.Text);
            transaction.TransactionLstId = TransactionLst.Id;
            transaction.SubTotal = transaction.Quantity * selectedPRoduct.Price;
        }
    }
}
