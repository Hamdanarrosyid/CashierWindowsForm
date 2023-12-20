namespace CashierWindowsForm.Views
{
    partial class FrmTransactionHistory
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
            this.lvwTransactionHistory = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvwTransactionHistory
            // 
            this.lvwTransactionHistory.HideSelection = false;
            this.lvwTransactionHistory.Location = new System.Drawing.Point(11, 11);
            this.lvwTransactionHistory.Margin = new System.Windows.Forms.Padding(2);
            this.lvwTransactionHistory.Name = "lvwTransactionHistory";
            this.lvwTransactionHistory.Size = new System.Drawing.Size(666, 331);
            this.lvwTransactionHistory.TabIndex = 1;
            this.lvwTransactionHistory.UseCompatibleStateImageBehavior = false;
            this.lvwTransactionHistory.SelectedIndexChanged += new System.EventHandler(this.lvwTransactionHistory_SelectedIndexChanged);
            // 
            // FrmTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 357);
            this.Controls.Add(this.lvwTransactionHistory);
            this.Name = "FrmTransactionHistory";
            this.Text = "FrmTransactionHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwTransactionHistory;
    }
}