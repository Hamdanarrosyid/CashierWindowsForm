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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDashboardCashier = new System.Windows.Forms.TabPage();
            this.tabUserManagement = new System.Windows.Forms.TabPage();
            this.tabProductManagement = new System.Windows.Forms.TabPage();
            this.lvwproduct = new System.Windows.Forms.ListView();
            this.btnbrand = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabProductManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDashboardCashier);
            this.tabControl.Controls.Add(this.tabUserManagement);
            this.tabControl.Controls.Add(this.tabProductManagement);
            this.tabControl.Location = new System.Drawing.Point(16, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1307, 661);
            this.tabControl.TabIndex = 0;
            // 
            // tabDashboardCashier
            // 
            this.tabDashboardCashier.Location = new System.Drawing.Point(4, 25);
            this.tabDashboardCashier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDashboardCashier.Name = "tabDashboardCashier";
            this.tabDashboardCashier.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDashboardCashier.Size = new System.Drawing.Size(1299, 632);
            this.tabDashboardCashier.TabIndex = 0;
            this.tabDashboardCashier.Text = "Dashboard Kasir";
            this.tabDashboardCashier.UseVisualStyleBackColor = true;
            // 
            // tabUserManagement
            // 
            this.tabUserManagement.Location = new System.Drawing.Point(4, 25);
            this.tabUserManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabUserManagement.Name = "tabUserManagement";
            this.tabUserManagement.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabUserManagement.Size = new System.Drawing.Size(1299, 632);
            this.tabUserManagement.TabIndex = 1;
            this.tabUserManagement.Text = "User Management";
            this.tabUserManagement.UseVisualStyleBackColor = true;
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
            this.tabProductManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDashboardCashier;
        private System.Windows.Forms.TabPage tabUserManagement;
        private System.Windows.Forms.TabPage tabProductManagement;
        private System.Windows.Forms.ListView lvwproduct;
        private System.Windows.Forms.Button btnbrand;
    }
}