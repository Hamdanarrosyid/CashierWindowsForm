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
    public partial class FrmEntryDataBrand : Form
    {
        private readonly BrandController brandController = new BrandController();
        public FrmEntryDataBrand()
        {
            InitializeComponent();
        }

        public FrmEntryDataBrand(string title) : this()
        {
            Text = title;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.Name = txtname.Text;
            var result = brandController.Create(brand);

            if (result > 0)
            {
                txtname.Clear();
                MessageBox.Show("Success", "Brand berhasil ditambahkan", MessageBoxButtons.OK);
                Close();
            }
           
        }
    }
}
