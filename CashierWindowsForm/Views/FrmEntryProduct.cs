using CashierWindowsForm.controllers;
using CashierWindowsForm.Controllers;
using CashierWindowsForm.models;
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
    public partial class FrmEntryProduct : Form
    {
        public delegate void CreateUpdateEventHandler(Product product);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;

        private readonly ProductController productController;
        private readonly BrandController brandController;

        private Product editingProduct;

        public FrmEntryProduct()
        {
            InitializeComponent();
        }

        public FrmEntryProduct(string title, ProductController _productController, BrandController _brandController): this()
        {
            Text = title;
            productController = _productController;
            brandController = _brandController;
            loadBrand();
        }


        public FrmEntryProduct(string title, Product product, ProductController _productController, BrandController _brandController) : this()
        {
            Text = title;
            editingProduct = product;
            productController = _productController;
            brandController = _brandController;
            loadBrand();
            LoadProductData();
        }

        private void loadBrand()
        {
            lstBrand.Items.Clear();
            
            var brands = brandController.GetAll();

            foreach (var brand in brands)
            {
                lstBrand.Items.Add(brand);
                lstBrand.DisplayMember = "Name";
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (editingProduct == null)
            {
                // Create a new product
                Product product = new Product();
                SetProductData(product);

                var result = productController.Create(product);

                if (result > 0)
                {
                    MessageBox.Show("Success", "Berhasil menambah product", MessageBoxButtons.OK);
                    OnCreate(product);
                    Close();
                }
            }
            else
            {
                // Update the existing product
                SetProductData(editingProduct);

                var result = productController.Update(editingProduct);

                if (result > 0)
                {
                    MessageBox.Show("Success", "Berhasil mengupdate product", MessageBoxButtons.OK);
                    OnUpdate(editingProduct);
                    Close();
                }
            }
        }

        private void LoadProductData()
        {
            if (editingProduct != null)
            {
                txtName.Text = editingProduct.Name;
                txtPrice.Text = editingProduct.Price.ToString();
                txtStock.Text = editingProduct.Quantity.ToString();
                var brands = brandController.GetAll();
                Brand selectedBrand = brands.FirstOrDefault(b => b.Id == editingProduct.Brand.Id);

                lstBrand.SelectedIndex = brands.IndexOf(selectedBrand); ;
                lstBrand.DisplayMember = "Name";
            }
        }

        private void SetProductData(Product product)
        {
            product.Name = txtName.Text;
            product.Price = decimal.Parse(txtPrice.Text);
            product.Quantity = int.Parse(txtStock.Text);
            if (lstBrand.SelectedItem != null)
            {
                Brand selectedBrand = (Brand)lstBrand.SelectedItem;
                int selectedBrandId = selectedBrand.Id;
                product.BrandId = selectedBrandId;
            }
            product.Brand = brandController.Get(product.BrandId);
        }
    }
}
