using CashierWindowsForm.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierWindowsForm
{
    public partial class FormLogin : Form
    {
        private controllers.EmployeeController employee = new controllers.EmployeeController();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Email or password cannot be empty");
            }
            else
            {
                var res = employee.Login(txtEmail.Text, txtPassword.Text);
                if (res == null)
                {
                    MessageBox.Show("Email or password may be incorrect");
                }else
                {
                    CashierDashboard form = new CashierDashboard();
                    form.Show();
                    Hide();
                }
            }
            
        }
    }
}
