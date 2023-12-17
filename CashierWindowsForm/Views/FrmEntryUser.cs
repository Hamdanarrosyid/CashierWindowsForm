using CashierWindowsForm.controllers;
using CashierWindowsForm.models;
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
    public partial class FrmEntryUser : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Employee emp);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi objek controller
        private EmployeeController controller;
        // deklarasi field untuk menyimpan status entry data (input baru atau update)
 private bool isNewData = true;
        // deklarasi field untuk meyimpan objek mahasiswa
        private Employee emp;
        public FrmEntryUser()
        {
            InitializeComponent();
        }

        public FrmEntryUser(string title, EmployeeController controller)
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        public FrmEntryUser(string title, Employee obj, EmployeeController controller)
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
            isNewData = false; // set status edit data
            emp = obj; // set objek mhs yang akan diedit
                       // untuk edit data, tampilkan data lama
            textBox1.Text = emp.Name;
            textBox2.Text = emp.Email;
            textBox3.Text = emp.Gender;
            textBox4.Text = emp.Address;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) emp = new Employee();
            // set nilai property objek mahasiswa yg diambil dari TextBox
            emp.Name = textBox1.Text;
            emp.Email = textBox2.Text;
            emp.Gender = textBox3.Text;
            emp.Address = textBox4.Text;
            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(emp);
                if (result > 0) // tambah data berhasil
                {
                    OnCreate(emp); // panggil event OnCreate
                                   // reset form input, utk persiapan input data berikutnya
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(emp);
                if (result > 0)
                {
                    OnUpdate(emp); // panggil event OnUpdate
                    this.Close();
                }
            }

        }
    }
}
