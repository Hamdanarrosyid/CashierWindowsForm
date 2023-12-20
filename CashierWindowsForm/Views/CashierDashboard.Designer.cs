namespace CashierWindowsForm.Views
{
    partial class CashierDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwTransaction = new System.Windows.Forms.ListView();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblBayar = new System.Windows.Forms.Label();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.btnSeaerhAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKembali = new System.Windows.Forms.Label();
            this.tabProductManagement = new System.Windows.Forms.TabPage();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.lvwproduct = new System.Windows.Forms.ListView();
            this.tabDashboardCashier = new System.Windows.Forms.TabPage();
            this.btnCreateNewtransaction = new System.Windows.Forms.Button();
            this.btnbayar = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUserManagement = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvwuser = new System.Windows.Forms.ListView();
            this.lblemployee = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabProductManagement.SuspendLayout();
            this.tabDashboardCashier.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabUserManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Location = new System.Drawing.Point(889, 15);
            this.lblTotalText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(30, 13);
            this.lblTotalText.TabIndex = 3;
            this.lblTotalText.Text = "Rp 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // lvwTransaction
            // 
            this.lvwTransaction.HideSelection = false;
            this.lvwTransaction.Location = new System.Drawing.Point(12, 15);
            this.lvwTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.lvwTransaction.Name = "lvwTransaction";
            this.lvwTransaction.Size = new System.Drawing.Size(571, 331);
            this.lvwTransaction.TabIndex = 0;
            this.lvwTransaction.UseCompatibleStateImageBehavior = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(594, 67);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(829, 64);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(90, 20);
            this.txtDiscount.TabIndex = 5;
            // 
            // lblBayar
            // 
            this.lblBayar.AutoSize = true;
            this.lblBayar.Location = new System.Drawing.Point(594, 104);
            this.lblBayar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBayar.Name = "lblBayar";
            this.lblBayar.Size = new System.Drawing.Size(34, 13);
            this.lblBayar.TabIndex = 6;
            this.lblBayar.Text = "Bayar";
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(829, 101);
            this.txtBayar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(90, 20);
            this.txtBayar.TabIndex = 7;
            // 
            // btnSeaerhAdd
            // 
            this.btnSeaerhAdd.Location = new System.Drawing.Point(331, 375);
            this.btnSeaerhAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeaerhAdd.Name = "btnSeaerhAdd";
            this.btnSeaerhAdd.Size = new System.Drawing.Size(115, 19);
            this.btnSeaerhAdd.TabIndex = 8;
            this.btnSeaerhAdd.Text = "Cari dan tambah";
            this.btnSeaerhAdd.UseVisualStyleBackColor = true;
            this.btnSeaerhAdd.Click += new System.EventHandler(this.btnSeaerhAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(467, 375);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 19);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kembali";
            // 
            // lblKembali
            // 
            this.lblKembali.AutoSize = true;
            this.lblKembali.Location = new System.Drawing.Point(889, 313);
            this.lblKembali.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKembali.Name = "lblKembali";
            this.lblKembali.Size = new System.Drawing.Size(30, 13);
            this.lblKembali.TabIndex = 11;
            this.lblKembali.Text = "Rp 0";
            // 
            // tabProductManagement
            // 
            this.tabProductManagement.Controls.Add(this.btnDeleteProduct);
            this.tabProductManagement.Controls.Add(this.btnEditProduct);
            this.tabProductManagement.Controls.Add(this.btnAddProduct);
            this.tabProductManagement.Controls.Add(this.btnBrand);
            this.tabProductManagement.Controls.Add(this.lvwproduct);
            this.tabProductManagement.Location = new System.Drawing.Point(4, 22);
            this.tabProductManagement.Name = "tabProductManagement";
            this.tabProductManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductManagement.Size = new System.Drawing.Size(972, 470);
            this.tabProductManagement.TabIndex = 2;
            this.tabProductManagement.Text = "Product Management";
            this.tabProductManagement.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(370, 427);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(148, 34);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(192, 427);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(148, 34);
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(15, 427);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(148, 34);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.Location = new System.Drawing.Point(793, 20);
            this.btnBrand.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(148, 63);
            this.btnBrand.TabIndex = 1;
            this.btnBrand.Text = "Add Brand";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // lvwproduct
            // 
            this.lvwproduct.HideSelection = false;
            this.lvwproduct.Location = new System.Drawing.Point(0, 0);
            this.lvwproduct.Margin = new System.Windows.Forms.Padding(2);
            this.lvwproduct.Name = "lvwproduct";
            this.lvwproduct.Size = new System.Drawing.Size(760, 412);
            this.lvwproduct.TabIndex = 0;
            this.lvwproduct.UseCompatibleStateImageBehavior = false;
            // 
            // tabDashboardCashier
            // 
            this.tabDashboardCashier.Controls.Add(this.button4);
            this.tabDashboardCashier.Controls.Add(this.btnCreateNewtransaction);
            this.tabDashboardCashier.Controls.Add(this.btnbayar);
            this.tabDashboardCashier.Controls.Add(this.lblKembali);
            this.tabDashboardCashier.Controls.Add(this.label2);
            this.tabDashboardCashier.Controls.Add(this.btnDelete);
            this.tabDashboardCashier.Controls.Add(this.btnSeaerhAdd);
            this.tabDashboardCashier.Controls.Add(this.txtBayar);
            this.tabDashboardCashier.Controls.Add(this.lblBayar);
            this.tabDashboardCashier.Controls.Add(this.txtDiscount);
            this.tabDashboardCashier.Controls.Add(this.lblDiscount);
            this.tabDashboardCashier.Controls.Add(this.lblTotalText);
            this.tabDashboardCashier.Controls.Add(this.label1);
            this.tabDashboardCashier.Controls.Add(this.lvwTransaction);
            this.tabDashboardCashier.Location = new System.Drawing.Point(4, 22);
            this.tabDashboardCashier.Name = "tabDashboardCashier";
            this.tabDashboardCashier.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboardCashier.Size = new System.Drawing.Size(972, 470);
            this.tabDashboardCashier.TabIndex = 0;
            this.tabDashboardCashier.Text = "Dashboard Kasir";
            this.tabDashboardCashier.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewtransaction
            // 
            this.btnCreateNewtransaction.Location = new System.Drawing.Point(12, 375);
            this.btnCreateNewtransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewtransaction.Name = "btnCreateNewtransaction";
            this.btnCreateNewtransaction.Size = new System.Drawing.Size(115, 19);
            this.btnCreateNewtransaction.TabIndex = 13;
            this.btnCreateNewtransaction.Text = "Buat transaksi baru";
            this.btnCreateNewtransaction.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCreateNewtransaction.UseVisualStyleBackColor = true;
            this.btnCreateNewtransaction.Click += new System.EventHandler(this.btnCreateNewtransaction_Click);
            // 
            // btnbayar
            // 
            this.btnbayar.Location = new System.Drawing.Point(829, 155);
            this.btnbayar.Name = "btnbayar";
            this.btnbayar.Size = new System.Drawing.Size(93, 25);
            this.btnbayar.TabIndex = 12;
            this.btnbayar.Text = "Bayar";
            this.btnbayar.UseVisualStyleBackColor = true;
            this.btnbayar.Click += new System.EventHandler(this.btnbayar_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDashboardCashier);
            this.tabControl.Controls.Add(this.tabUserManagement);
            this.tabControl.Controls.Add(this.tabProductManagement);
            this.tabControl.Location = new System.Drawing.Point(12, 53);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(980, 496);
            this.tabControl.TabIndex = 0;
            // 
            // tabUserManagement
            // 
            this.tabUserManagement.Controls.Add(this.button3);
            this.tabUserManagement.Controls.Add(this.button2);
            this.tabUserManagement.Controls.Add(this.button1);
            this.tabUserManagement.Controls.Add(this.lvwuser);
            this.tabUserManagement.Location = new System.Drawing.Point(4, 22);
            this.tabUserManagement.Name = "tabUserManagement";
            this.tabUserManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserManagement.Size = new System.Drawing.Size(972, 470);
            this.tabUserManagement.TabIndex = 1;
            this.tabUserManagement.Text = "User Management";
            this.tabUserManagement.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 382);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 382);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lvwuser
            // 
            this.lvwuser.HideSelection = false;
            this.lvwuser.Location = new System.Drawing.Point(2, 2);
            this.lvwuser.Margin = new System.Windows.Forms.Padding(2);
            this.lvwuser.Name = "lvwuser";
            this.lvwuser.Size = new System.Drawing.Size(600, 375);
            this.lvwuser.TabIndex = 0;
            this.lvwuser.UseCompatibleStateImageBehavior = false;
            // 
            // lblemployee
            // 
            this.lblemployee.AutoSize = true;
            this.lblemployee.Location = new System.Drawing.Point(13, 18);
            this.lblemployee.Name = "lblemployee";
            this.lblemployee.Size = new System.Drawing.Size(63, 13);
            this.lblemployee.TabIndex = 1;
            this.lblemployee.Text = "lblEmployee";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(893, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.Size = new System.Drawing.Size(95, 26);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(131, 375);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 19);
            this.button4.TabIndex = 14;
            this.button4.Text = "Tampilkan Riwayat Transaksi";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblemployee);
            this.Controls.Add(this.tabControl);
            this.Name = "CashierDashboard";
            this.Text = "CashierDashboard";
            this.tabProductManagement.ResumeLayout(false);
            this.tabDashboardCashier.ResumeLayout(false);
            this.tabDashboardCashier.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabUserManagement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabProductManagement;
        private System.Windows.Forms.ListView lvwTransaction;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Label lblBayar;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSeaerhAdd;
        private System.Windows.Forms.Label lblKembali;
        private System.Windows.Forms.TabPage tabDashboardCashier;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUserManagement;
        private System.Windows.Forms.ListView lvwuser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvwproduct;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Label lblemployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnbayar;
        private System.Windows.Forms.Button btnCreateNewtransaction;
        private System.Windows.Forms.Button button4;
    }
}