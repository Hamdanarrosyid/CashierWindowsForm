using CashierWindowsForm.Lib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Aztec.Internal;

namespace CashierWindowsForm.Utils
{
    public class Helper
    {

        private JwtManager jwtManager = new JwtManager();
        private string token;

        public Helper() {
            token = ConfigurationManager.AppSettings["AuthToken"];
        }
        public void SetAuthTokenValue(string authToken)
        {
            try
            {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appSettings = configuration.AppSettings.Settings;

                // Check if the key exists
                if (appSettings["AuthToken"] == null)
                {
                    // If not, add the key
                    appSettings.Add("AuthToken", authToken);
                }
                else
                {
                    // If the key exists, update its value
                    appSettings["AuthToken"].Value = authToken;
                }

                configuration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting AuthToken: " + ex.Message);
            }
        }
        public string GetClaimValue(string claimType)
        {
            var principal = jwtManager.ValidateToken(token);

            if (principal != null)
            {
                Console.WriteLine("Token is valid.");
                // Access claims if needed
                var claimValue = principal.FindFirst(claimType)?.Value;
                return claimValue;
            }

            return null;
        }

    }
}
