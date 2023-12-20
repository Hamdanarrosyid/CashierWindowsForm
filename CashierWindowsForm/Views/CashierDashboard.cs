using CashierWindowsForm.Controllers;
using CashierWindowsForm.Models.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CashierWindowsForm.models;
using CashierWindowsForm.controllers;
using CashierWindowsForm.Models.Repository;
using System.Diagnostics;
using System.Configuration;
using CashierWindowsForm.Lib;
using CashierWindowsForm.Utils;

namespace CashierWindowsForm.Views
{
    public partial class CashierDashboard : Form
    {
        private List<Transaction> listOfTransaction = new List<Transaction>();
        private List<TransactionLst> listOfTransactionLst = new List<TransactionLst>();
        private TransactionLst transactionLst;
        private List<Employee> listofEmployee = new List<Employee>();
        private List<Product> listOfProduct = new List<Product>();
        private int userId;

        private JwtManager jwtManager = new JwtManager();

        private Helper helper = new Helper();

        private readonly TransactionController transactionController = new TransactionController();
        private readonly TransactionLstController transactionLstController = new TransactionLstController();
        private readonly EmployeeController employeeController = new EmployeeController();
        private readonly ProductController productController = new ProductController();
        private readonly BrandController brandController = new BrandController();

        private void InisialisasiListViewCashier()
        {
            lvwTransaction.View = View.Details;
            lvwTransaction.FullRowSelect = true;
            lvwTransaction.GridLines = true;
            lvwTransaction.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwTransaction.Columns.Add("Barang", 200, HorizontalAlignment.Center);
            lvwTransaction.Columns.Add("Harga", 100, HorizontalAlignment.Left);
            lvwTransaction.Columns.Add("Qty", 80, HorizontalAlignment.Center);
            lvwTransaction.Columns.Add("Sub Total", 100, HorizontalAlignment.Center);
        }

        private void InisialisasiListViewProduct()
        {
            lvwproduct.View = View.Details;
            lvwproduct.FullRowSelect = true;
            lvwproduct.GridLines = true;
            lvwproduct.Columns.Add("No", 35, HorizontalAlignment.Center);
            lvwproduct.Columns.Add("Name", 200, HorizontalAlignment.Center);
            lvwproduct.Columns.Add("Brand", 200, HorizontalAlignment.Center);
            lvwproduct.Columns.Add("Stock", 200, HorizontalAlignment.Center);
            lvwproduct.Columns.Add("Price", 200, HorizontalAlignment.Center);
        }

        private void InisialisasiListViewuser()
        {
            lvwuser.View = View.Details;
            lvwuser.FullRowSelect = true;
            lvwuser.GridLines = true;
            lvwuser.Columns.Add("Name.", 150, HorizontalAlignment.Center);
            lvwuser.Columns.Add("Email", 200, HorizontalAlignment.Center);
            lvwuser.Columns.Add("Gender", 50, HorizontalAlignment.Left);
            lvwuser.Columns.Add("Address", 200, HorizontalAlignment.Center);
        }

        public CashierDashboard()
        {
            InitializeComponent();

            InisialisasiListViewCashier();
            InisialisasiListViewuser();
            InisialisasiListViewProduct();

            LoadDataEmployee();
            LoadDataProduct();

            var token = ConfigurationManager.AppSettings["AuthToken"];
            var principal = jwtManager.ValidateToken(token);
            if (principal != null)
            {
                var roleClaim = principal.FindFirst(System.Security.Claims.ClaimTypes.Role)?.Value;
                var userIdClaim = principal.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                userId = int.Parse(userIdClaim);
                lblemployee.Text = roleClaim;
            }
            else
            {
                Debug.Print("Token is invalid.");
            }

            initTransactionLst();

            LoadDataTransaction();
        }

        private void initTransactionLst()
        {
            TransactionLst transactionLstInput = new TransactionLst{
                CreatedAt = DateTime.UtcNow,
                EmployeeId = userId
            };
            transactionLst = transactionLstController.CreateWithReturnValue(transactionLstInput);
        }
        

        private void LoadDataEmployee()
        {
            lvwuser.Items.Clear();
            listofEmployee = employeeController.ReadAll();
            foreach (var emp in listofEmployee)
            {
                var noUrut = lvwuser.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(emp.Name);
                item.SubItems.Add(emp.Email);
                item.SubItems.Add(emp.Gender);
                item.SubItems.Add(emp.Address);
                lvwuser.Items.Add(item);
            }
        }

        private void LoadDataProduct()
        {
            lvwproduct.Items.Clear();
            listOfProduct = productController.GetAll();
            foreach (var product in listOfProduct)
            {
                var noUrut = lvwproduct.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.Tag = product.Id;
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Brand.Name);
                item.SubItems.Add(product.Quantity.ToString());
                item.SubItems.Add(product.Price.ToString());
                lvwproduct.Items.Add(item);
            }
        }

        private void LoadDataTransactionLst()
        {
            lvwTransaction.Items.Clear();
            listOfTransactionLst = transactionLstController.GetAll();

            Decimal subtotal = 0;

            foreach (var transaction in listOfTransaction)
            {
                var noUrut = lvwTransaction.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.Tag = transaction.Id;
                item.SubItems.Add(transaction.Product.Name);
                item.SubItems.Add(transaction.Product.Price.ToString());
                item.SubItems.Add(transaction.Quantity.ToString());
                item.SubItems.Add(transaction.SubTotal.ToString());

                subtotal += transaction.SubTotal;
                lblTotalText.Text = subtotal.ToString();


                lvwTransaction.Items.Add(item);
            }
        }

        private void LoadDataTransaction()
        {
            lvwTransaction.Items.Clear();
            listOfTransaction = transactionController.GetAllTransactionByTransactionLstID(transactionLst.Id);

            Decimal subtotal = 0;

            foreach (var transaction in listOfTransaction)
            {
                var noUrut = lvwTransaction.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.Tag = transaction.Id;
                item.SubItems.Add(transaction.Product.Name);
                item.SubItems.Add(transaction.Product.Price.ToString());
                item.SubItems.Add(transaction.Quantity.ToString());
                item.SubItems.Add(transaction.SubTotal.ToString());

                subtotal += transaction.SubTotal;
                lblTotalText.Text = subtotal.ToString();


                lvwTransaction.Items.Add(item);
            }
        }

        private void OnCreateEventHandlerCashier(Transaction transaction)
        {
            LoadDataTransaction();
        }

        private void OnCreateEventHandlerProduct(Product product)
        {
            LoadDataProduct();
        }

        private void OnUpdateEventHandlerProduct(Product product)
        {
            int index = lvwproduct.SelectedIndices[0];

            ListViewItem itemRow = lvwproduct.Items[index];
            itemRow.SubItems[1].Text = product.Name;
            itemRow.SubItems[2].Text = product.Brand.Name.ToString();
            itemRow.SubItems[3].Text = product.Quantity.ToString();
            itemRow.SubItems[4].Text = product.Price.ToString();
        }

        private void btnSeaerhAdd_Click(object sender, EventArgs e)
        {
            FrmEntryTransaction frmEntry = new FrmEntryTransaction("Tambah Data Transaction", transactionController, transactionLst);
            frmEntry.OnCreate += OnCreateEventHandlerCashier;
            frmEntry.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmEntryProduct frmEntry = new FrmEntryProduct("Tambah Data Product", productController, brandController);
            frmEntry.OnCreate += OnCreateEventHandlerProduct;
            frmEntry.ShowDialog();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            FrmEntryDataBrand frmEntry = new FrmEntryDataBrand("Tambah Data Brand");
            frmEntry.ShowDialog();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (lvwproduct.SelectedItems.Count > 0)
            {
                Product product = listOfProduct[lvwproduct.SelectedIndices[0]];

                FrmEntryProduct frmEntry = new FrmEntryProduct("Ubah Data Product", product, productController, brandController);
                frmEntry.OnUpdate += OnUpdateEventHandlerProduct;
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data product belum dipilih !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lvwproduct.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Apakah data product ingin dihapus?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (confirmation == DialogResult.Yes)
                {
                    int productId = (int)lvwproduct.SelectedItems[0].Tag; ;
                    var result = productController.Delete(productId);

                    if (result > 0)
                    {
                        LoadDataProduct();
                    }
                }
            }
            else // Data not selected
            {
                MessageBox.Show("Data product belum dipilih !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            helper.SetAuthTokenValue("");
            FormLogin form = new FormLogin();
            form.Show();
            Hide();
        }

        private void btnbayar_Click(object sender, EventArgs e)
        {
            var bayar = Decimal.Parse(txtBayar.Text);
            var total = Decimal.Parse(lblTotalText.Text);

            if (bayar < total)
            {
                MessageBox.Show("Nominal yang harus di bayarkan kurang !!!", "Peringatan",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
            {
                lblKembali.Text = string.Format("Rp. {0}", (total - bayar).ToString());
            }
        }

        private void btnCreateNewtransaction_Click(object sender, EventArgs e)
        {
            initTransactionLst();
            LoadDataTransaction();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmTransactionHistory frmEntry = new FrmTransactionHistory("View History Transaction", transactionLstController);
            //frmEntry.OnCreate += OnCreateEventHandlerProduct;
            frmEntry.ShowDialog();
        }
    }
}
