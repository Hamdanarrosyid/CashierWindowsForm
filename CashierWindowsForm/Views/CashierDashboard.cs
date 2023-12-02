using CashierWindowsForm.controllers;
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
        public CashierDashboard()
        {
            InitializeComponent();
            InisialisasiListViewProduct();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InisialisasiListViewProduct()
        {
            lvwproduct.View = System.Windows.Forms.View.Details;
            lvwproduct.FullRowSelect = true;
            lvwproduct.GridLines = true;
            lvwproduct.Columns.Add("Name", 200, HorizontalAlignment.Center);
            lvwproduct.Columns.Add("Brand", 200, HorizontalAlignment.Center);
            lvwproduct.Columns.Add("Stock", 200, HorizontalAlignment.Center);
            lvwproduct.Columns.Add("Price", 200, HorizontalAlignment.Center);
        }

        private void lvwdashboard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwproduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private List<Brand> listOfBrand = new List<Brand>();
        private ProductController controller;

        private void LoadDataMahasiswa()
        {
            // kosongkan listview
            lvwproduct.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            //listOfBrand = controller.ReadAll();

            // ekstrak objek mhs dari collection
            foreach (var brd in listOfBrand)
            {
                var noUrut = lvwproduct.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(brd.BrandId);
                item.SubItems.Add(brd.Name);

                // tampilkan data mhs ke listview
                lvwproduct.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEntryBrand frmbrand = new FrmEntryBrand();
            frmbrand.Show();
        }
    }
}
