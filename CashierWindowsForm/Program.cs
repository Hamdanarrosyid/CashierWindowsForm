using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashierWindowsForm.Views;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace CashierWindowsForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Check if the token is present in the configuration manager
            string token = ConfigurationManager.AppSettings["AuthToken"];

            // If the token is present, open the DashboardForm
            // Otherwise, open the FormLogin
            if (!string.IsNullOrEmpty(token))
            {
                Application.Run(new CashierDashboard());
            }
            else
            {
                Application.Run(new FormLogin());
            }
        }
    }
}
