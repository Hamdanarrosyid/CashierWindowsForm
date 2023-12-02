using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashierWindowsForm.controllers;
using CashierWindowsForm.Controllers;
using CashierWindowsForm.Models.Entity;


namespace CashierWindowsForm.Views
{
    public partial class FrmEntryBrand : Form
    {
        public FrmEntryBrand()
        {
            InitializeComponent();
        }

        public FrmEntryBrand(string title, ProductController controller)
        {
            this.Text = title;
            this.controller = controller;  
        }

        private List<Brand> listOfBrand = new List<Brand>();
        private ProductController controller;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmEntryBrand_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntryBrand frmEntry = new FrmEntryBrand("Tambah data Brand", controller);
        }
    }
}
