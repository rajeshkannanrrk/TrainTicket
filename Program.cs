using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTicketManagementSystemProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginPanel());
            //Application.Run(new CustomerPanelTransaction());
            //Application.Run(new AdminPanel());
            //Application.Run(new CustomerRequest());
            //Application.Run(new CustomerInformation());
            
            //Application.Run(new SignUpPanel());

            LoginPanel login = new LoginPanel();
            login.Show();
            Application.Run();
            
            
            
        }
    }
}
