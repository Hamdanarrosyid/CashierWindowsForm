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
            this.SuspendLayout();
            // 
            // tabProductManagement
            // 
            this.tabProductManagement.Location = new System.Drawing.Point(4, 25);
            this.tabProductManagement.Margin = new System.Windows.Forms.Padding(4);
            this.tabProductManagement.Name = "tabProductManagement";
            this.tabProductManagement.Padding = new System.Windows.Forms.Padding(4);
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
            // CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 690);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashierDashboard";
            this.Text = "CashierDashboard";
            this.tabControl.ResumeLayout(false);
            this.tabUserManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabProductManagement;
        private System.Windows.Forms.TabPage tabDashboardCashier;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUserManagement;
        private System.Windows.Forms.ListView lvwuser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}