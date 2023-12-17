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
            this.tabDashboardCashier.SuspendLayout();
            this.tabProductManagement = new System.Windows.Forms.TabPage();
            this.tabDashboardCashier = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUserManagement = new System.Windows.Forms.TabPage();
            this.lvwuser = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabUserManagement.SuspendLayout();
            this.lvwproduct = new System.Windows.Forms.ListView();
            this.btnbrand = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabProductManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProductManagement
            // 
            this.tabProductManagement.Controls.Add(this.btnbrand);
            this.tabProductManagement.Controls.Add(this.lvwproduct);
            this.tabProductManagement.Location = new System.Drawing.Point(4, 25);
            this.tabProductManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabProductManagement.Name = "tabProductManagement";
            this.tabProductManagement.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabProductManagement.Size = new System.Drawing.Size(1299, 632);
            this.tabProductManagement.TabIndex = 2;
            this.tabProductManagement.Text = "Product Management";
            this.tabProductManagement.UseVisualStyleBackColor = true;
            // 
            // tabDashboardCashier
            // 
            this.tabDashboardCashier.Location = new System.Drawing.Point(4, 25);
            this.tabDashboardCashier.Margin = new System.Windows.Forms.Padding(4);
            this.tabDashboardCashier.Name = "tabDashboardCashier";
            this.tabDashboardCashier.Padding = new System.Windows.Forms.Padding(4);
            this.tabDashboardCashier.Size = new System.Drawing.Size(1299, 632);
            this.tabDashboardCashier.TabIndex = 0;
            this.tabDashboardCashier.Text = "Dashboard Kasir";
            this.tabDashboardCashier.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDashboardCashier);
            this.tabControl.Controls.Add(this.tabUserManagement);
            this.tabControl.Controls.Add(this.tabProductManagement);
            this.tabControl.Location = new System.Drawing.Point(16, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1307, 661);
            this.tabControl.TabIndex = 0;
            // 
            // tabUserManagement
            // 
            this.tabUserManagement.Controls.Add(this.button3);
            this.tabUserManagement.Controls.Add(this.button2);
            this.tabUserManagement.Controls.Add(this.button1);
            this.tabUserManagement.Controls.Add(this.lvwuser);
            this.tabUserManagement.Location = new System.Drawing.Point(4, 25);
            this.tabUserManagement.Margin = new System.Windows.Forms.Padding(4);
            this.tabUserManagement.Name = "tabUserManagement";
            this.tabUserManagement.Padding = new System.Windows.Forms.Padding(4);
            this.tabUserManagement.Size = new System.Drawing.Size(1299, 632);
            this.tabUserManagement.TabIndex = 1;
            this.tabUserManagement.Text = "User Management";
            this.tabUserManagement.UseVisualStyleBackColor = true;
            //
            // tabDashboardCashier
            // 
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
            this.tabDashboardCashier.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDashboardCashier.Size = new System.Drawing.Size(1299, 632);
            this.tabDashboardCashier.TabIndex = 0;
            this.tabDashboardCashier.Text = "Dashboard Kasir";
            this.tabDashboardCashier.UseVisualStyleBackColor = true;
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Location = new System.Drawing.Point(915, 19);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(30, 13);
            this.lblTotalText.TabIndex = 3;
            this.lblTotalText.Text = "Rp 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // lvwTransaction
            // 
            this.lvwTransaction.HideSelection = false;
            this.lvwTransaction.Location = new System.Drawing.Point(16, 19);
            this.lvwTransaction.Name = "lvwTransaction";
            this.lvwTransaction.Size = new System.Drawing.Size(760, 406);
            this.lvwTransaction.TabIndex = 0;
            this.lvwTransaction.UseCompatibleStateImageBehavior = false;
            // 
            // lvwuser
            // 
            this.lvwuser.HideSelection = false;
            this.lvwuser.Location = new System.Drawing.Point(3, 3);
            this.lvwuser.Name = "lvwuser";
            this.lvwuser.Size = new System.Drawing.Size(799, 461);
            this.lvwuser.TabIndex = 0;
            this.lvwuser.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(720, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lvwproduct
            // 
            this.lvwproduct.HideSelection = false;
            this.lvwproduct.Location = new System.Drawing.Point(0, 0);
            this.lvwproduct.Name = "lvwproduct";
            this.lvwproduct.Size = new System.Drawing.Size(1033, 632);
            this.lvwproduct.TabIndex = 0;
            this.lvwproduct.UseCompatibleStateImageBehavior = false;
            this.lvwproduct.SelectedIndexChanged += new System.EventHandler(this.lvwproduct_SelectedIndexChanged);
            // 
            // btnbrand
            // 
            this.btnbrand.Location = new System.Drawing.Point(1071, 42);
            this.btnbrand.Name = "btnbrand";
            this.btnbrand.Size = new System.Drawing.Size(198, 77);
            this.btnbrand.TabIndex = 1;
            this.btnbrand.Text = "Add Brand";
            this.btnbrand.UseVisualStyleBackColor = true;
            this.btnbrand.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(792, 82);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(847, 79);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(119, 20);
            this.txtDiscount.TabIndex = 5;
            // 
            // lblBayar
            // 
            this.lblBayar.AutoSize = true;
            this.lblBayar.Location = new System.Drawing.Point(792, 128);
            this.lblBayar.Name = "lblBayar";
            this.lblBayar.Size = new System.Drawing.Size(34, 13);
            this.lblBayar.TabIndex = 6;
            this.lblBayar.Text = "Bayar";
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(847, 125);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(119, 20);
            this.txtBayar.TabIndex = 7;
            // 
            // btnSeaerhAdd
            // 
            this.btnSeaerhAdd.Location = new System.Drawing.Point(16, 461);
            this.btnSeaerhAdd.Name = "btnSeaerhAdd";
            this.btnSeaerhAdd.Size = new System.Drawing.Size(153, 23);
            this.btnSeaerhAdd.TabIndex = 8;
            this.btnSeaerhAdd.Text = "Cari dan tambah";
            this.btnSeaerhAdd.UseVisualStyleBackColor = true;
            this.btnSeaerhAdd.Click += new System.EventHandler(this.btnSeaerhAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(623, 461);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kembali";
            // 
            // lblKembali
            // 
            this.lblKembali.AutoSize = true;
            this.lblKembali.Location = new System.Drawing.Point(915, 173);
            this.lblKembali.Name = "lblKembali";
            this.lblKembali.Size = new System.Drawing.Size(30, 13);
            this.lblKembali.TabIndex = 11;
            this.lblKembali.Text = "Rp 0";
            // 
            // CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 690);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CashierDashboard";
            this.Text = "CashierDashboard";
            this.tabControl.ResumeLayout(false);
            this.tabDashboardCashier.ResumeLayout(false);
            this.tabDashboardCashier.PerformLayout();
            this.tabProductManagement.ResumeLayout(false);
            this.tabUserManagement.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnbrand;

    }
}