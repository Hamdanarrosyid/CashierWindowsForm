using CashierWindowsForm.controllers;
using CashierWindowsForm.Controllers;
using CashierWindowsForm.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierWindowsForm.Views
{
    public partial class FrmBrandList : Form
    {
        private List<Brand> lstBrand = new List<Brand>();
        private BrandController controller = new BrandController();
        private void InisialisasiListView()
        {
            lvwBrand.View = View.Details;
            lvwBrand.FullRowSelect = true;
            lvwBrand.GridLines = true;
            lvwBrand.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwBrand.Columns.Add("name", 400, HorizontalAlignment.Center);
        }

        private void LoadListbrand()
        {
            lstBrand = controller.GetAll();
            lvwBrand.Items.Clear();
            foreach (var lst in lstBrand)
            {
                var noUrut = lvwBrand.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.Tag = lst.Id;
                item.SubItems.Add(lst.Name);
                lvwBrand.Items.Add(item);
            }
        }
        public FrmBrandList()
        {
            InitializeComponent();
            InisialisasiListView();
            LoadListbrand();
        }

        public FrmBrandList(string title): this() 
        {
            Text = title;
        }

        private void onCreateUpdateHandler(Brand brand)
        {
            LoadListbrand();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmEntryDataBrand frmEntry = new FrmEntryDataBrand("Tambah Data Brand");
            frmEntry.OnCreate += onCreateUpdateHandler;
            frmEntry.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvwBrand.SelectedItems.Count > 0)
            {
                Brand brand = lstBrand[lvwBrand.SelectedIndices[0]];

                FrmEntryDataBrand frmEntry = new FrmEntryDataBrand("Tambah Data Brand", brand);
                frmEntry.OnUpdate += onCreateUpdateHandler;
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwBrand.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (confirmation == DialogResult.Yes)
                {
                    int id = (int)lvwBrand.SelectedItems[0].Tag; ;
                    var result = controller.Delete(id);

                    if (result > 0)
                    {
                        LoadListbrand();
                    }
                    else
                    {
                        Debug.Print("error");
                    }
                }
            }
            else // Data not selected
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
