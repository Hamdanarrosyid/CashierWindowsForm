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
        public delegate void CreateUpdateEventHandler(Brand brand);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;

        private Brand editBrand;

        private readonly BrandController brandController = new BrandController();
        public FrmEntryDataBrand()
        {
            InitializeComponent();
        }

        public FrmEntryDataBrand(string title) : this()
        {
            Text = title;
        }

        public FrmEntryDataBrand(string title, Brand _brand) : this()
        {
            Text = title;
            editBrand = _brand;
            txtname.Text = _brand.Name;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (editBrand == null)
            {
                Brand brand = new Brand();
                brand.Name = txtname.Text;
                var result = brandController.Create(brand);
                if (result > 0)
                {
                    txtname.Clear();
                    OnCreate(brand);
                    MessageBox.Show("Success", "Brand berhasil ditambahkan", MessageBoxButtons.OK);
                    Close();
                }
            }
            else
            {
                editBrand.Name = txtname.Text;
                var result = brandController.Update(editBrand);
                if (result > 0)
                {
                    txtname.Clear();
                    OnUpdate(editBrand);
                    MessageBox.Show("Success", "Brand berhasil di update", MessageBoxButtons.OK);
                    Close();
                }
            }

        }
    }
}
