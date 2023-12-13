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
using CashierWindowsForm.models;
using CashierWindowsForm.controllers;

namespace CashierWindowsForm.Views
{
    public partial class CashierDashboard : Form
    {
        private List<Employee> listofUser = new List<Employee>();

        private EmployeeController controller= new EmployeeController();
        private void InisialisasiListViewuser()
        {
            lvwuser.View = System.Windows.Forms.View.Details;
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

            controller = new EmployeeController();
            InisialisasiListViewuser();
            LoadDataEmployee();

            

        }
        // method untuk menampilkan semua data mahasiswa
        private void LoadDataEmployee()
        {
            // kosongkan listview
            lvwuser.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listofUser = controller.ReadAll();
            // ekstrak objek mhs dari collection
            foreach (var emp in listofUser)
            {
                var noUrut = lvwuser.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(emp.Name);
                item.SubItems.Add(emp.Email);
                item.SubItems.Add(emp.Gender);
                item.SubItems.Add(emp.Address);
                // tampilkan data mhs ke listview
                lvwuser.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
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
           
                // buat objek form entry data mahasiswa
                FrmEntryUser frmEntry = new FrmEntryUser("Tambah Data Employee", controller);
                // mendaftarkan method event handler untuk merespon event OnCreate
             // (BLM DIKERJAIN)   frmEntry.OnCreate += OnCreateEventHandler;
                // tampilkan form entry mahasiswa
                frmEntry.ShowDialog();
            
        }
    }
}
